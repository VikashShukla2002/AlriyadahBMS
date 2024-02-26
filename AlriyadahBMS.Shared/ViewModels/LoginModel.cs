﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace AlriyadahBMS.Shared.ViewModels
{
    public class LoginModel
    {
        //[Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
