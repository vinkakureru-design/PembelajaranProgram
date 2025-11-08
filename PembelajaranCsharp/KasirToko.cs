using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembelajaranCsharp
{
    public class KasirToko
    {
        public static void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("        SELAMAT DATANG DI         ");
            Console.WriteLine("          KASIR TOKO XYZ          ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Keluar");
            Console.Write("Pilih menu: ");
            string pilihan = Console.ReadLine();
            switch (pilihan)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Masukkan username: ");
                    string username = Console.ReadLine();
                    Console.Write("Masukkan password: ");
                    string password = Console.ReadLine();
                    if (username == "admin" && password == "password")
                    {
                        Console.WriteLine("Login berhasil!");
                        // Panggil metode untuk menampilkan menu utama kasir
                        Console.WriteLine("Menu utama kasir akan ditampilkan di sini...");
                        Console.WriteLine("Apakah inign melanjutkan ke halaman kasir? (y/n)");
                        string menuLanjut = Console.ReadLine()?.Trim().ToLower();

                        if (menuLanjut == "y")
                        {
                            Console.WriteLine("Halaman kasir ditampilkan...");
                            HalamanKasir();
                        }
                        else if (menuLanjut == "n")
                        {
                            Console.WriteLine("Kembali ke menu login...");
                            LoginMenu();
                        }
                        else
                        {
                            Console.WriteLine("Pilihan tidak valid. Kembali ke menu login...");
                            LoginMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username atau password salah!");
                        LoginMenu();
                    }
                    break;
                case "2":
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi kami.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    LoginMenu();
                    break;
            }

        }

        // Halaman Kasir dipindahkan ke level kelas sehingga bisa dipanggil dari LoginMenu
        private static void HalamanKasir()
        {
            
            Console.WriteLine("===================================");
            Console.WriteLine("          HALAMAN KASIR           ");
            Console.WriteLine("===================================");
            // Tambahkan logika halaman kasir di sini

            //variabel sebagai rak toko
            string barang1 = "Paket sayur RP 26.000";
            string barang2 = "Paket buah RP 33.000";
            string barang3 = "Paket komplit RP 51.000";

            Console.WriteLine("Piih barang yang ingin dibeli:");
            Console.WriteLine($"1. {barang1}");
            Console.WriteLine($"2. {barang2}");
            Console.WriteLine($"3. {barang3}");
            Console.Write("Pilh barang yang dibeli: ");
            string pilihPembelian = Console.ReadLine()?.Trim();

            //logika pembelian
            switch (pilihPembelian)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Anda membeli: {barang1}");
                    HalamanKasir();
                    break;
                case "2":
                    Console.WriteLine($"Anda membeli: {barang2}");
                    HalamanKasir();
                    break;
                case "3":
                    Console.WriteLine($"Anda membeli: {barang3}");
                    HalamanKasir();
                    break;
                default:
                    Console.WriteLine("Pilih sesuai pilihan");
                    HalamanKasir();
                    break;

            }
        }
    }
}
