using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apkOnline_shop.Forms
{
    public partial class FormBarang2 : Form
    {
        public MySqlCommand cmd;
        public string idBarang;

        public void tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `barang2`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridBarang.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Duh!!, Ada Error Nih");
            }

        }

        public FormBarang2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIdeToko frmMaster = new FormIdeToko();
            this.Hide();
            frmMaster.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori();
            this.Hide();
            formKategori.ShowDialog(this);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBarang2 formBarang2 = new FormBarang2();
            this.Hide();
            formBarang2.ShowDialog(this);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPelanggan formPelanggan = new FormPelanggan();
            this.Hide();
            formPelanggan.ShowDialog(this);
           
        }

        private void FormBarang2_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            

            //tbnamabr.Enabled = true;
            //tbkategoribar.Enabled = true;
            //tbstokbr.Enabled = true;
            //tbhargabeli.Enabled = true;
            //tbhargajual.Enabled = true;
            //tbjenisbar.Enabled = true;
            //btTambah.Enabled = true;
            //btEdit.Enabled = false;
            //btHapus.Enabled = false;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit or simpan
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `barang2` SET `nama_barang` = '"+tbnamabr.Text+"', `stok_barang` = '"+tbstokbr.Text+"', `kategori_barang` = '"+tbkategoribar.SelectedItem+"', `harga_beli` = '"+tbhargabeli.Text+"', `harga_jual` = '"+tbhargajual.Text+"', `jenis_barang` = '"+tbjenisbar.SelectedItem+"' WHERE `barang2`.`id_barang` = '"+idBarang+"';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("Update Gagal");
            }
        }

        private void dataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dataGridBarang.CurrentCell.RowIndex;
            idBarang = dataGridBarang.Rows[baris].Cells[0].Value.ToString();

            MessageBox.Show("ini baris ke:" + baris.ToString());
            tbnamabr.Text = dataGridBarang.Rows[baris].Cells[1].Value.ToString();
            tbstokbr.Text = dataGridBarang.Rows[baris].Cells[2].Value.ToString();
            tbkategoribar.Text = dataGridBarang.Rows[baris].Cells[3].Value.ToString();
            tbhargabeli.Text = dataGridBarang.Rows[baris].Cells[4].Value.ToString();
            tbhargajual.Text = dataGridBarang.Rows[baris].Cells[5].Value.ToString();
            tbjenisbar.Text = dataGridBarang.Rows[baris].Cells[6].Value.ToString();

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //crud tambah
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `barang2` (`id_barang`, `nama_barang`, `stok_barang`, `kategori_barang`, `harga_beli`, `harga_jual`, `jenis_barang`) VALUES (NULL, '"+tbnamabr.Text+"', '"+tbstokbr.Text+"', '"+tbkategoribar.SelectedItem+"', '"+tbhargabeli.Text+"', '"+tbhargajual.Text+"', '"+tbjenisbar.Text+"');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
                Koneksi.conn.Close();

                tampil();
            }

            catch (Exception)
            {
                MessageBox.Show("data gagal ditambahkan");
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hapus
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM barang2 WHERE `barang2`.`id_barang` = '"+idBarang+"'", Koneksi.conn);
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
    }
 }

