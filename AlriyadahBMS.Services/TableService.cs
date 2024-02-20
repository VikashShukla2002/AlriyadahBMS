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
    public class TableService
    {
        private readonly ISwaggerApiService _swagger;

        public TableService(ISwaggerApiService swagger)
        {
            _swagger = swagger;
        }

        public async Task<T?> GetRecords<T>(string table)
        {
            var records = await _swagger!.GetAsync<T>(TableApiConst.GET_TblList.Replace("{table}", table));
            return records;
        }

    }
}
