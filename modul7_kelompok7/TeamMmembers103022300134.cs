using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
// Adefathian
namespace modul7_kelompok7
{
    internal class TeamMembers103022300134
    {


        public class members
        {
            public List<members> member { get; set; }
        }

        public async Task ReadJSON(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var members = await JsonSerializer.DeserializeAsync<members>(openStream);

                if (members != null && members.courses != null)
                {
                    Console.WriteLine("Daftar anggota kelompok:");
                    for (int i = 0; i < members.courses.Count; i++)
                    {
                        var members = members[i];
                        Console.WriteLine($"MK {i + 1} {members.firstName} - {members.lastName} - {members.gender} - {members.age}-{members - nim}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Json eror {ex.Message}");
            }
        }
    }
}