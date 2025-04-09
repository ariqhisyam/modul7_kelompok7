using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok7
{
    internal class DataMahasiswa103022300034
    {
        public async Task<Mahasiswa> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa>(openStream);

                if (mahasiswa != null)
                {
                    Console.WriteLine($"Nama {mahasiswa.FirstName} {mahasiswa.LastName} dengan nim {mahasiswa.Nim} " +
                        $"dari fakultas {mahasiswa.Fakultas} dengan gender {mahasiswa.Gender} berumur {mahasiswa.Age}" +
                        $" ber alamat di {mahasiswa.Address}");
                }

                return mahasiswa!;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the JSON file: {ex.Message}");
                return null!;
            }
        }
    }

    public class Mahasiswa
    {
        public long Nim { get; set; }
        public required string Fakultas { get; set; }
        public required string Age { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }

    public class Course
    {
        public required string name { get; set; }
        public int code { get; set; }
    }
}
