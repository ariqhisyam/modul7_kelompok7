using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok7
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }

    public class DataMahasiswa1030223000107
    {
        public async Task<Mahasiswa> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa>(openStream);

                if (mahasiswa != null)
                {
                    Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}");
                    Console.WriteLine($"Jenis Kelamin: {mahasiswa.gender}");
                    Console.WriteLine($"Umur: {mahasiswa.age}");
                    Console.WriteLine($"Alamat: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");

                    for (int i = 0; i < mahasiswa.courses.Count; i++)
                    {
                        Console.WriteLine($"Mata Kuliah {i + 1}: {mahasiswa.courses[i].code} - {mahasiswa.courses[i].name}");
                    }
                }

                return mahasiswa;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON error: {ex.Message}");
                return null;
            }
        }
    }
}
