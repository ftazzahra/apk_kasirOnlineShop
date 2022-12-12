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
    public partial class FormPemasukan : Form
    {
        Koneksi koneksi = new Koneksi();

        public void tampil()
        {
           
        }

        public FormPemasukan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPenjualan pemasukan = new FormPenjualan();
            this.Hide();
            pemasukan.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHutang hutang = new FormHutang();
            this.Hide();
            hutang.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn();
            this.Hide();
            formReturn.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPemasukan pemasukan = new FormPemasukan();
            this.Hide();
            pemasukan.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormPengeluaran pengeluaran = new FormPengeluaran();
            this.Hide();
            pengeluaran.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void FormPemasukan_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
