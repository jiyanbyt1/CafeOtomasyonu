using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafem
{
    public partial class AnaSayfa : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu grs = new Menu();
            grs.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            string sorgu1 = "select * from Siparisler where MasaID=1";
            DataRow dr1 = f.GetDataRow(sorgu1);
            if (dr1 != null)
            {
                btnMasa1.BackColor = Color.Green;
            }


            string sorgu2 = "select * from Siparisler where MasaID=2";
            DataRow dr2 = f.GetDataRow(sorgu2);
            if (dr2 != null)
            {
                btnMasa2.BackColor = Color.Green;
            }

            string sorgu3 = "select * from Siparisler where MasaID=3";
            DataRow dr3 = f.GetDataRow(sorgu3);
            if (dr3 != null)
            {
                btnMasa3.BackColor = Color.Green;
            }

            string sorgu4 = "select * from Siparisler where MasaID=4";
            DataRow dr4 = f.GetDataRow(sorgu4);
            if (dr4 != null)
            {
                btnMasa4.BackColor = Color.Green;
            }

            string sorgu5 = "select * from Siparisler where MasaID=5";
            DataRow dr5 = f.GetDataRow(sorgu5);
            if (dr5 != null)
            {
                btnMasa5.BackColor = Color.Green;
            }

            string sorgu6 = "select * from Siparisler where MasaID=6";
            DataRow dr6 = f.GetDataRow(sorgu6);
            if (dr6 != null)
            {
                btnMasa6.BackColor = Color.Green;
            }

            string sorgu7 = "select * from Siparisler where MasaID=7";
            DataRow dr7 = f.GetDataRow(sorgu7);
            if (dr7 != null)
            {
                btnMasa7.BackColor = Color.Green;
            }

            string sorgu8 = "select * from Siparisler where MasaID=8";
            DataRow dr8 = f.GetDataRow(sorgu8);
            if (dr8 != null)
            {
                btnMasa8.BackColor = Color.Green;
            }

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login grs = new Login();
            grs.Show();
            this.Hide();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 1;
            Fonksiyonlar.masa = btnMasa1.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();

            
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 2;
            Fonksiyonlar.masa = btnMasa2.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 3;
            Fonksiyonlar.masa = btnMasa3.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 4;
            Fonksiyonlar.masa = btnMasa4.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 5;
            Fonksiyonlar.masa = btnMasa5.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 6;
            Fonksiyonlar.masa = btnMasa6.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 7;
            Fonksiyonlar.masa = btnMasa7.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Masaid = 8;
            Fonksiyonlar.masa = btnMasa8.Text;
            Siparisler grs2 = new Siparisler();
            grs2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel grs = new Personel();
            grs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mutfak grs = new Mutfak();
            grs.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Siparis grs = new Siparis();
            grs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satislar grs = new Satislar();
            grs.ShowDialog();
        }
    }
}
