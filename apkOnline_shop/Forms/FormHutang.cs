using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apkOnline_shop.Forms
{
    public partial class FormHutang : Form
    {

        Koneksi koneksi = new Koneksi();

        public void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridHutang.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        public FormHutang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPenjualan formPenjualan = new FormPenjualan();
            this.Hide();
            formPenjualan.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHutang formHutang = new FormHutang();
            this.Hide();
            formHutang.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReturn formReturn= new FormReturn();
            this.Hide();
            formReturn.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPemasukan formPemasukan = new FormPemasukan();
            this.Hide();
            formPemasukan.ShowDialog();
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormPengeluaran formPengeluaran = new FormPengeluaran();
            this.Hide();
            formPengeluaran.ShowDialog();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void FormHutang_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
