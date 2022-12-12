using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apkOnline_shop.Forms
{
    public partial class FormPenjualan : Form
    {

        Koneksi koneksi = new Koneksi();

        public void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `penjualan2`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridPenjualan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            tampil();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHutang hutang = new FormHutang();
            hutang.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPenjualan penjualan = new FormPenjualan();
            this.Hide();
            penjualan.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn();
            this.Hide();
            formReturn.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPemasukan formPemasukan = new FormPemasukan();
            this.Hide();
            formPemasukan.Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormPengeluaran formPengeluaran = new FormPengeluaran();
            this.Hide();
            formPengeluaran.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
