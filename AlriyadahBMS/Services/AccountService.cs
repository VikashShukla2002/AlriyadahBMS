using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services
{
    public class AccountService : IAccountService
    {
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ISwaggerApiService _apiService;
        private readonly HttpClient _client;

        public AccountService(AuthenticationStateProvider authStateProvider, ISwaggerApiService apiService, HttpClient client)
        {
            _authStateProvider = authStateProvider;
            _apiService = apiService;
            _client = client;
        }

        public async Task<SignInResponse> LoginAsync(SignInRequest signInRequest)
        {
            var response = await _apiService.PostAsync<SignInRequest, SignInResponse>("api/login", signInRequest);
            if (response!.Success)
            {
                await SecureStorage.SetAsync("JWTToken", response!.JWT!);
                ((AuthenticationStateService)_authStateProvider).NotifyUserLoggedIn(response.JWT);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.JWT);
            }
            return response;
        }

        public void Logout()
        {
            SecureStorage.Remove("JWTToken");
            ((AuthenticationStateService)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
