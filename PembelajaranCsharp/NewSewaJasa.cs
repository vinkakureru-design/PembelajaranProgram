using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SewaJasa
{
    // ===========================
    // Kelas untuk proses login
    // ===========================
    public static class LoginSewaJasa
    {
        private const string UsernameBenar = "user";
        private const string PasswordBenar = "sewajasa";

        public static void TampilkanLoginMenu()
        {
            while (true) // looping tanpa batas hingga user memilih keluar
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("        SELAMAT DATANG DI          ");
                Console.WriteLine("         SEWA JASA XYZ             ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Keluar");
                Console.Write("\nPilih menu: ");
                string pilihan = Console.ReadLine()?.Trim();

                switch (pilihan)
                {
                    case "1":
                        if (ProsesLogin())
                        {
                            DashboardSewaJasa.TampilkanMenuUtama();
                        }
                        break;
                    case "2":
                        KeluarAplikasi();
                        return;
                    default:
                        PesanKesalahan("Pilihan tidak valid!");
                        break;
                }
            }
        }

        private static bool ProsesLogin()
        {
            Console.Clear();
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine();
            Console.Write("Masukkan password: ");
            string password = Console.ReadLine();

            if (username == UsernameBenar && password == PasswordBenar)
            {
                PesanSukses("Login berhasil!");
                return true;
            }

            PesanKesalahan("Username atau password salah!");
            return false;
        }

        private static void KeluarAplikasi()
        {
            Console.WriteLine("\nTerima kasih telah menggunakan Sewa Jasa XYZ!");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }

        private static void PesanKesalahan(string pesan)
        {
            Console.WriteLine($"\n[!] {pesan}");
            Thread.Sleep(1500);
        }

        private static void PesanSukses(string pesan)
        {
            Console.WriteLine($"\n[✓] {pesan}");
            Thread.Sleep(1500);
        }
    }

    // ===========================
    // Kelas untuk menu utama
    // ===========================
    public static class DashboardSewaJasa
    {
        private static readonly Dictionary<int, (string Nama, int Harga)> daftarJasa = new()
        {
            { 1, ("Web Desain", 1_000_000) },
            { 2, ("Pembuatan Aplikasi Mobile", 2_500_000) },
            { 3, ("Pembuatan Website", 1_750_000) }
        };

        public static void TampilkanMenuUtama()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENU UTAMA SEWA JASA =====\n");
                Console.WriteLine("1. Lihat Daftar Jasa");
                Console.WriteLine("2. Pesan Jasa");
                Console.WriteLine("3. Logout");
                Console.WriteLine("4. Keluar");
                Console.Write("\nPilih menu: ");
                string pilihan = Console.ReadLine()?.Trim();

                switch (pilihan)
                {
                    case "1":
                        LihatDaftarJasa();
                        break;
                    case "2":
                        PesanJasa();
                        break;
                    case "3":
                        LoginSewaJasa.TampilkanLoginMenu();
                        return;
                    case "4":
                        Console.WriteLine("Keluar dari aplikasi...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }

        private static void LihatDaftarJasa()
        {
            Console.Clear();
            Console.WriteLine("===== DAFTAR JASA =====\n");
            foreach (var jasa in daftarJasa)
            {
                Console.WriteLine($"{jasa.Key}. {jasa.Value.Nama} - Rp {jasa.Value.Harga:N0}");
            }

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }

        private static void PesanJasa()
        {
            var keranjang = new List<(string Nama, int Harga)>();
            bool selesai = false;

            while (!selesai)
            {
                Console.Clear();
                Console.WriteLine("===== PESAN JASA =====\n");
                foreach (var jasa in daftarJasa)
                {
                    Console.WriteLine($"{jasa.Key}. {jasa.Value.Nama} - Rp {jasa.Value.Harga:N0}");
                }
                Console.WriteLine("4. Selesai Memesan");
                Console.Write("\nPilih jasa: ");
                string pilihan = Console.ReadLine()?.Trim();

                if (int.TryParse(pilihan, out int pilihInt)) // 1.0 menyimpan variabel dari pilihan ke pilihanInt
                {
                    if (daftarJasa.ContainsKey(pilihInt)) // Countainskey mengambil isi dari dictionary dan memilih lewat input variabel plihanInt
                    {
                        var item = daftarJasa[pilihInt]; // 1.1 terhunung dengan 1 yaitu mengambil dari variabel yang disimpan dari input user
                        keranjang.Add(item);
                        Console.WriteLine($"✓ {item.Nama} ditambahkan ke keranjang!");
                        Thread.Sleep(1000);
                    }
                    else if (pilihInt == 4)
                    {
                        selesai = true;
                    }
                    else
                    {
                        Console.WriteLine("Nomor jasa tidak ditemukan!");
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Masukkan angka yang valid!");
                    Thread.Sleep(1000);
                }
            }

            TampilkanRingkasan(keranjang);
        }

        private static void TampilkanRingkasan(List<(string Nama, int Harga)> keranjang)
        {
            Console.Clear();
            if (keranjang.Count == 0)
            {
                Console.WriteLine("Tidak ada jasa yang dipesan.");
            }
            else
            {
                Console.WriteLine("===== RINGKASAN PESANAN =====\n");
                foreach (var item in keranjang)
                    Console.WriteLine($"- {item.Nama} : Rp {item.Harga:N0}");

                int total = keranjang.Sum(i => i.Harga);
                Console.WriteLine($"\nTotal Pembayaran: Rp {total:N0}");
            }

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
    }
}
