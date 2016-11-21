using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPSB9382.Koneksi
{
    class KoneksiDB
    {
        //tahap 0
        //pembuatan object dengan hak akses private, tipe nya SqlConnection dengan tipe object static
        private static SqlConnection koneksi;
        //untuk menghubungkan antara aplikasi dan database di butuhkan tipe SqlConnection
        public static SqlConnection GetKoneksi()
        {
            //membuat koneksi ke database
            koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=KOMPUTER33\\SQLEXPRESS;"+
                                        "Initial Catalog=db_psb;"+
                                        "Integrated Security=True";
            return koneksi;
        }

    }
}
