using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static KuliahMahasiswa1302223019;
internal class KuliahMahasiswa1302223019
{
    public class KuliahMahasiswa
    {
        [JsonPropertyName("courses")]
        public Course[] Courses { get; set; }
    }
    public class Course
    {
        [JsonPropertyName("code")]
        public String code { get; set; }
        [JsonPropertyName("name")]
        public String name { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "tp7_2_1302223019.json";

        string jsonText = File.ReadAllText(filePath);

        KuliahMahasiswa KuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa>(jsonText);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        for (int i = 0; i < KuliahMahasiswa.Courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {KuliahMahasiswa.Courses[i].code} - {KuliahMahasiswa.Courses[i].name}");
        }
    }
}