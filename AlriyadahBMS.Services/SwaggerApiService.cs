using AlriyadahBMS.Services.IServices;
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

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request)
        {
            var fromData = JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(request));
            var content = new FormUrlEncodedContent(fromData!);
            var response = await _client.PostAsync(_client.BaseAddress + url, content);

            var contentTemp = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<TResponse>(contentTemp);
                return result;
            }
            else
            {
                // var errorResponse = response.Content.ReadFromJsonAsync<ErrorResponse>();
            }

            return default;
        }
    }
}
