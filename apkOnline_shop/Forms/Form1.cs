using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apkOnline_shop.Forms;
using MySql.Data;

namespace apkOnline_shop
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;


        public Form1()
        {
            InitializeComponent();
            random = new Random();
            //btnCloseChildForm.Visible = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color= SelectThemeColor();
                    currentButton= (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible=true;
                }   
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.StartPosition = FormStartPosition.CenterParent;
            //f2.ShowDialog(this);

            FormMaster fm = new FormMaster();
            this.Hide();
            fm.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        { 
            Penjualan penjualan = new Penjualan();
            this.Hide();
            penjualan.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLaporan lap = new FormLaporan();
            this.Hide();
            lap.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            //btnCloseChildForm.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                MessageBox.Show("Koneksi Database Berhasil");
            }
            catch(Exception)
            {

                MessageBox.Show("Koneksi gagal");
            }
        }
    }
}
