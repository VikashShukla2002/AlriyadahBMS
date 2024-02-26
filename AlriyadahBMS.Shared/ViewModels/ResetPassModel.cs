using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class ResetPassModel
    {
        //[Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string? Email { get; set; }

    }
}
