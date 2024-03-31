using System;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa1302223047
{
    public class MataKuliah
    {
        public string kode_matkul { get; set; }
        public string nama_matkul { get; set; }
    }

    public MataKuliah matkul { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_1302223047.json");
        var datakelas = JsonSerializer.Deserialize<KuliahMahasiswa1302223032>(json);

        foreach (var item in datakelas.courses)
        {
            Console.WriteLine($"Code: {item.code}, Name: {item.name}");
        }
    }

    static void Main(string[] args)
    {
        KuliahMahasiswa1302223047 dataMahasiswa = new KuliahMahasiswa1302223047();

        // Read and display the JSON data
        dataMahasiswa.ReadJSON();
    }

}


    
