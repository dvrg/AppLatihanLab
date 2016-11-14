using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan
{
    class balok : PersegiPanjang
    {
        private int tinggi;

        public void SetTinggi(int t)
        {
            tinggi = t;
        }

        public int GetTinggi()
        {
            return tinggi;
        }

        public int HitungVolume()
        {
            return (panjang * lebar * tinggi);
        }
    }
}
