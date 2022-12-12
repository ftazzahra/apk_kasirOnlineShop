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
    public partial class Penjualan : Form
    {
        public Penjualan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPenjualan penjualan = new FormPenjualan();
            penjualan.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReturn fr = new FormReturn();
            fr.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPemasukan formPemasukan = new FormPemasukan();
            formPemasukan.ShowDialog();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormPengeluaran formPengeluaran = new FormPengeluaran();
            formPengeluaran.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHutang formHutang = new FormHutang();
            this.Hide();
            formHutang.ShowDialog();
        }
    }
}
