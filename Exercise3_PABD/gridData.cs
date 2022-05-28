using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Exercise3_PABD
{
    public partial class gridData : Form
    {
        public gridData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gridData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            // Mengedit Tampilan Tabel Database
            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;

            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;

            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;

            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menutup Halaman drid Data
            this.Hide();

            // Membuat objek baru utk kelas view Data
            // Sehingga data drid view bisa di tampilkan ke halaman View Data
            viewData DO = new viewData();

            DO.label6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DO.label7.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DO.label8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DO.label9.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DO.label10.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DO.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Dashboard nama = new Dashboard();
            nama.dashAdmin.Text = "Abian";
            nama.Show();
        }
    }
}
