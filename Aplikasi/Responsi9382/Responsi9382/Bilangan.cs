using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi9382
{
    class Bilangan
    {
        protected int angka;
        protected Bilangan() { }
        public void SetAngka(int a)
        {
            angka = a;
        }

        public int GetAngka()
        {
            return angka;
        }

        public virtual void Hasil() { }
    }

    class Prima : Bilangan
    {
        public override void Hasil()
        {
            if (angka > 1)
            {
                if(angka % angka == 0 && angka % 2 == 0)
                {
                    Console.Write("{0} Adalah Bukan Bilangan Prima", angka);
                
                    if(angka % 3 == 0)
                    {
                        Console.Write("{0} Adalah Bilangan Prima", angka);
                    }
                }
            }
            else
            {
                Console.WriteLine("Masukan Nilai lebih besar dari 1");
            }
                
        }
    }

    class DeretAngka : Bilangan
    {
        int tmp, der = 1;
        public override void Hasil()
        {
            for (int i = 1; i <= angka; i++)
            {
                do
                {
                    Console.Write("{0}, ", i);
                }
                while (angka > 1);
                {
                    der *= 2;
                    der = tmp;
                    Console.Write("{0}, ", tmp);
                }
            }
        }
    }
}
