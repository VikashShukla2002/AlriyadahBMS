using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services.IServices
{
    public interface IAccountService
    {
   
        Task<SignInResponse> LoginAsync(SignInRequest signInRequest);


        Task<bool> RegisterUserAsync(RegisterModels signUpRequest);

        void Logout();
    }
}
