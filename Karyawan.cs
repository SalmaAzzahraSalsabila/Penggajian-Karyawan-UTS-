using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    public class Karyawan
    {
        //methode
        public Karyawan()
        {
        }
        public Karyawan(string nik, string nama, int gajibulanan) {
            if(gajibulanan < 0)
            {
                Console.WriteLine("Gaji Harus Diatas 0!");
            }
            else
            {
                Nik = nik;
                Nama = nama;
                Gajibulanan = gajibulanan;
            }
        }

        //properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int Gajibulanan { get; set; }

    }
}
    