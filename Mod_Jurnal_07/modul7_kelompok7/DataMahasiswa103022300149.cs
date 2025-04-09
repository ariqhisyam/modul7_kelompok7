using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static modul7_kelompok7.DataMahasiswa103022300149;

namespace modul7_kelompok7
{
    internal class DataMahasiswa103022300149
    {
        public class Address103022300149
        {
            [JsonPropertyName("streetAddress")]
            public string street { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course103022300149
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Mahasiswa103022300149
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address103022300149 address { get; set; }
            public Course103022300149[] courses { get; set; }
        }

        public async Task<Mahasiswa103022300149> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa103022300149>(openStream);

                if (mahasiswa != null)
                {
                    Console.WriteLine($"Nama {mahasiswa.firstName} {mahasiswa.lastName} ber jenis kelamin {mahasiswa.gender}ber umur {mahasiswa.age} beralamat {mahasiswa.address.street} {mahasiswa.address.city} {mahasiswa.address.state}");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"Course {i + 1}: {mahasiswa.courses[i].code} - {mahasiswa.courses[i].name}");
                    }
                }

                return mahasiswa;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the JSON file: {ex.Message}");
                return null;
            }
        }
    }

   
}
