using System;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using modul7_kelompok7;

class Program
{
    static async Task Main(string[] args)
    {
        var projectRoot = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
        var jsonFolderPath = Path.Combine(projectRoot, "JSON");

        Console.WriteLine("=== JSON Aditya Nanda ===");
        var mahasiswaFilePath_103022300149 = Path.Combine(jsonFolderPath, "jurnal7_1_103022300149.json");
   

        var dataMahasiswa_103022300149 = new DataMahasiswa103022300149();
        await dataMahasiswa_103022300149.ReadJsonAsync(mahasiswaFilePath_103022300149);


    }
}