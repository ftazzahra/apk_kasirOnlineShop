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
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            f2.ShowDialog();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormIdeToko FI = new FormIdeToko();
            this.Hide();
            FI.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori();
            this.Hide();
            formKategori.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBarang2 formBarang2 = new FormBarang2();
            this.Hide();
            formBarang2.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPelanggan formPelanggan = new FormPelanggan();
            this.Hide();
            formPelanggan.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
