using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanForm.Interface
{
    interface IKalkulator
    {
        //tahap kedua
        //tahap
        double Penjumlahan(Entity.EntityKalkulator e);
        double Pengurangan(Entity.EntityKalkulator e);
        double Perkalian(Entity.EntityKalkulator e);
        double Pembagian(Entity.EntityKalkulator e);
    }
}
