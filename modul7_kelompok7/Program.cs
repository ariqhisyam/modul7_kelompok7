
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

        

using System.IO;
using System.Threading.Tasks;

namespace modul7_kelompok7
{
     class Program
    {
        static async Task Main(string[] args)
        {
          
            var projectRoot = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            var jsonFolderPath = Path.Combine(projectRoot, "JSON");

         
            var pathMahasiswa = Path.Combine(jsonFolderPath, "jurnal7_1_103022300107.json");
            var mahasiswaReader = new DataMahasiswa1030223000107();
            await mahasiswaReader.ReadJsonAsync(pathMahasiswa);

            Console.WriteLine("\n=============================\n");

         
            var pathMembers = Path.Combine(jsonFolderPath, "jurnal7_2_103022300107.json");
            var memberReader = new TeamMembers103022300107();
            await memberReader.ReadJSON(pathMembers);

            Console.WriteLine("\n=============================\n");

            // Baca data glossary
            var pathGlossary = Path.Combine(jsonFolderPath, "jurnal7_3_103022300107.json");
            var glossaryReader = new GlossaryItem103022300107();
            await glossaryReader.ReadJsonAsync(pathGlossary);

            Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }

    }
}
