using modul7_kelompok7;
using System;
using System.Threading.Tasks;
using modul7_kelompok7;

class Program
{
    static async Task Main(string[] args)
    {
        var dataMahasiswa = new DataMahasiswa103022300034();
        var mahasiswaFilePath = @"jurnal7_1_103022300034.json";
        await dataMahasiswa.ReadJsonAsync(mahasiswaFilePath);

        
    }
}
