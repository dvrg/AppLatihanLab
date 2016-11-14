using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKaryawan
{
    class Karyawan
    {
        protected string nama, nik, jab;
        protected int absen;

        public Karyawan()
        {
            nama = "David Rigan";
            nik = "15.11.9382";
            jab = "Supervisor";
            absen = 20;
        }

        public virtual void tampilData()
        {
            Console.WriteLine("Nama Karyawan : " + nama);
            Console.WriteLine("NIK Karyawan : " + nik);
            Console.WriteLine("Jabatan : " + jab);
            Console.WriteLine("absen : " + absen);
        }
    }

    class KaryawanTetap : Karyawan
    {
        int gaji;

        public KaryawanTetap()
        {
            if (jab == "Supervisor")
            {
                gaji = 150000;
            }
            else if (jab == "Staff")
            {
                gaji = 55000;
            }
            gaji *= absen;
        }

        public override void tampilData()
        {
            Console.WriteLine("Nama Karyawan : " + nama);
            Console.WriteLine("NIK Karyawan : " + nik);
            Console.WriteLine("Jabatan : " + jab);
            Console.WriteLine("absen : " + absen);
            Console.WriteLine("Gaji : " + gaji);
        }

    }

    class KaryawanKontrak : Karyawan
    {
        private int bonus;

        public KaryawanKontrak()
        {
            if (absen > 22)
            {
                bonus = 1000000;
            }
            else
            {
                bonus = 500000;
            }
        }

        public override void tampilData()
        {
            Console.WriteLine("Nama Karyawan : " + nama);
            Console.WriteLine("NIK Karyawan : " + nik);
            Console.WriteLine("Jabatan : " + jab);
            Console.WriteLine("Bonus : " + bonus);
        }
    }

    class TotalGaji : Karyawan
    {
        public TotalGaji()
        {
            Total =
        }
    }
}
