using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services.IServices
{
    public interface ISwaggerApiService
    {
        Task<TResponse?> PostWithFormBodyAsync<TRequest, TResponse>(string url, TRequest request) where TResponse : BaseApiResponse;
        Task<UpdateApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string url, string tableName, TRequest request);

        Task<TResponse?> GetAsync<TResponse>(string url);

        Task<UploadResult> UploadFilesAsync(string url, IBrowserFile files);

        //Task<SignUpResponse> RegisterAsync(string url, RegisterModels registerModel);
        Task<TResponse> RegisterAsync<TRequest, TResponse>(string url, TRequest request, byte[] file, string name);

    }
}
