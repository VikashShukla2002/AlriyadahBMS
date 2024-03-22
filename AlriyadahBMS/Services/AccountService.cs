using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
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
            var response = await _apiService.PostWithFormBodyAsync<SignInRequest, SignInResponse>(AccountApiConst.POST_SignIn, signInRequest);
            if (response!.Success)
            {
                //await SecureStorage.SetAsync("JWTToken", response!.JWT!);
                await SecureStorage.SetAsync(ApplicationConst.Local_Token, response!.JWT!);



                //Preferences.Set(ApplicationConst.Local_Token, response!.JWT!);

                // await SecureStorage.SetAsync(ApplicationConst.Local_Token, response!.JWT!);
                ((AuthenticationStateService)_authStateProvider).NotifyUserLoggedIn(response.JWT);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.JWT);
            }
            return response;
        }

        public void Logout()
        {
            //Preferences.Remove(ApplicationConst.Local_Token);          
            SecureStorage.Remove(ApplicationConst.Local_Token);
            ((AuthenticationStateService)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public Task<bool> RegisterUserAsync(RegisterModels signUpRequest)
        {
            throw new NotImplementedException();
        }
    }
}
