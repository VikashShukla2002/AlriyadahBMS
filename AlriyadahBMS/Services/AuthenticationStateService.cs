
using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.Helper;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace AlriyadahBMS.Services
{
    public class AuthenticationStateService : AuthenticationStateProvider, IAuthenticationStateService
    {

        private readonly HttpClient _httpClient;
        //private readonly ILocalStorageService _localStorage;

        public AuthenticationStateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await SecureStorage.GetAsync("JWTToken");
            if (token == null)
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "JWTAuthType")));
        }
        public void NotifyUserLoggedIn(string? token)
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "JWTAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
            

        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
