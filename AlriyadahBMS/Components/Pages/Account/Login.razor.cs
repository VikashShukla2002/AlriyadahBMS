
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.CategoryTypes;

namespace AlriyadahBMS.Components.Pages.Account
{
    public partial class Login
    {
        private LoginModel LoginModel { get; set; } = new();

        private bool ShowPassword { get; set; } = false;

        private MudForm form { get; set; } = null!;
        protected override async Task OnInitializedAsync()
        {
            await CheckAuthenticationState();
        }

        private async Task OnValidSubmitAsync()
        {
            //await form.Validate();
            //if (form.IsValid)
            //{
                var response = await AccountService!.LoginAsync(new SignInRequest
                {
                    UserName = LoginModel!.UserName,
                    Password = LoginModel!.Password
                });

                if (response!.Success)
                {
                    NavigationManager.NavigateTo("/tblStudentlist", false, true);

                    Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
                    Snackbar.Add(response?.Message?.ToString(), Severity.Success);
                }
                else
                {

                    Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
                    Snackbar.Add(response?.Message?.ToString(), Severity.Error);
                }
           // }

            //else
            //{

            //}

        }






        private async Task CheckAuthenticationState()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user!.Identity!.IsAuthenticated)
            {
                NavigationManager.NavigateTo("/tblStudentlist", false, true);
                //await JSRuntime.ShowToastAsync("You don't have access to open this page", SwalIcon.Success);
            }
        }

        private InputType GetInputType()
        {
            return ShowPassword ? InputType.Text : InputType.Password;
        }
    }
}
