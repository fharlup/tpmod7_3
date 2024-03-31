public class main
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302223019 mahasiswa1302223019 = new DataMahasiswa1302223019();
        mahasiswa1302223019.ReadJSON();

        KuliahMahasiswa1302223019 kuliah1302223019 = new KuliahMahasiswa1302223019();
        kuliah1302223019.ReadJSON();
    }
}