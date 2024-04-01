using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossaryData
{
    public GlossEntry GlossEntry { get; set; }

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

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_1302223032.json");

        var glossaryData = JsonSerializer.Deserialize<GlossaryData>(json);

        if (glossaryData != null && glossaryData.GlossEntry != null)
        {
            var glossEntry = glossaryData.GlossEntry;
            Console.WriteLine($"ID: {glossEntry.ID}");
            Console.WriteLine($"SortAs: {glossEntry.SortAs}");
            Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
            Console.WriteLine($"Acronym: {glossEntry.Acronym}");
            Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");
            Console.WriteLine($"GlossDef: {glossEntry.GlossDef.para}");
            Console.WriteLine($"GlossSee: {glossEntry.GlossSee}");

            Console.WriteLine("GlossSeeAlso:");
            foreach (var item in glossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"  - {item}");
            }
        }
        else
        {
            Console.WriteLine("GlossEntry data tidak tersedia.");
        }
    }
}
