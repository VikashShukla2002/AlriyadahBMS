using AlriyadahBMS.Services.IServices;
using AlriyadahBMS.Shared.ApiModels;
using AlriyadahBMS.Shared.Helper;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services
{
    public class FileUploadService
    {

        private readonly ISwaggerApiService _swagger;

        public FileUploadService(ISwaggerApiService swagger)
        {
            _swagger = swagger;
        }
        public async Task<UploadResult> UploadFiles(IBrowserFile files)
        {        
            UploadResult response = await _swagger.UploadFilesAsync(FileUploadApiConst.POST_FileUpload, files);

            return response;
        }
    }
}
