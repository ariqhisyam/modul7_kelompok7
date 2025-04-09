using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok7
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class MembersList
    {
        public List<Member> members { get; set; }
    }

    public class TeamMembers103022300107
    {
        public async Task ReadJSON(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var membersList = await JsonSerializer.DeserializeAsync<MembersList>(openStream);

                if (membersList != null && membersList.members != null)
                {
                    Console.WriteLine("Daftar anggota kelompok:");
                    foreach (var member in membersList.members)
                    {
                        Console.WriteLine($"{member.firstName} {member.lastName} - {member.gender} - {member.age} - {member.nim}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON error: {ex.Message}");
            }
        }
    }
}
