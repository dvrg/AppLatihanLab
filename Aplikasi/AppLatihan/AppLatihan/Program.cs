using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan
{
    class Program
    {
        static void Main(string[] args)
        {
            //hanya panggil class turunan;
            balok bl = new balok();

            Console.WriteLine("Masukan Panjang: ");
            bl.SetPanjang(Int16.Parse(Console.ReadLine()));

            Console.WriteLine("Masukan Lebar: ");
            bl.SetLebar(Int16.Parse(Console.ReadLine()));

            Console.WriteLine("Masukan Tinggi: ");
            bl.SetTinggi(Int16.Parse(Console.ReadLine()));

            Console.WriteLine("Luas : " + bl.HitungLuas());
            Console.WriteLine("Volume : " + bl.HitungVolume());

            Console.ReadLine();
        }
    }
}
