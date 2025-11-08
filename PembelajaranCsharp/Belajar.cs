using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembelajaranCsharp
{
    public class TipeData
    {
        public static void TipeDataDasar()
        {
            // Tipe data dasar di C#
            int angka = 2147483647; // Tipe data integer (32-bit) dari -2.147.483.648 sampai 2.147.483.647
            float desimal = 3.402823e38f; // Tipe data float (32-bit) untuk angka desimal dari -3.402823e38 sampai 3.402823e38
            char karakter = 'A'; // Tipe data char untuk menyimpan satu karakter Unicode
            bool benarSalah = true; // Tipe data boolean untuk menyimpan nilai true atau false
            string teks = "Halo, Dunia!"; // Tipe data string untuk menyimpan teks

            // Tipe data lainnya
            double desimalPresisiTinggi = 1.79769313486232e30; // Tipe data double (64-bit) untuk angka desimal dengan presisi tinggi
            long angkaBesar = 9223372036854775807L; // Tipe data long (64-bit) dari -9.223.372.036.854.775.808 sampai 9.223.372.036.854.775.807
            byte angkaKecil = 255; // Tipe data byte (8-bit) dari 0 sampai 255
            decimal desimalKeuangan = 79228162514264337593543950335m; // Tipe data decimal (128-bit) untuk angka desimal dengan presisi sangat tinggi, sering digunakan dalam aplikasi keuangan
            sbyte angkaKecilBertanda = 127; // Tipe data sbyte (8-bit) dari -128 sampai 127
            ushort angkaPositifKecil = 65535; // Tipe data ushort (16-bit) dari 0 sampai 65.535
            uint angkaPositifSedang = 4294967295; // Tipe data uint (32-bit) dari 0 sampai 4.294.967.295
            ulong angkaPositifBesar = 18446744073709551615UL; // Tipe data ulong (64-bit) dari 0 sampai 18.446.744.073.709.551.615
            DateTime tanggal = DateTime.Now; // Tipe data DateTime untuk menyimpan tanggal dan waktu
            DateOnly tanggalSaja = DateOnly.FromDateTime(DateTime.Now); // Tipe data DateOnly untuk menyimpan hanya tanggal (C# 10.0 ke atas)
            TimeOnly waktuSaja = TimeOnly.FromDateTime(DateTime.Now); // Tipe data TimeOnly untuk menyimpan hanya waktu (C# 10.0 ke atas

            Console.WriteLine($"Integer: {angka}");
            Console.WriteLine($"Float: {desimal}");
            Console.WriteLine($"Char: {karakter}");
            Console.WriteLine($"Boolean: {benarSalah}");
            Console.WriteLine($"String: {teks}");
            Console.WriteLine($"Double: {desimalPresisiTinggi}");
            Console.WriteLine($"Long: {angkaBesar}");
            Console.WriteLine($"Byte: {angkaKecil}");
            Console.WriteLine($"Decimal: {desimalKeuangan}");
            Console.WriteLine($"SByte: {angkaKecilBertanda}");
            Console.WriteLine($"UShort: {angkaPositifKecil}");
            Console.WriteLine($"UInt: {angkaPositifSedang}");
            Console.WriteLine($"ULong: {angkaPositifBesar}");
            Console.WriteLine($"DateTime: {tanggal}");
            Console.WriteLine($"DateOnly: {tanggalSaja}");
            Console.WriteLine($"TimeOnly: {waktuSaja}");
        }
    }

    public class Input
    {
        public static void InputUser()
        {
            //jenis print dari user
            Console.Write("Masukkan nama Anda: "); // Prompt untuk user yang tidak menampilkan baris baru
            Console.WriteLine($"Halo"); // Menampilkan output dengan baris baru

            //jenis input dari user
            Console.ReadLine(); // Membaca input dari user sebagai string
            Console.Read(); // Membaca input dari user sebagai karakter (ASCII) atau integer
            Console.ReadKey(); // Membaca satu karakter input dari user tanpa menampilkan di layar

            //jenis kode yang sering digabung dengan input
            string nama = Console.ReadLine(); // Membaca input dari user dan menyimpannya dalam variabel nama
            Console.WriteLine($"Halo, {nama}!"); // Menampilkan output dengan nama yang dimasukkan oleh user

            int umur = int.Parse(Console.ReadLine()); // Membaca input dari user, mengonversi ke integer, dan menyimpannya dalam variabel umur
            //jenis lainnya bisa menggunakan Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Umur Anda adalah {umur} tahun."); // Menampilkan output dengan umur yang dimasukkan oleh user

            int tahunLahir = DateTime.Now.Year - umur; // Menghitung tahun lahir berdasarkan umur
            Console.WriteLine($"Anda lahir pada tahun {tahunLahir}."); // Menampilkan output dengan tahun lahir

            //input desimal
            float tinggiBadan = float.Parse(Console.ReadLine()); // Membaca input dari user, mengonversi ke float, dan menyimpannya dalam variabel tinggiBadan
            // jenis lainnya bisa menggunakan Convert.ToSingle(Console.ReadLine()); atau double dengan double.Parse(Console.ReadLine());
            Console.WriteLine($"Tinggi badan Anda adalah {tinggiBadan} meter."); // Menampilkan output dengan tinggi badan yang dimasukkan oleh user
        }
    }

    public class Operator
    {
        public static void OperatorDasar()
        {
            // operator aritmatika
            // operator terbagi menjadi 3 jenis yaitu unary, binary, dan ternary
            // unary adalah operator yang hanya membutuhkan satu operand
            // binary adalah operator yang membutuhkan dua operand
            // ternary adalah operator yang membutuhkan tiga operand
            // apa maksud dari ketiga itu? berikut penjelasannya:
            // unary contoh: negasi (-), increment (++) , decrement (--)
            // binary contoh: penjumlahan (+), pengurangan (-), perkalian (*), pembagian (/), modulus (%)
            // ternary contoh: kondisi ? nilai_jika_benar : nilai_jika_salah

            // lalu jenis- jenis operator aritmatika di C# adalah sebagai berikut:
            // operator aritamtika
            // operator assignment
            // operator perbandingan
            // operator logika
            // operator bitwise
            // operator kondisional

            // === Operator Aritmatika ===
            // operator yang digunakan untuk melakukan operasi matematika dasar
            // contoh: penjumlahan menggunakan (+), pengurangan menggunakan (-), perkalian menggunakan (*), pembagian menggunakan (/), modulus menggunakan (%), increment menggunakan (++) , decrement menggunakan (--)
            // contoh penggunaan:


            //public variabel khusus di class aritmatika
            int mangga, apel, hasil = 0;

            //penjumlahan
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            hasil = mangga + apel;
            Console.WriteLine($"Total buah: {hasil}");

            //pengurangan
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            hasil = mangga - apel;
            Console.WriteLine($"Selisih buah: {hasil}");

            //perkalian
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            hasil = mangga * apel;
            Console.WriteLine($"Hasil kali buah: {hasil}");

            //pembagian
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            hasil = mangga / apel;
            Console.WriteLine($"Hasil bagi buah: {hasil}");

            //modulus
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            hasil = mangga % apel;
            Console.WriteLine($"Sisa buah: {hasil}");

            //increment
            Console.Write("Masukkan jumlah mangga: ");
            mangga = int.Parse(Console.ReadLine());
            mangga++;
            Console.WriteLine($"Jumlah mangga setelah diincrement: {mangga}");
            //decrement
            Console.Write("Masukkan jumlah apel: ");
            apel = int.Parse(Console.ReadLine());
            apel--;
            Console.WriteLine($"Jumlah apel setelah didecrement: {apel}");

            // === Operator Assignment (Penugasan) ===
            //  opearator yang digunakan untuk memberikan nilai pada variabel
            // contoh: penugasan menggunakan (=), penambahan dan penugasan menggunakan (+=), pengurangan dan penugasan menggunakan (-=), perkalian dan penugasan menggunakan (*=), pembagian dan penugasan menggunakan (/=), modulus dan penugasan menggunakan (%=), increment dan penugasan menggunakan (++) , decrement dan penugasan menggunakan (--), pengisian dan shift menggunakan (<<=, >>=), pengisian dan bitwise menggunakan (&=, |=, ^=)
            // contoh penggunaan:

            int nilai = 10; // penugasan
            nilai += 5; // penambahan dan penugasan
            Console.WriteLine($"Nilai setelah penambahan dan penugasan: {nilai}");

            nilai -= 3; // pengurangan dan penugasan
            Console.WriteLine($"Nilai setelah pengurangan dan penugasan: {nilai}");

            nilai *= 2; // perkalian dan penugasan
            Console.WriteLine($"Nilai setelah perkalian dan penugasan: {nilai}");

            nilai /= 4; // pembagian dan penugasan
            Console.WriteLine($"Nilai setelah pembagian dan penugasan: {nilai}");

            nilai %= 3; // modulus dan penugasan
            Console.WriteLine($"Nilai setelah modulus dan penugasan: {nilai}");

            nilai++; // increment
            Console.WriteLine($"Nilai setelah increment: {nilai}");

            nilai--; // decrement
            Console.WriteLine($"Nilai setelah decrement: {nilai}");

            nilai <<= 1; // pengisian dan shift kiri // fungsi ini menggeser bit ke kiri sebanyak 1 posisi // hasilnya sama dengan mengalikan dengan 2 // begini hasilnya:  nilai = nilai * 2;
            Console.WriteLine($"Nilai setelah pengisian dan shift kiri: {nilai}");

            nilai >>= 1; // pengisian dan shift kanan // fungsi ini menggeser bit ke kanan sebanyak 1 posisi // hasilnya sama dengan membagi dengan 2 // begini hasilnya: nilai = nilai / 2;
            Console.WriteLine($"Nilai setelah pengisian dan shift kanan: {nilai}");

            nilai &= 2; // pengisian dan bitwise AND // fungsi ini melakukan operasi AND pada setiap bit dari nilai dan 2 // begini hasilnya: nilai = nilai & 2;
            Console.WriteLine($"Nilai setelah pengisian dan bitwise AND: {nilai}");

            nilai |= 4; // pengisian dan bitwise OR // fungsi ini melakukan operasi OR pada setiap bit dari nilai dan 4 // begini hasilnya: nilai = nilai | 4;
            Console.WriteLine($"Nilai setelah pengisian dan bitwise OR: {nilai}");

            nilai ^= 3; // pengisian dan bitwise XOR // fungsi ini melakukan operasi XOR pada setiap bit dari nilai dan 3 // begini hasilnya: nilai = nilai ^ 3;
            Console.WriteLine($"Nilai setelah pengisian dan bitwise XOR: {nilai}");


            // === Operator Perbandingan ===
            // operator yang digunakan untuk membandingkan dua nilai dengan hasil boolean (true/false)
            // contoh: sama dengan menggunakan (==), tidak sama dengan menggunakan (!=), lebih besar dari menggunakan (>), lebih kecil dari menggunakan (<), lebih besar atau sama dengan menggunakan (>=), lebih kecil atau sama dengan menggunakan (<=)
            // contoh penggunaan:

            int a = 10;
            int b = 20;

            Console.WriteLine($"Apakah a sama dengan b? {a == b}"); // sama dengan
            Console.WriteLine($"Apakah a tidak sama dengan b? {a != b}"); // tidak sama dengan
            Console.WriteLine($"Apakah a lebih besar dari b? {a > b}"); // lebih besar dari
            Console.WriteLine($"Apakah a lebih kecil dari b? {a < b}"); // lebih kecil dari
            Console.WriteLine($"Apakah a lebih besar atau sama dengan b? {a >= b}"); // lebih besar atau sama dengan
            Console.WriteLine($"Apakah a lebih kecil atau sama dengan b? {a <= b}"); // lebih kecil atau sama dengan

            // === Operator Logika ===
            // operator yang digunakan untuk menggabungkan atau memanipulasi nilai boolean
            // contoh: AND menggunakan (&&), OR menggunakan (||), NOT menggunakan (!)
            // contoh penggunaan:
            bool kondisi1 = true;
            bool kondisi2 = false;
            Console.WriteLine($"Hasil AND: {kondisi1 && kondisi2}"); // AND
            Console.WriteLine($"Hasil OR: {kondisi1 || kondisi2}"); // OR
            Console.WriteLine($"Hasil NOT kondisi1: {!kondisi1}"); // NOT
            //hasil AND adalah false karena salah satu kondisi bernilai false
            //hasil OR adalah true karena salah satu kondisi bernilai true
            //hasil NOT kondisi1 adalah false karena kondisi1 bernilai true

            //hasil AND true jika keduanya kondisi bernilai true
            //hasil OR false jika keduanya kondisi bernilai false, tapi true jika salah satu kondisi bernilai true
            //hasil NOT membalik nilai kondisi, true menjadi false, false menjadi true


            // === Operator Bitwise ===
            // operator yang digunakan untuk melakukan operasi pada level bit dari bilangan bulat
            // contoh: AND menggunakan (&), OR menggunakan (|), XOR menggunakan (^), NOT menggunakan (~), shift kiri menggunakan (<<), shift kanan menggunakan (>>)
            // contoh penggunaan:
            int x = 5;  // dalam biner: 0101
            int y = 3;  // dalam biner: 0011
            Console.WriteLine($"Hasil Bitwise AND: {x & y}"); // Bitwise AND
            Console.WriteLine($"Hasil Bitwise OR: {x | y}"); // Bitwise OR
            Console.WriteLine($"Hasil Bitwise XOR: {x ^ y}"); // Bitwise XOR
            Console.WriteLine($"Hasil Bitwise NOT x: {~x}"); // Bitwise NOT
            Console.WriteLine($"Hasil Shift Kiri x: {x << 1}"); // Shift Kiri
            Console.WriteLine($"Hasil Shift Kanan x: {x >> 1}"); // Shift Kanan


            // === Operator Kondisional (Ternary) ===
            // operator yang digunakan untuk memilih salah satu dari dua nilai berdasarkan kondisi
            // contoh: kondisi ? nilai_jika_benar : nilai_jika_salah
            // contoh penggunaan:
            int nilaiUjian = 75;
            string hasilUjian = (nilaiUjian >= 60) ? "Lulus" : "Tidak Lulus";
            Console.WriteLine($"Hasil ujian: {hasilUjian}");
            // ini berguna jika kita ingin menetapkan nilai berdasarkan kondisi tanpa menggunakan struktur if-else yang lebih panjang. terutama untuk penugasan sederhana atau pengembalian nilai dari fungsi. dan itu membuat kode lebih ringkas dan mudah dibaca. dengan syarat bahwa kondisi dan nilai yang terlibat tidak terlalu kompleks. yang hanay butuh satu baris saja dan hanya 2 pilihan nilai.


            // catatan: penggunaan operator-operator ini harus sesuai dengan konteks dan tipe data yang digunakan untuk menghindari kesalahan kompilasi atau runtime.
        }
    }

    public class Percabangan
    {
        public static void PercabanganDasar()
        {
            // Percabangan dasar di C#
            // Percabangan terbagi menjadi beberapa jenis yaitu:
            // 1. if statement
            // 2. if-else statement
            // 3. else-if ladder
            // 4. switch statement

            // 1. if statement
            Console.Write("Tebak angka (1-10): ");
            int tebakan = int.Parse(Console.ReadLine());
            if (tebakan == 7)
            {
                Console.WriteLine("Tebakan Anda benar!");
            }
            // percabangan if di atas akan mengeksekusi blok kode di dalamnya hanya jika kondisi (tebakan == 7) bernilai true.
            // digunakna jika hanya ada satu kondisi yang perlu diperiksa.

            // 2. if-else statement
            Console.Write("Tebak angka (1-10): ");
            tebakan = int.Parse(Console.ReadLine());
            if (tebakan == 7)
            {
                Console.WriteLine("Tebakan Anda benar!");
            }
            else
            {
                Console.WriteLine("Tebakan Anda salah!");
            }
            // percabangan if-else di atas akan mengeksekusi blok kode di dalam if jika kondisi (tebakan == 7) bernilai true, dan mengeksekusi blok kode di dalam else jika kondisi bernilai false.
            // digunakan jika ada dua kondisi yang saling berlawanan atau eksklusif.

            // 3. else-if ladder
            Console.Write("Masukkan nilai (0-100): ");
            int nilai = int.Parse(Console.ReadLine());
            if (nilai >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (nilai >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (nilai >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
            // percabangan else-if di atas akan memeriksa beberapa kondisi secara berurutan dan mengeksekusi blok kode dari kondisi pertama yang bernilai true.
            // digunakan jika ada beberapa kondisi yang perlu diperiksa secara berurutan.

            // 4. switch statement
            Console.Write("Masukkan hari (1-7): ");
            int hari = int.Parse(Console.ReadLine());
            switch (hari)
            {
                case 1:
                    Console.WriteLine("Hari ini adalah Senin.");
                    break;
                case 2:
                    Console.WriteLine("Hari ini adalah Selasa.");
                    break;
                case 3:
                    Console.WriteLine("Hari ini adalah Rabu.");
                    break;
                case 4:
                    Console.WriteLine("Hari ini adalah Kamis.");
                    break;
                case 5:
                    Console.WriteLine("Hari ini adalah Jumat.");
                    break;
                case 6:
                    Console.WriteLine("Hari ini adalah Sabtu.");
                    break;
                case 7:
                    Console.WriteLine("Hari ini adalah Minggu.");
                    break;
                default:
                    Console.WriteLine("Input tidak valid.");
                    break;
            }
            // percabangan switch di atas akan mengeksekusi blok kode yang sesuai dengan nilai dari variabel hari.
            // digunakan jika ada banyak kondisi yang perlu diperiksa berdasarkan nilai dari satu variabel.

            // kapan harus menggunakan percabangan if-else atau switch dalam pengembangan web, game, dekstop,mobile dan lainnya?
            // - gunakan if-else ketika kondisi yang diperiksa bersifat kompleks atau melibatkan rentang nilai, seperti dalam penilaian atau validasi input.
            // - gunakan switch ketika ada banyak kondisi yang perlu diperiksa berdasarkan nilai dari satu variabel, terutama jika nilai tersebut bersifat diskrit dan terbatas, seperti dalam pemilihan menu atau penanganan perintah.

            // contoh penggunaan percabangan dalam konteks pengembangan aplikasi:
            // pengembangan web: menentukan tampilan halaman berdasarkan peran pengguna (admin, user, guest).
            // pengembangan game: menentukan aksi karakter berdasarkan input pemain (lompat, lari, serang).
            // pengembangan desktop: menampilkan pesan kesalahan berdasarkan kode error yang diterima.
            // pengembangan mobile: menyesuaikan fitur aplikasi berdasarkan versi sistem operasi perangkat.

            // kalau contoh dengan pengembangan web:
            // misalnya kita ingin menampilkan pesan selamat datang yang berbeda berdasarkan peran pengguna yang login:
            // atau contoh lain dalam pekerjaan pengembangan web adalah menentukan akses ke fitur tertentu berdasarkan peran pengguna:
            // string peranPengguna = "admin"; // ini bisa didapatkan dari sistem autentikasi

            // catatan: penggunaan percabangan harus sesuai dengan konteks dan kebutuhan logika program untuk memastikan alur eksekusi yang benar dan efisien.
        }
    }

    public class Looping
    {
        public static void LoopingDasar()
        {
            // Looping dasar di C#
            // Looping terbagi menjadi beberapa jenis yaitu:
            // 1. for loop
            // 2. while loop
            // 3. do-while loop
            // 4. foreach loop

            // 1. for loop
            Console.WriteLine("=== For Loop ===");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Perulangan ke-{i}");
            }
            // for loop di atas akan mengeksekusi blok kode di dalamnya sebanyak 5 kali, dengan variabel i yang bertambah dari 1 hingga 5.
            
            // 2. while loop
            Console.WriteLine("=== While Loop ===");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"Perulangan ke-{j}");
                j++;
            }
            // while loop di atas akan mengeksekusi blok kode di dalamnya selama kondisi (j <= 5) bernilai true.

            // 3. do-while loop
            Console.WriteLine("=== Do-While Loop ===");
            int k = 1;
            do
            {
                Console.WriteLine($"Perulangan ke-{k}");
                k++;
            } while (k <= 5);
            // do-while loop di atas akan mengeksekusi blok kode di dalamnya setidaknya satu kali, dan kemudian terus mengeksekusi selama kondisi (k <= 5) bernilai true.

            // 4. foreach loop
            Console.WriteLine("=== Foreach Loop ===");
            string[] buah = { "Apel", "Mangga", "Pisang", "Jeruk" };
            foreach (string item in buah)
            {
                Console.WriteLine($"Buah: {item}");
            }
            // foreach loop di atas akan mengeksekusi blok kode di dalamnya untuk setiap elemen dalam array buah.

            // catatan: penggunaan looping harus sesuai dengan konteks dan kebutuhan logika program untuk memastikan alur eksekusi yang benar dan efisien.
            // penjelasan singkat kapan menggunakan masing-masing jenis looping:
            // - for loop: digunakan ketika jumlah iterasi sudah diketahui sebelumnya atau ketika perlu mengakses indeks elemen dalam koleksi.
            // - while loop: digunakan ketika jumlah iterasi tidak diketahui sebelumnya dan bergantung pada kondisi tertentu.
            // - do-while loop: digunakan ketika blok kode harus dieksekusi setidaknya satu kali sebelum memeriksa kondisi.
            // - foreach loop: digunakan untuk mengiterasi elemen dalam koleksi atau array tanpa perlu mengelola indeks secara manual.

            // contoh penggunaan looping dalam konteks pengembangan website:
            // menampilkan daftar produk dari database dalam halaman web menggunakan foreach loop untuk mengiterasi setiap produk dan menampilkannya dalam format HTML.
            // contoh penggunaan looping dalam konteks pengembangan game:
            // mengupdate posisi musuh dalam game menggunakan for loop untuk mengiterasi setiap musuh dan memperbarui koordinatnya berdasarkan logika permainan.
            
        }
    }

    public class MetodeGetSet
    {
               private int nilai;
        // Metode Get
        public int GetNilai()
        {
            return nilai;
        }
        // Metode Set
        public void SetNilai(int nilaiBaru)
        {
            if (nilaiBaru >= 0) // Validasi sederhana
            {
                nilai = nilaiBaru;
            }
            else
            {
                Console.WriteLine("Nilai tidak boleh negatif.");
            }
        }
    }
}