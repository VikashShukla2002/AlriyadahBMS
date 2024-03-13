using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services
{
    public class RegisterService
    {

        private readonly ISwaggerApiService _swagger;

        public RegisterService(ISwaggerApiService swagger)
        {
            _swagger = swagger;
        }

        public async Task<SignUpResponse> RegisterAsync(RegisterModels registerModel)
        {
            var response = await _swagger.PostAsync<RegisterModels, SignUpResponse>(RegisterApiConst.POST_RegisterAccount, "tblStudents", registerModel);
            return response.Data;
        }
    }
}
