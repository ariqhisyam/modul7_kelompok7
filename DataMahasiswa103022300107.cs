using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TUBES1
{
    internal class DataMahasiswa1030223000107
    {
        public async Task<Mahasiswa> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa>(openStream);

                if (mahasiswa != null)
                {
                    Console.WriteLine($"Nama {mahasiswa.firstName} {mahasiswa.lastName} ber jenis kelamin {mahasiswa.gender}ber umur {mahasiswa.age} beralamat{mahasiswa.address.streetAddress} {mahasiswa.address.city} {mahasiswa.address.state}");
                    for (int i = 0; i < mahasiswa.course.Count; i++)
                    {
                        Console.WriteLine($"Course {i + 1}: {mahasiswa.course[i].code} - {mahasiswa.course[i].name}");
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

    public class Mahasiswa1030223000107
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class Nama1030223000107
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}
