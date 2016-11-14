namespace AppLatihanForm.View
{
    partial class Kalkulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtBoxNilai1 = new System.Windows.Forms.TextBox();
            this.lblNilai1 = new System.Windows.Forms.Label();
            this.lblNilai2 = new System.Windows.Forms.Label();
            this.txtBoxNilai2 = new System.Windows.Forms.TextBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.txtBoxHasil = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KALKULATOR SEDERHANA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBagi);
            this.panel1.Controls.Add(this.btnKali);
            this.panel1.Controls.Add(this.btnKurang);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Location = new System.Drawing.Point(180, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 104);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(46, 34);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(32, 23);
            this.btnBagi.TabIndex = 3;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(4, 34);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(36, 23);
            this.btnKali.TabIndex = 2;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = true;
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(46, 4);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(33, 23);
            this.btnKurang.TabIndex = 1;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(4, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(36, 23);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtBoxNilai1
            // 
            this.txtBoxNilai1.Location = new System.Drawing.Point(49, 17);
            this.txtBoxNilai1.Name = "txtBoxNilai1";
            this.txtBoxNilai1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNilai1.TabIndex = 0;
            // 
            // lblNilai1
            // 
            this.lblNilai1.AutoSize = true;
            this.lblNilai1.Location = new System.Drawing.Point(7, 20);
            this.lblNilai1.Name = "lblNilai1";
            this.lblNilai1.Size = new System.Drawing.Size(36, 13);
            this.lblNilai1.TabIndex = 1;
            this.lblNilai1.Text = "Nilai 1";
            this.lblNilai1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNilai2
            // 
            this.lblNilai2.AutoSize = true;
            this.lblNilai2.Location = new System.Drawing.Point(7, 44);
            this.lblNilai2.Name = "lblNilai2";
            this.lblNilai2.Size = new System.Drawing.Size(36, 13);
            this.lblNilai2.TabIndex = 2;
            this.lblNilai2.Text = "Nilai 2";
            // 
            // txtBoxNilai2
            // 
            this.txtBoxNilai2.Location = new System.Drawing.Point(50, 44);
            this.txtBoxNilai2.Name = "txtBoxNilai2";
            this.txtBoxNilai2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNilai2.TabIndex = 3;
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(7, 77);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(30, 13);
            this.lblHasil.TabIndex = 5;
            this.lblHasil.Text = "Hasil";
            this.lblHasil.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxHasil
            // 
            this.txtBoxHasil.Location = new System.Drawing.Point(50, 74);
            this.txtBoxHasil.Name = "txtBoxHasil";
            this.txtBoxHasil.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHasil.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxHasil);
            this.groupBox1.Controls.Add(this.lblHasil);
            this.groupBox1.Controls.Add(this.txtBoxNilai2);
            this.groupBox1.Controls.Add(this.lblNilai2);
            this.groupBox1.Controls.Add(this.lblNilai1);
            this.groupBox1.Controls.Add(this.txtBoxNilai1);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masukan Nilai";
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Kalkulator_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtBoxNilai1;
        private System.Windows.Forms.Label lblNilai1;
        private System.Windows.Forms.Label lblNilai2;
        private System.Windows.Forms.TextBox txtBoxNilai2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.TextBox txtBoxHasil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}