using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan
{
    class PersegiPanjang
    {
        protected int panjang;
        protected int lebar;

        private int p;
        private int l;

        public void SetPanjang(int p)
        {
            panjang = p;
        }

        public void SetLebar(int l)
        {
            lebar = l;
        }

        public int HitungLuas()
        {
            return(panjang * lebar);
        }
    }
}
