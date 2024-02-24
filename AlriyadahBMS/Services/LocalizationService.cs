using AlriyadahBMS.Shared.ViewModels;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AlriyadahBMS.Services
{
    internal class LocalizationService
    {
        public static List<EwLanguage> EwLanguages { get; } = new();
        public static EwLanguage? SelectedLanguage { get; set; }
        static LocalizationService()
        {
            //var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot","language");
            var path = System.IO.Path.Combine(AppContext.BaseDirectory, "wwwroot", "language");
            var files = System.IO.Directory.GetFiles(path);

            foreach (var file in files)
            {
                var doc = XDocument.Load(file);
                var languageElement = doc.Root!;
                var version = languageElement.Attribute("version")!.Value;
                var id = languageElement.Attribute("id")!.Value;
                var name = languageElement.Attribute("name")!.Value;
                var description = languageElement.Attribute("desc")!.Value;
                var author = languageElement.Attribute("author")!.Value;
                var date = languageElement.Attribute("date")!.Value;
                var phrases = doc.Descendants("phrase").Select(phrase => new Phrase()
                {
                    Id = phrase.Attribute("id")!.Value,
                    Value = phrase.Attribute("value")!.Value
                });
                EwLanguages.Add(new EwLanguage()
                {
                    Id = id,
                    Version = version,
                    Name = name,
                    Description = description,
                    Author = author,
                    Date = date,
                    Phrases = phrases
                });
            }
        }

        public string? Phrase(string id)
        {
            if (SelectedLanguage == null)
            {
                SelectedLanguage = EwLanguages.First();
            }
            var value = SelectedLanguage.Phrases.FirstOrDefault(a => a.Id.Equals(id.Trim(), StringComparison.CurrentCultureIgnoreCase))?.Value;
            return value;
        }
    }
}

