using System;
using System.Text.Json;


public class DataMahasiswa1302223074
{
    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public NamaMahasiswa nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_1302223074.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223074>(json);

        if (dataMahasiswa.nama != null)
        {
            Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan nim {dataMahasiswa.nim} dari fakultas {dataMahasiswa.fakultas}");
        }
        else
        {
            Console.WriteLine("Nama mahasiswa tidak tersedia.");
        }
    }
}

public class KuliahMahasiswa1302223074
{
    public class MataKuliah
    {
        public string kode_matkul { get; set; }
        public string nama_matkul { get; set; }
    }

    public MataKuliah matkul { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_1302223074.json");
        var datakelas = JsonSerializer.Deserialize<KuliahMahasiswa1302223032>(json);

        foreach (var item in datakelas.courses)
        {
            Console.WriteLine($"Code: {item.code}, Name: {item.name}");
        }
    }
}