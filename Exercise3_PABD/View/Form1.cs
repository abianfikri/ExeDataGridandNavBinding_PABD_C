using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat Code Login dan Pindah Ke halaman Dashboard atau Halaman Selanjutnya 
            // Code Perulangan Username dan Password dan pembuatan message Box

            if(textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox1.Text.Equals("Abian") && textBox2.Text.Equals("123"))
            {
                this.Hide();
                MessageBox.Show("Selamat Datang " + textBox1.Text);
                Dashboard nama = new Dashboard();

                nama.dashAdmin.Text = this.textBox1.Text.ToString();
                nama.Show();
            }
            else
            {
                MessageBox.Show("Periksa Kembali Username dan Password Anda !!!!", "Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /* Membuat Password menjadi Hide */

            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Event Ketika Mengkilik Button Exit
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
