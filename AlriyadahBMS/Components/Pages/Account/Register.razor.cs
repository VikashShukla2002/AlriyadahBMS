using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AlriyadahBMS.Shared.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AlriyadahBMS.Shared.ApiModels;

namespace AlriyadahBMS.Components.Pages.Account
{
    public partial class Register
    {
        private RegisterModels RegisterModel { get; set; } = new();

        private async Task OnClickSubmit(RegisterModels register)
        {
              var response =  await RegisterService.Register(register);
            var check = response;

        }

    }
}
