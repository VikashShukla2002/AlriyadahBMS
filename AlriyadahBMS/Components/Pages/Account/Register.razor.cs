using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AlriyadahBMS.Shared.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AlriyadahBMS.Shared.ApiModels;
using MudBlazor;
using Microsoft.AspNetCore.Components.Forms;
using static MudBlazor.CategoryTypes;

namespace AlriyadahBMS.Components.Pages.Account
{
    public partial class Register
    {
        private RegisterModels RegisterModel { get; set; } = new();
        private byte[] File { get; set; } = null!;
        private bool IsNationalIdValid { get; set; }
        MudForm Form { get; set; } = null!;

        private async Task OnClickSubmit(RegisterModels register)
        {
            if (!IsNationalIdValid)
            {
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
                Snackbar.Add("Please verify nationalId", Severity.Error);
            }
            await Form.Validate();
            if (Form.IsValid && IsNationalIdValid)
            {
                //   register.Absherphoto = "file_example_PNG_500kB.png";
                var response = await RegisterService.Register(register, File, register.Absherphoto);
                if (response.Success)
                {
                    Snackbar.Add("User registered successfully", Severity.Success);
                    NavigationManager.NavigateTo("/login");
                }
                else
                {
                    Snackbar.Add(response.FailureMessage, Severity.Error);
                }
                var check = response;
            }

        }

        private void FileChanged(byte[] file) => File = file;
        private void NationalIdValidate(bool isValid) => IsNationalIdValid = isValid;

    }
}
