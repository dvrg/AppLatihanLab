using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanForm.Implement
{
    class ImpKalkulator : Interface.IKalkulator
    {
        //tahap ketiga
        //tahap proses
        public double Penjumlahan(Entity.EntityKalkulator e)
        {
            return (e.GetNilai1() + e.GetNilai2());
        }
        public double Pengurangan(Entity.EntityKalkulator e)
        {
            return (e.GetNilai1() - e.GetNilai2());
        }
        public double Perkalian(Entity.EntityKalkulator e)
        {
            return (e.GetNilai1() * e.GetNilai2());
        }
        public double Pembagian(Entity.EntityKalkulator e)
        {
            return (e.GetNilai1() / e.GetNilai2());
        }

    }
}
