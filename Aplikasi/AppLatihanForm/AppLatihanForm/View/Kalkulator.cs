using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLatihanForm.View
{
    public partial class Kalkulator : Form
    {
        //tahap 0

        private Entity.EntityKalkulator kalkulator; //untuk variabel
        private Interface.IKalkulator kalkulatorDao; //untuk proses

        public Kalkulator()
        {
            kalkulatorDao = Factory.FactoryKalkulator.GetKalkulatorDao(); //untuk manggil implemen nya
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBagi_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            kalkulator = new Entity.EntityKalkulator();
            //input
            kalkulator.SetNilai1(double.Parse(txtBoxNilai1.Text));
            kalkulator.SetNilai2(double.Parse(txtBoxNilai2.Text));

            //proses + output
            txtBoxHasil.Text = kalkulatorDao.Penjumlahan(kalkulator).ToString();
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}
