using System;
using System.Collections.Generic;

namespace MahasiswaBaru
{
    class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public string Jurusan { get; set; }

        public Mahasiswa(string nim, string nama, string ProgramStudi)
        {
            NIM = nim;
            Nama = nama;
            Jurusan = ProgramStudi;
        }
    }

    class Program
    {
        static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            bool programBerjalan = true;

            while (programBerjalan)
            {
                TampilkanMenu();
                Console.Write("Pilih menu (1-5): ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        TambahData();
                        break;
                    case "2":
                        TampilkanData();
                        break;
                    case "3":
                        UbahData();
                        break;
                    case "4":
                        HapusData();
                        break;
                    case "5":
                        programBerjalan = false;
                        Console.WriteLine("Program selesai.");
                        break;
                    default:
                        Console.WriteLine("Pilihan salah!");
                        break;
                }

                Console.WriteLine("\nTekan Enter untuk lanjut...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void TampilkanMenu()
        {
            Console.WriteLine("=== PROGRAM MAHASISWA ===");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Lihat Data");
            Console.WriteLine("3. Ubah Data");
            Console.WriteLine("4. Hapus Data");
            Console.WriteLine("5. Keluar");
        }

        static void TambahData()
        {
            Console.WriteLine("\n--- TAMBAH DATA ---");
            Console.Write("NIM: ");
            string nim = Console.ReadLine();

            foreach (Mahasiswa m in dataMahasiswa)
            {
                if (m.NIM == nim)
                {
                    Console.WriteLine("NIM sudah ada!");
                    return;
                }
            }

            Console.Write("Nama: ");
            string nama = Console.ReadLine();
            Console.Write("Jurusan: ");
            string jurusan = Console.ReadLine();

            dataMahasiswa.Add(new Mahasiswa(nim, nama, jurusan));
            Console.WriteLine("Data berhasil ditambah!");
        }

        static void TampilkanData()
        {
            Console.WriteLine("\n--- DATA MAHASISWA ---");

            if (dataMahasiswa.Count == 0)
            {
                Console.WriteLine("Belum ada data");
                return;
            }

            foreach (Mahasiswa m in dataMahasiswa)
            {
                Console.WriteLine($"NIM: {m.NIM}, Nama: {m.Nama}, Jurusan: {m.Jurusan}");
            }
        }

        static void UbahData()
        {
            Console.WriteLine("\n--- UBAH DATA ---");
            Console.Write("Masukkan NIM: ");
            string nimCari = Console.ReadLine();

            Mahasiswa ditemukan = null;

            foreach (Mahasiswa m in dataMahasiswa)
            {
                if (m.NIM == nimCari)
                {
                    ditemukan = m;
                    break;
                }
            }

            if (ditemukan == null)
            {
                Console.WriteLine("NIM tidak ditemukan!");
                return;
            }

            Console.Write($"Nama lama: {ditemukan.Nama}. Nama baru: ");
            ditemukan.Nama = Console.ReadLine();
            Console.Write($"Jurusan lama: {ditemukan.Jurusan}. Jurusan baru: ");
            ditemukan.Jurusan = Console.ReadLine();

            Console.WriteLine("Data berhasil diubah!");
        }

        static void HapusData()
        {
            Console.WriteLine("\n--- HAPUS DATA ---");
            Console.Write("Masukkan NIM: ");
            string nimCari = Console.ReadLine();

            Mahasiswa ditemukan = null;

            foreach (Mahasiswa m in dataMahasiswa)
            {
                if (m.NIM == nimCari)
                {
                    ditemukan = m;
                    break;
                }
            }

            if (ditemukan == null)
            {
                Console.WriteLine("NIM tidak ditemukan!");
                return;
            }

            dataMahasiswa.Remove(ditemukan);
            Console.WriteLine("Data berhasil dihapus!");
        }
    }
}
