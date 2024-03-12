using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    public class SignUpModel
    {
        public class SignUpRequest
        {
            public string str_First_Name { get; set; }
            public string str_Middle_Name { get; set; }
            public string str_Last_Name { get; set; }
            public string str_Cell_Phone { get; set; }
            public string str_Email { get; set; }
            public int Hijri_Day { get; set; }
            public int Hijri_Month { get; set; }
            public int Hijri_Year { get; set; }


        }

        public class SignInResponse : BaseApiResponse
        {

        }
    }
}
