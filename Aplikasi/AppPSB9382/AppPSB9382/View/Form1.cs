using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppPSB9382
{
    public partial class Form1 : Form
    {
        private SqlConnection koneksiObj;
        public Form1()
        {
            //pembuatan instance
            //koneksi database diberikan di Implement
            koneksiObj = Koneksi.KoneksiDB.GetKoneksi();
            try
            {
                koneksiObj.Open();
                MessageBox.Show("koneksi Sukses");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Koneksi Gagal" + e);
                
            }
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
