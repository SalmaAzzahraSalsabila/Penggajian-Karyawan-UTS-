using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek baru dari kelas karyawan 
            Karyawan karyawan1 = new Karyawan();

            //Memberi nilai objek baru 
            karyawan1.Nik = "18.11.2247";
            karyawan1.Nama = "Salma";
            karyawan1.Gajibulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.Nik = "18.11.2066";
            karyawan2.Nama = "Fajrul";
            karyawan2.Gajibulanan = 2000000;

            //Memanggil nilai pada object yang sudah dibuat
            Console.WriteLine("No. \tNIK/Nama\t\t\tGajibulanan");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("1. \t {0} {1}\t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.Gajibulanan);
            Console.WriteLine("2. \t {0} {1}\t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.Gajibulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyyiiikkk, naik gaji 10%");
            Console.WriteLine("\n");

            //Memanggil nilai pada object yang sudah dibuat setelah pertambahan 10%
            Console.WriteLine("No. \tNIK/Nama\t\t\tGajibulanan");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("1. \t {0} {1}\t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.Gajibulanan + (karyawan1.Gajibulanan * 0.10));
            Console.WriteLine("2. \t {0} {1}\t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.Gajibulanan + (karyawan1.Gajibulanan * 0.10));
            Console.ReadKey();
        }
    }
}