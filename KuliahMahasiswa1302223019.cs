using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class KuliahMahasiswa1302223019
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public List<Course> courses { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_1302223019.json");
        var datakelas = JsonSerializer.Deserialize<KuliahMahasiswa1302223019>(json);

        foreach (var item in datakelas.courses)
        {
            Console.WriteLine($"Code: {item.code}, Name: {item.name}");
        }
    }
}