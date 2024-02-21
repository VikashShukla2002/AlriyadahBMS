using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class HijriModel
    {
        public int ID { get; set; }
        public int Hijri_Year { get; set; }
        public int Hijri_Month { get; set; }
        public string? Hijri_Monthname { get; set; }
        public int Hijri_Day { get; set; }
        public string? Hijri_mon_ar { get; set; }
    }
}
