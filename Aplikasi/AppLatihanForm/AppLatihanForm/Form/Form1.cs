using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLatihanForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            Entity.NilaiMhs mhs = new Entity.NilaiMhs();
            //input ke entity -> fungsi set
            mhs.SetNim(txtNim.Text);
            mhs.SetNama(txtNama.Text);
            mhs.SetNilai(Double.Parse(txtNilai.Text));
            //output -> fungsi get
            if (mhs.GetNilai() <= 100.00)
            {
                if (mhs.GetNilai() > 80)
                {
                    lblHasil.Text = "Sangat Baik";
                }
                else if (mhs.GetNilai() >= 70)
                {
                    lblHasil.Text = "Baik";
                }
                else if (mhs.GetNilai() >= 60)
                {
                    lblHasil.Text = "cukup";
                }
                else if (mhs.GetNilai() < 60)
                {
                    lblHasil.Text = "Kurang";
                }
            }
            else
            {
                lblHasil.Text = "Nilai salah";
            }
        }

        private void txtNilai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
