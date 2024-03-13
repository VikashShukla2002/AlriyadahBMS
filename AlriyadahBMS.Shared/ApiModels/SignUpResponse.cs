using AlriyadahBMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class SignUpResponse
    {
        public bool Success { get; set; }
        public RegisterModels? TblStudents { get; set; }
        public string Action { get; set; }
        public string Version { get; set; }

    }
}
