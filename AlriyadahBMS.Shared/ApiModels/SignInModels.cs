using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class SignInRequest
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = null!;
        public string? SecurityCode { get; set; }

        public int Permission { get; set; }

        public int Expire { get; set; }
    }

    public class SignInResponse : BaseApiResponse
    {
        public string JWT { get; set; } = null!;
    }
}

