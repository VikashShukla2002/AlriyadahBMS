using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class CityModel
    {
        public string City { get; set; } = null!;
        public string Arabic_City_Name { get; set; } = null!;
        public int Province_ID { get; set; } 
        public string Province { get; set; } = null!;
        public string Arabic_Province_Name { get; set; } = null!;
        public string Initials { get; set; } = null!;
        public int? Population { get; set; }
        public int? Population_2004 { get; set; }
        public int? Population_2010 { get; set; }
        public int Population_2022 { get; set; }
    }
}
