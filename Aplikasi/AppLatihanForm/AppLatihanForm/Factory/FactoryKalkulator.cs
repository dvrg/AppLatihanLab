using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanForm.Factory
{
    class FactoryKalkulator
    {
        //tahap keempat
        private static Interface.IKalkulator kalkulatorDao;

        //pengarahan proses dari interfaces ke implement
        public static Interface.IKalkulator GetKalkulatorDao()
        {
            kalkulatorDao = new Implement.ImpKalkulator();
            return kalkulatorDao;
        }
    }
}
