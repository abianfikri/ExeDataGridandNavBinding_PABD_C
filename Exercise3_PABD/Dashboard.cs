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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Menutup dan Membuka Halaman Grid Data
            this.Hide();
            new gridData().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Menutup dan Membuka Halaman Login Kembali ketika mengklik gambar Back
            this.Hide();
            new Form1().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Menutup dan Membuka Halaman Nav Binding
            this.Hide();
            new navBinding().Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dashAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
