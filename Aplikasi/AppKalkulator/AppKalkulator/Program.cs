using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tmp = 0;

            Console.WriteLine("Masukan Nilai: ")
            n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                for(int i=0;i <= n;i++)
                {
                    /*
                    Console.WriteLine("Masukan X atau Y ");
                    tombol = char.Parse(Console.ReadLine());*/

                    if (tombol == x || tombol == X)
                    {
                        tmp = 1;
                    }
                    else if (tombol == y || tombol == Y)
                    {
                        tmp = 2;
                    }
                }
            }
        }
    }
}
