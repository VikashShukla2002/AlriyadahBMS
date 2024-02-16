using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class BaseApiResponse
    {
        public bool Success { get; set; } = false;
        public object? Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
