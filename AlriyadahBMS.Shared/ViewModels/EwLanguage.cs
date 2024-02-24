using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ViewModels
{
    public class EwLanguage
    {
        public string Version { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Date { get; set; } = null!;

        public IEnumerable<Phrase> Phrases { get; set; } = null!;
    }
    public class Phrase
    {
        required public string Id { get; set; }
        required public string Value { get; set; } 
    }

}
