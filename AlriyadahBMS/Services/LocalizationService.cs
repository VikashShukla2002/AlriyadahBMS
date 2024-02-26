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
        public static bool IsRTL { get; set; } = false;
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
                //var phrases = doc.Descendants("phrase").Select(phrase => new Phrase()
                //{
                //    Id = phrase.Attribute("id")!.Value,
                //    Value = phrase.Attribute("value")!.Value
                //});
                //var globalChildElements = languageElement.Elements("global");
                //var descendantElements = globalChildElements.ToList();



                var globalPhrases = doc.Descendants("global").Elements("phrase").Select(phrase => new Phrase()
                {
                    Id = phrase.Attribute("id")!.Value,
                    Value = phrase.Attribute("value")!.Value
                });

                var project = new Project();

                project.Phrases = doc.Descendants("project").Elements("phrase").Select(phrase => new Phrase()
                {
                    Id = phrase.Attribute("id")!.Value,
                    Value = phrase.Attribute("value")!.Value
                });


                project.Menus = doc.Descendants("project").Elements("menu").Select(menu => new Menu
                {
                    Id = menu.Attribute("id")?.Value ?? "",
                    Phrase = new Phrase
                    {
                        Id = menu.Element("phrase")?.Attribute("id")?.Value ?? "",
                        Value = menu.Element("phrase")?.Attribute("value")?.Value ?? ""
                    }
                });


                project.Tables = doc.Descendants("project").Elements("table").Select(table => new Table
                {
                    Id = table.Attribute("id")?.Value ?? "",
                    Phrases = table.Elements("phrase").Select(phrase => new Phrase()
                    {
                        Id = phrase.Attribute("id")!.Value,
                        Value = phrase.Attribute("value")!.Value
                    }),

                    Fields = table.Elements("field").Select(field => new Field
                    {
                        Id = field.Attribute("id")?.Value ?? "",
                        Phrases = field.Elements("phrase").Select(phrase => new Phrase
                        {
                            Id = phrase.Attribute("id")?.Value ?? "",
                            Value = phrase.Attribute("value")?.Value ?? ""
                        }).ToList()
                    }).ToList()
                });



                EwLanguages.Add(new EwLanguage()
                {
                    Id = id,
                    Version = version,
                    Name = name,
                    Description = description,
                    Author = author,
                    Date = date,
                    Global = globalPhrases,
                    Project = project,
                });




            }
        }

        public string? Phrase(string id)
        {
            if (SelectedLanguage == null)
            {
                SelectedLanguage = EwLanguages.First();
            }
            var value = SelectedLanguage.Global.FirstOrDefault(a => a.Id.Equals(id.Trim(), StringComparison.CurrentCultureIgnoreCase))?.Value;
            return value;
        }


        public string? Phrase(string tableId, string phraseId)
        {
            var table = SelectedLanguage.Project.Tables.FirstOrDefault(t => t.Id == tableId);
            if (table != null)
            {


                var fieldPhrase = table.Phrases.FirstOrDefault(p => p.Id == phraseId);
                if (fieldPhrase != null)
                {
                    return fieldPhrase.Value;
                }

            }
            return null;
        }

    }
}

