
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Components.Pages.Account
{
    public partial class Login
    {
        private LoginModel LoginModel { get; set; } = new();

        private bool ShowPassword { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            await CheckAuthenticationState();
        }

        private async Task OnValidSubmitAsync()
        {

            //var response = await Swagger.PostAsync<SignInRequest, SignInResponse>("api/login", new SignInRequest
            //{
            //    UserName = LoginModel.UserName,
            //    Password = LoginModel.Password
            //});
            var response = await AccountService!.LoginAsync(new SignInRequest
            {
                UserName = LoginModel!.UserName,
                Password = LoginModel!.Password
            });

            if (response!.Success)
            {
                NavigationManager.NavigateTo("/", false, true);
                Snackbar.Add(response?.Message?.ToString(), Severity.Success);
            }
            else
            {
                Snackbar.Add(response?.Message?.ToString(), Severity.Error);
                //Snackbar.Add("some error occured", Severity.Error);
            }

        }

        private async Task CheckAuthenticationState()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user!.Identity!.IsAuthenticated)
            {
                // User is already authenticated, redirect to another page
                NavigationManager.NavigateTo("/", false, true);
                //await JSRuntime.ShowToastAsync("You don't have access to open this page", SwalIcon.Success);
            }
        }

        private InputType GetInputType()
        {
            return ShowPassword ? InputType.Text : InputType.Password;
        }
    }
}
