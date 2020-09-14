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
    public partial class Login : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtKadi.Text=="" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz.!");
            }
            else
            {
                string sorgu = "select * from Login where KullaniciAdi='" + txtKadi.Text + "' and Sifre='" + txtSifre.Text + "'";
                DataRow dr = f.GetDataRow(sorgu);
                if (dr != null)
                {
                    AnaSayfa grs = new AnaSayfa();
                    grs.Show();
                    this.Hide();
                    grs.label1.Text = dr.ItemArray[4].ToString()+" "+ dr.ItemArray[5].ToString();
                    if (dr.ItemArray[3].ToString() == "yönetici")
                    {
                        grs.panel2.Visible = true;
                    }
                    txtKadi.Text = "";
                    txtSifre.Text = "";
                    grs.label4.Text = dr.ItemArray[3].ToString();

                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Hatalıdır. Lütfen Tekrar Deneyiniz.");
                    txtKadi.Text = "";
                    txtSifre.Text = "";
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
