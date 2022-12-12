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
    public partial class FormKategori : Form
    {
        public MySqlCommand cmd;
        public string idKategori;


        public FormKategori()
        {
            InitializeComponent();
        }

        void tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `kategori`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridKategori.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("terjadi kesalahan");
            }
        }
        void refresh()
        {
            Koneksi.conn.Close();
            tampil();
            textBox7.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

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

        private void FormKategori_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dataGridKategori.CurrentCell.RowIndex;
            idKategori = dataGridKategori.Rows[baris].Cells[0].Value.ToString();

            MessageBox.Show("ini baris ke:" + baris.ToString());
            textBox7.Text = dataGridKategori.Rows[baris].Cells[1].Value.ToString();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `kategori` SET `nama_kategori` = '" + textBox7.Text + "' WHERE `kategori`.`id_kategori` = '" + idKategori + "';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();

                tampil();
            }
            catch(Exception)
            {
                MessageBox.Show("terjadi kesalahan");
            }
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                //crud hapus
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM kategori WHERE `kategori`.`id_kategori` = '" + idKategori + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil dihapus");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("data gagal dihapus");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                //crud tambah
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `kategori` (`id_kategori`, `nama_kategori`) VALUES (NULL, '" + textBox7.Text + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil ditambahkan");
                Koneksi.conn.Close();

                tampil();
                
            }
            catch(Exception)
            {
                MessageBox.Show("data gagal ditambahkan");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
