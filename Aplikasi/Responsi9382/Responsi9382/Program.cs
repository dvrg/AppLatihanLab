using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi9382
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilangan bil = new Bilangan();
            Prima pri = new Prima();
            DeretAngka der = new DeretAngka();
            

            Console.WriteLine("Masuakan Angka : ");
            pri.SetAngka(Convert.ToInt16(Console.ReadLine()));
            pri.Hasil();
            Console.WriteLine();

            Console.WriteLine("Masuakan Angka : ");
            der.SetAngka(Convert.ToInt16(Console.ReadLine()));
            der.Hasil();
            Console.ReadLine();
        }
    }
}
