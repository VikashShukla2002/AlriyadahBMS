using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.ViewModels;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using AlriyadahBMS.Shared.Helper;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http;

namespace AlriyadahBMS.Services
{
    public class SwaggerApiService : ISwaggerApiService
    {

        private readonly HttpClient _client;
        private readonly NavigationManager _navigation;


        public SwaggerApiService(HttpClient client, NavigationManager navigation)
        {
            _client = client;
            _navigation = navigation;
        }

        public async Task<TResponse?> GetAsync<TResponse>(string url)
        //where TResponse : ApiResponse<TResponse>
        {

            // var jwtPayloadData = JwtSecurityTokenHandler

            //if (!IsValidToken())
            //{
            //    _navigation.NavigateTo("/logout");
            //    return default;
            //}

            //var errorResult = Activator.CreateInstance(typeof(TResponse)) as TResponse;
            try
            {
                var response = await _client.GetAsync(_client.BaseAddress + url);
                var contentTemp = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<TResponse>(contentTemp);
                    //result!.StatusCode = response.StatusCode;
                    //result.Success = true;
                    return result;
                }


                //if (response.IsSuccessStatusCode)
                //{
                //    // Deserialize as a collection of StudentRegistrationModel
                //    var result = JsonConvert.DeserializeObject<List<StudentRegistrationModel>>(contentTemp);
                //    return result;
                //}
                //else
                //{
                //    errorResult!.StatusCode = response.StatusCode;
                //    errorResult!.Message = contentTemp;
                //}
            }
            catch (Exception ex)
            {
                _ = ex;
                //errorResult!.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                //errorResult.Message = ex.Message;
                //errorResult.Message = ex.Message;
            }
            //return errorResult;
            return default;

        }

        public async Task<UpdateApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string url, string tableName, TRequest request)
        {
            //if (!IsValidToken())
            //{
            //    _navigation.NavigateTo("/logout");
            //}


            var errorResult = new UpdateApiResponse<TResponse>();
            try
            {
                var content = JsonConvert.SerializeObject(request);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(_client.BaseAddress + url, bodyContent);

                var contentTemp = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var tempResult = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentTemp);
                    var result = JsonConvert.DeserializeObject<UpdateApiResponse<TResponse>>(contentTemp);
                    result!.Success = false;
                    if (tempResult!.TryGetValue(tableName, out object? value))
                    {
                        result.Success = true;
                        result!.Data = ((JObject)value).ToObject<TResponse>();
                    }
                    return result!;
                }
                errorResult!.Success = false;
                errorResult.FailureMessage = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                errorResult!.Success = false;
                errorResult.FailureMessage = ex.Message;

            }
            return errorResult;
        }

        public async Task<TResponse?> PostWithFormBodyAsync<TRequest, TResponse>(string url, TRequest request) where TResponse : BaseApiResponse
        {

            var fromData = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(request));
            var content = new FormUrlEncodedContent(fromData!);
            var errorResult = Activator.CreateInstance(typeof(TResponse)) as TResponse;
            try
            {
                var response = await _client.PostAsync(_client.BaseAddress + url, content);

                var contentTemp = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<TResponse>(contentTemp);
                    result!.StatusCode = response.StatusCode;
                    result.Success = true;
                    return result;
                }
                else
                {

                    errorResult!.StatusCode = response.StatusCode;
                    errorResult!.Message = contentTemp;
                }
            }
            catch (Exception ex)
            {
                errorResult!.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                errorResult.Message = ex.Message;
            }
            return errorResult;
        }




        public Task<SignUpResponse> RegisterAsync(RegisterModels registerModel)
        {
            throw new NotImplementedException();
        }




        //public Task<UploadResult> UploadFilesAsync(string url, IEnumerable<IBrowserFile> files)
        //{

        //    throw new NotImplementedException();
        //}

        public async Task<UploadResult> UploadFilesAsync(string url, IBrowserFile files)
        {

            var formData = new MultipartFormDataContent();

            var fileStreamContent = new StreamContent(files.OpenReadStream());

            formData.Add(fileStreamContent, "file", files.Name);
            var response = await _client.PostAsync(_client.BaseAddress + url, formData);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var uploadResult = JsonConvert.DeserializeObject<UploadResult>(responseContent);

            return uploadResult;

            //throw new NotImplementedException();
        }

        private bool IsValidToken()
        {
            
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String("K9tcLJ5Eqxav6yfc")),
                ValidateIssuer = false, 
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero 
            };

            try
            {
                SecurityToken validatedToken;
                tokenHandler.ValidateToken(_client.DefaultRequestHeaders.Authorization?.Parameter, validationParameters, out validatedToken);
                return true;
            }
            catch (SecurityTokenExpiredException)
            {
                return false; // Token has expired
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                return false; // Token signature is invalid or tampered
            }
            catch (SecurityTokenValidationException)
            {
                return false; // Token validation failed
            }
        }


    }
}
