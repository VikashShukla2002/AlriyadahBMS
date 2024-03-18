using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services
{
    public class NafathService
    {


        private readonly ISwaggerApiService _swagger;

        public NafathService(ISwaggerApiService swagger)
        {
            _swagger = swagger;
        }

        public async Task<MFAStatusResponse> MFARequest(MFARequest request)
        {
            var response = await _swagger.PostWithFormBodyAsync<MFARequest, MFAStatusResponse>("api/nafath/mfarequest", request);
            return response!;
        }

        public async Task<MFAResponse> MFARequestStatus(MFAStatusRequest request)
        {
            var response = await _swagger.PostWithFormBodyAsync<MFAStatusRequest, MFAResponse>("api/nafath/mfarequeststatus", request);
            return response!;
        }
    }
}
