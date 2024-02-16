using AlriyadahBMS.Shared.ApiModels;
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
      
        void Logout();
    }
}
