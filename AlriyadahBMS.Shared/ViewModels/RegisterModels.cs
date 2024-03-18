using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class RegisterModels

    { 
        // general info

        public string str_First_Name { get; set; }
        public string str_Middle_Name { get; set; }
        public string str_Last_Name { get; set; }
        public string str_Cell_Phone { get; set; }
        public string str_Email { get; set; }
        public int Hijri_Day { get; set; }
        public int Hijri_Month { get; set; }
        public int Hijri_Year { get; set; }

        // Access credentials
        public string str_Password { get; set; }

        [JsonProperty("c_str_Password")]
        public string str_ConfirmPassword { get; set; }  // new
        public string str_NationalID_Iqama { get; set; }



        // Driving status 
        public bool IsDrivingexperience { get; set; }
        public int intDrivinglicenseType { get; set; }


        public string AbsherApptNbr { get; set; }
        public string? Absherphoto { get; set; }


        // emergency contact
        public string str_Emergency_Contact_Name { get; set; }
        public string str_Emergency_Contact_Phone { get; set; }
        public string str_Emergency_Contact_Relation { get; set; }


    }
}
