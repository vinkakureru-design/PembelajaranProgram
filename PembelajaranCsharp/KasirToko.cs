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
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("          HALAMAN KASIR           ");
            Console.WriteLine("===================================");
            // Tambahkan logika halaman kasir di sini

            //variabel sebagai rak toko
            int harga1 = 26;
            int harga2 = 33;
            int harga3 = 51;

            string barang1 = $"Paket sayur RP {harga1}.000";
            string barang2 = $"Paket buah RP {harga2}.000";
            string barang3 = $"Paket komplit RP {harga3}.000";

            Console.WriteLine("Piih barang yang ingin dibeli:");
            Console.WriteLine($"1. {barang1}");
            Console.WriteLine($"2. {barang2}");
            Console.WriteLine($"3. {barang3}");
            Console.Write("Pilh barang yang dibeli: ");
            string pilihPembelian = Console.ReadLine()?.Trim();

            //logika
            /*
            switch (pilihPembelian)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Anda membeli: {barang1}");
                    Thread.Sleep(3000);
                    HalamanKasir();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"Anda membeli: {barang2}");
                    Thread.Sleep(3000);
                    HalamanKasir();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"Anda membeli: {barang3}");
                    Thread.Sleep(3000);
                    HalamanKasir();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilih sesuai pilihan");
                    Thread.Sleep(2000);
                    HalamanKasir();
                    break;

            }
            */
            var cart = new List<(string name, int price)>();
            bool selesai = false;
            while (!selesai)
            {
                Console.Clear();
                Console.WriteLine("1. Paket sayur - 26000");
                Console.WriteLine("2. Paket buah  - 33000");
                Console.WriteLine("3. Paket komplit - 51000");
                Console.WriteLine("4. Checkout");
                Console.Write("Pilih: ");
                string pilih = Console.ReadLine()?.Trim();

                switch (pilih)
                {
                    case "1":
                        cart.Add(("Paket sayur", 26000));
                        Console.WriteLine("Ditambahkan Paket sayur");
                        break;
                    case "2":
                        cart.Add(("Paket buah", 33000));
                        Console.WriteLine("Ditambahkan Paket buah");
                        break;
                    case "3":
                        cart.Add(("Paket komplit", 51000));
                        Console.WriteLine("Ditambahkan Paket komplit");
                        break;
                    case "4":
                        selesai = true;
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                }
                if (!selesai) { Console.WriteLine("Tekan Enter untuk lanjut..."); Console.ReadLine(); }
            }

            // Checkout
            Console.Clear();
            Console.WriteLine("Daftar belanja:");
            foreach (var item in cart)
                Console.WriteLine($"- {item.name} : Rp {item.price:N0}");
            int total = cart.Sum(i => i.price);
            Console.WriteLine($"Total: Rp {total:N0}");
            Thread.Sleep(5000);
            HalamanKasir();
        }
    }
}
