using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok7
{
    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossaryItem
    {
        public Glossary glossary { get; set; }
    }

    internal class GlossaryItem103022300107
    {
        public async Task<GlossaryItem> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var item = await JsonSerializer.DeserializeAsync<GlossaryItem>(openStream);

                if (item != null)
                {
                    var g = item.glossary;
                    Console.WriteLine($"Glossary Title: {g.title}");
                    Console.WriteLine($"GlossDiv Title: {g.GlossDiv.title}");
                    Console.WriteLine($"GlossEntry ID: {g.GlossDiv.GlossList.GlossEntry.ID}");
                    Console.WriteLine($"GlossTerm: {g.GlossDiv.GlossList.GlossEntry.GlossTerm}");
                    Console.WriteLine($"Definition: {g.GlossDiv.GlossList.GlossEntry.GlossDef.para}");
                }

                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON error: {ex.Message}");
                return null;
            }
        }
    }
}
