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
    public partial class FormPengeluaran : Form
    {
        Koneksi Koneksi = new Koneksi();

        public void tampil()
        {
           
        }

        public FormPengeluaran()
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
            FormReturn formReturn = new FormReturn();
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

        private void FormPengeluaran_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
