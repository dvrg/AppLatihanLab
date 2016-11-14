using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanForm.Entity
{
    class NilaiMhs
    {
        private string nama;
        private string kelas;
        private string nim;
        private string statusnya;
        private double ipk;

        public void SetNama(string nam)
        {
            nama = nam;
        }

        public string GetNama()
        {
            return nama;
        }

        public void SetNim(string nm)
        {
            nim = nm;
        }

        public string GetNim()
        {
            return nim;
        }

        public void SetKelas(string kls)
        {
            kelas = kls;
        }

        public string GetKelas()
        {
            return kelas;
        }

        public void SetStatusnya(string sts)
        {
            statusnya = sts;
        }

        public string GetStatusnya()
        {
            return statusnya;
        }

        public void SetNilai(double nilai)
        {
            ipk = nilai;
        }

        public double GetNilai()
        {
            return ipk;
        }

    }
}
