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
using System.Xml.Linq;

namespace apkOnline_shop.Forms
{
    public partial class FormPelanggan : Form
    {
        MySqlCommand cmd;
        public string idpelanggan;

        public void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `pelanggan2`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridPelanggan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }


        public FormPelanggan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIdeToko formIdeToko = new FormIdeToko();
            this.Hide();
            formIdeToko.ShowDialog();
            
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

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `pelanggan2` SET `nama_pelanggan` = '" + tbNama.Text + "', `nomor_telepon` = '" + tbNomor.Text + "', `alamat_pelanggan` = '" + tbAlamat.Text + "' WHERE `pelanggan2`.`id_pelanggan` = '" + idpelanggan + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
           
        }

        private void dataGridPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dataGridPelanggan.CurrentCell.RowIndex;
            idpelanggan = dataGridPelanggan.Rows[baris].Cells[0].Value.ToString();
            MessageBox.Show("ini baris ke:" + baris.ToString());

            tbNama.Text = dataGridPelanggan.Rows[baris].Cells[1].Value.ToString();
            tbNomor.Text = dataGridPelanggan.Rows[baris].Cells[2].Value.ToString();
            tbAlamat.Text = dataGridPelanggan.Rows[baris].Cells[3].Value.ToString();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hapus
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM pelanggan2 WHERE `pelanggan2`.`id_pelanggan` = '" + idpelanggan + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
           
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `pelanggan2` (`id_pelanggan`, `nama_pelanggan`, `nomor_telepon`, `alamat_pelanggan`) VALUES (NULL, '" + tbNama.Text + "', '" + tbNomor.Text + "', '" + tbAlamat.Text + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil");
                Koneksi.conn.Close();

                tampil();
            }
            catch(Exception)
            {
                MessageBox.Show("gagal");
            }
            
        }
    }
}
