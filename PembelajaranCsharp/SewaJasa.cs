using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SewaJasa
{
    public class LoginSewaJasa
    {
        //class yang digunaakan untuk login pada aplikasi sewa jasa
        //class yang digunakan sebagai dashboard aplikasi sewa jasa
        //class yang digunakan untuk menyimpan sewa jasa

        public static void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("        SELAMAT DATANG DI         ");
            Console.WriteLine("         SEWA JASA XYZ           ");
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

                    if (username == "user" && password == "sewajasa")
                    {
                        Console.WriteLine("Login berhasil!");
                        // Panggil metode untuk menampilkan menu utama sewa jasa
                        Console.WriteLine("Menu utama sewa jasa akan ditampilkan di sini...");
                        Thread.Sleep(2000);
                        DashboardSewaJasa.TampilkanMenuUtama();
                    }
                    else
                    {
                        Console.WriteLine("Username atau password salah!");
                        Thread.Sleep(2000);
                        LoginMenu();
                    }
                    break;
                case "2":
                    LoginMenu();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    Thread.Sleep(1000);
                    LoginMenu();
                    break;
            }
        }
    }

    public class DashboardSewaJasa
    {
        public static void TampilkanMenuUtama()
        {
            Console.Clear();
            Console.WriteLine("===== MENU UTAMA SEWA JASA =====");
            Console.WriteLine("\n");
            Console.WriteLine("1. Lihat Daftar Jasa");
            Console.WriteLine("2. Pesan Jasa");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih menu: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();
                    LihatDaftarJasa();
                    break;
                case "2":
                    Console.Clear();
                    PesanJasa();
                    break;

                case "3":
                    LoginSewaJasa.LoginMenu();
                    TampilkanMenuUtama();
                    break;
                    // Tambahkan logika menu utama sewa jasa di sini
            }
        }

        public static void LihatDaftarJasa()
        {
            Console.Clear();
            Console.WriteLine("===== DAFTAR JASA =====");
            Console.WriteLine("\n");
            Console.WriteLine("1. Web desanain - Rp 1.000.000");
            Console.WriteLine("2. Pembuatan Aplikasi Mobile - Rp 2.500.000");
            Console.WriteLine("3. Pembuatan website - 1.750.000");
            Console.WriteLine("tekan 1 tmbali ke Menu Utama");
            string Tekan = Console.ReadLine();

            switch (Tekan)
            {
                case "1":
                    TampilkanMenuUtama();
                    break;
                default:
                    Console.WriteLine("tekan 1 untuk kembali ke Menu Utama");
                    break;
            }

            // Tambahkan logika untuk menampilkan daftar jasa di sini
        }

        public static void PesanJasa()
        {

            var Keranjang = new List<(string nama, int harga)>();
            bool selesai = false;
            while (!selesai)
            {
                Console.Clear();
                Console.WriteLine("===== PESAN JASA =====");
                Console.WriteLine("\n");
                Console.WriteLine("pilih jasa yang ingin dipesan:");
                Console.WriteLine("\n");
                Console.WriteLine("1. Web desanain - Rp 1.000.000");
                Console.WriteLine("2. Pembuatan Aplikasi Mobile - Rp 2.500.000");
                Console.WriteLine("3. Pembuatan website - 1.750.000");
                Console.WriteLine("4. kembali");
                Console.Write("Pilih: ");
                string pilihan = Console.ReadLine();
                switch (pilihan)
                {
                    case "1":
                        Keranjang.Add(("Web desain", 1000000));
                        Console.WriteLine("Ditambahkan Web desain");
                        Thread.Sleep(1000);
                        break;
                    case "2":
                        Keranjang.Add(("Pembuatan Aplikasi Mobile", 2500000));
                        Console.WriteLine("Ditambahkan Pembuatan Aplikasi Mobile");
                        Thread.Sleep(1000);
                        break;
                    case "3":
                        Keranjang.Add(("Pembuatan Website", 1750000));
                        Console.WriteLine("Ditambahkan Pembuatan Website");
                        Thread.Sleep(1000);
                        break;
                    case "4":
                        selesai = true;
                        break;
                    default:
                        Console.WriteLine("pilih sesuai yang tertera!");
                        Thread.Sleep(1000);
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Daftar belanja:");
            foreach (var item in Keranjang)
                Console.WriteLine($"- {item.nama} : Rp {item.harga:N0}");
            int total = Keranjang.Sum(i => i.harga);
            Console.WriteLine($"Total: Rp {total:N0}");
            Thread.Sleep(5000);

            // Kembali ke menu utama setelah checkout
            TampilkanMenuUtama();
        }
    }
}
