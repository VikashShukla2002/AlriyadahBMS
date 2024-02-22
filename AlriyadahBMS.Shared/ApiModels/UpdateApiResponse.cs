using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
    {
        public class UpdateApiResponse<TResponse>
        {
            public bool Success { get; set; } = false;
            public string? FailureMessage { get; set; }
            public string? Action { get; set; }
            public string? Version { get; set; }
            public TResponse? Data { get; set; }
        }

}
