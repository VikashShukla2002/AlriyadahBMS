using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class StudentRegistrationModel
    {
        public string str_First_Name { get; set; }
        public string str_Last_Name { get; set; }
        public string str_Cell_Phone { get; set; }
        public string str_Email { get; set; }
        public long NationalID { get; set; }
        public int intDrivinglicenseType { get; set; }
        public string AbsherApptNbr { get; set; }
    }
}
