using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logService.Service masuk = new logService.Service();
            Boolean hasil;
            hasil = masuk.loginService((textBox1.Text), (textBox2.Text));
            if (hasil==true)
            {
                Form2 tampil = new Form2();
                tampil.Show();
                    this.Hide();
            }
            else 
            {
                label3.Text = "Gagal Masuk";
            }
        
        }
    }
}
