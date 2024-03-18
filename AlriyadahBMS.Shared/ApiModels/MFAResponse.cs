using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class MFAResponse : BaseApiResponse
    {
        public string Status { get; set; }
        public int StatusCode { get; set; }
    }
    public class MFAStatusRequest
    {
        public string NationalIDIqama { get; set; }
        public string TransId { get; set; }
        public string Random { get; set; }
    }

}
