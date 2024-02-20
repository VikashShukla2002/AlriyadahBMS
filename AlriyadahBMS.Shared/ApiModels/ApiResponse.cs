using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class ApiResponse <T> : BaseApiResponse
    {
        public T? Data { get; set; }
    }
}
