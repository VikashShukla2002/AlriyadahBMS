using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using Newtonsoft.Json;

namespace AlriyadahBMS.Services
{
    public class SwaggerApiService : ISwaggerApiService
    {

        private readonly HttpClient _client;

        public SwaggerApiService(HttpClient client)
        {
            _client = client;
        }

        public Task<TResponse?> GetAsync<TResponse>(string url, Dictionary<string, string>? queryParams = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request) where TResponse : BaseApiResponse
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
    }
}
