using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apkOnline_shop.Forms
{
    public partial class FormIdeToko : Form
    {
        public MySqlCommand cmd;
        public string idIden;  
        public FormIdeToko()
        {
            InitializeComponent();
        }

        void tampil()
        {
            try
            {
                Koneksi.conn.Open(); 
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `identitas`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridIdtoko.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("terjadi kesalahan");
            }
        }

        //void cari()
        //{
        //    try
        //    {
        //        Koneksi.conn.Open();
        //        MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `identitas` WHERE `id_identitas` LIKE '%" + label8.Text + "%' ", Koneksi.conn);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        dataGridIdtoko.DataSource = ds.Tables[0];
        //        Koneksi.conn.Close();
        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("eror");
        //    }
        //}

        void refresh()
        {
            Koneksi.conn.Close();
            tampil();
            NamaToko.Clear();
            AlamatToko.Clear();
            NomorTelepon.Clear();
            CaptionPertama.Clear();
            CaptionKedua.Clear();
            CaptionKetiga.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIdeToko formIdeToko = new FormIdeToko();
            this.Hide();
            formIdeToko.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBarang2 fb2 = new FormBarang2();
            this.Hide();
            fb2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori();
            this.Hide();
            formKategori.ShowDialog();
           
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

        private void FormIdeToko_Load(object sender, EventArgs e)
        {
            tampil(); 
        }

        private void kirim_Click(object sender, EventArgs e)
        {
            NamaToko.Enabled = true;
            AlamatToko.Enabled = true;
            NomorTelepon.Enabled = true;
            CaptionPertama.Enabled = true;
            CaptionKedua.Enabled = true;
            CaptionKetiga.Enabled = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open(); 
                cmd = new MySqlCommand("UPDATE `identitas` SET `nama_toko` = '"+NamaToko.Text+"', `alamat_toko` = '" +AlamatToko.Text+ "', `nomor_telepon` = '" +NomorTelepon.Text+"', `caption_pertama` = '"+CaptionPertama.Text+"', `caption_kedua` = '"+CaptionKedua.Text+"', `caption_ketiga` = '"+CaptionKetiga.Text+ "' WHERE `identitas`.`id_identitas` = '" + idIden + "';", Koneksi.conn);
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

        private void dataGridIdtoko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dataGridIdtoko.CurrentCell.RowIndex;
            idIden = dataGridIdtoko.Rows[baris].Cells[0].Value.ToString();

            MessageBox.Show("ini baris ke:" + baris.ToString());
            NamaToko.Text = dataGridIdtoko.Rows[baris].Cells[1].Value.ToString();
            AlamatToko.Text = dataGridIdtoko.Rows[baris].Cells[2].Value.ToString();
            NomorTelepon.Text = dataGridIdtoko.Rows[baris].Cells[3].Value.ToString();
            CaptionPertama.Text = dataGridIdtoko.Rows[baris].Cells[4].Value.ToString();
            CaptionKedua.Text = dataGridIdtoko.Rows[baris].Cells[5].Value.ToString();
            CaptionKetiga.Text = dataGridIdtoko.Rows[baris].Cells[6].Value.ToString();
             
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hapus
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM identitas WHERE `identitas`.`id_identitas` = '" + idIden + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di hapus");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("data gagal dihapus");
            }
        }



        private void btcari_TextChanged(object sender, EventArgs e)
        {
            //cari();
            //tampil();
            //edit.Enabled = false;
            //hapus.Enabled = false;
            //batal.Enabled = false;
            //simpan.Enabled = false;
            //tambah.Enabled = false;
        }

        private void dataGridIdtoko_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NamaToko.Enabled = true;
            AlamatToko.Enabled = true;
            NomorTelepon.Enabled = true;
            CaptionPertama.Enabled = true;
            CaptionKedua.Enabled = true;
            CaptionKetiga.Enabled = true;
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            try
            {
                //crud simpan
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `identitas` (`id_identitas`, `nama_toko`, `alamat_toko`, `nomor_telepon`, `caption_pertama`, `caption_kedua`, `caption_ketiga`) VALUES(NULL, '" + NamaToko.Text + "', '" + AlamatToko.Text + "', '" + NomorTelepon.Text + "', '" + CaptionPertama.Text + "', '" + CaptionKedua.Text + "', '" + CaptionKetiga.Text + "');", Koneksi.conn);
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

        private void batal_Click(object sender, EventArgs e)
        {
            this.CancelButton = batal;
        }
    }
}
