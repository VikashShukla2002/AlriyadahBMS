using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class MFAStatusResponse : BaseApiResponse
    {
        public string TransId { get; set; }
        public string Random { get; set; }
    }

    public class MFARequest
    {
        public string NationalIDIqama { get; set; }
    }
}
