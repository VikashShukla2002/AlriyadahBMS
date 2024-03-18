using AlriyadahBMS.Shared.Helper;
using AlriyadahBMS.Shared.ViewModels;
using Microsoft.Extensions.FileProviders;
//using Microsoft.IdentityModel.Tokens;
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

        public static EwLanguage? SelectedLanguage { get; private set; }
        public static bool IsRTL { get; set; }
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


        public static async Task SetLanguageAsync(EwLanguage language)
        {
            SelectedLanguage = language;
            SetRTL(language);
            await SecureStorage.SetAsync(ApplicationConst.Local_Language, language.Id);
        }

        public static void SetRTL(EwLanguage language)
        {
            if (language.Id == Language.EnUS.ToDescriptionString())
            {
                IsRTL = false;
            }
            else
            {
                IsRTL = true;
            }
        }


        public static async Task InitializeAsync()
        {
            var language = await SecureStorage.GetAsync(ApplicationConst.Local_Language);
            if (!string.IsNullOrEmpty(language))
            {
                SelectedLanguage = EwLanguages.First(a => a.Id == language);
            }
            else
            {
                SelectedLanguage ??= EwLanguages.First();
                await SecureStorage.SetAsync(ApplicationConst.Local_Language, SelectedLanguage.Id);
            }
            SetRTL(SelectedLanguage);
        }

        public string? Phrase(string id)
        {

            var value = SelectedLanguage!.Global.FirstOrDefault(a => a.Id.Equals(id.Trim(), StringComparison.CurrentCultureIgnoreCase))?.Value;
            return value;
        }

        public string? Phrase(string tableId, string phraseId)
        {

            var table = SelectedLanguage?.Project.Tables.FirstOrDefault(t => t.Id == tableId);
            if (table != null)
            {
                var phrase = table.Phrases.FirstOrDefault(p => p.Id == phraseId);
                if (phrase != null)
                {
                    return phrase.Value;
                }
            }
            return null;
        }

        public IEnumerable<Phrase>? GetPhrases(string tableId, string phraseId)
        {
            var table = SelectedLanguage?.Project.Tables.FirstOrDefault(t => t.Id == tableId);
            var tablePhrases = table?.Fields.First(p => p.Id == phraseId).Phrases;
            return tablePhrases;
        }

        public string? Phrase(string tableId, string fieldId, string phraseId)
        {
            var table = SelectedLanguage?.Project.Tables.FirstOrDefault(t => t.Id == tableId);
            if (table != null)
            {
                var field = table.Fields.FirstOrDefault(p => p.Id == fieldId);
                if (field != null)
                {
                    //return phrase.Value;
                    var phrase = field.Phrases.FirstOrDefault(a => a.Id == phraseId);
                    if (phrase != null)
                    {
                        return phrase.Value;
                    }

                }
            }
            return null;
        }

    }
}

