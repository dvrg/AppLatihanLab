using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();

            KaryawanTetap tetap = new KaryawanTetap();
            KaryawanKontrak kontrak = new KaryawanKontrak();
            TotalGaji total = new TotalGaji();


            karyawan = tetap;
            karyawan.tampilData();

            Console.WriteLine(" ");

            karyawan = kontrak;
            karyawan.tampilData();

            Console.WriteLine(" ");

            karyawan = total;
            karyawan.tampilData();
        }
    }
}
