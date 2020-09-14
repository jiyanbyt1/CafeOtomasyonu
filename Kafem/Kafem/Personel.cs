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
    public partial class Personel : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Personel()
        {
            InitializeComponent();
        }
        public void PersonelListele()
        {
            dataGridView1.Columns.Clear();
            string sorgu = "select * from Personel";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView1.DataSource = dt;
        }
        public void LoginListele()
        {
            dataGridView1.Columns.Clear();
            string loginsorgu = "select * from Login";
            DataTable logindt = f.GetDataTable(loginsorgu);
            dataGridView2.DataSource = logindt;
        }
        private void Personel_Load(object sender, EventArgs e)
        {
            LoginListele();

            PersonelListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtAdres.Text == "" || txtMaas.Text == "" || txtYas.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            }
            else
            {
                string sorgu = "insert into Personel(PersonelAdi,PersonelSoyadi,PersonelTel,PersonelYas,PersonelMaas,PersonelAdres) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtTel.Text + "','" + txtYas.Text + "','" + txtMaas.Text + "','" + txtAdres.Text + "')";
                DataTable dt1 = f.GetDataTable(sorgu);
                if (dt1 != null)
                {
                    txtAdi.Text = "";
                    txtSoyadi.Text = "";
                    txtTel.Text = "";
                    txtYas.Text = "";
                    txtMaas.Text = "";
                    txtAdres.Text = "";
                    PersonelListele();
                    MessageBox.Show("Personel Kaydedildi.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                var id = drow.Cells[0].Value;
                string sorgu = "delete from Personel where PersonelID='" + id + "'";
                DataTable dt3 = f.GetDataTable(sorgu);
                if (dt3 != null)
                {
                    PersonelListele();
                    MessageBox.Show("Personel Kaydı Silindi.");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gelenid != 0)
            {
                string sorgu = "update Personel set PersonelAdi='"+txtAdi.Text+"',PersonelSoyadi='"+txtSoyadi.Text+"',PersonelTel='"+txtTel.Text+"',PersonelYas='"+txtYas.Text+"',PersonelMaas='"+txtMaas.Text+"',PersonelAdres='"+txtAdres.Text+"' where PersonelID='"+gelenid+"'";
                DataTable dt = f.GetDataTable(sorgu);
                if (dt != null)
                {
                    PersonelListele();
                    MessageBox.Show("Personel Kaydı Güncellendi.");
                }
            }
        }
        int gelenid = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                gelenid = Convert.ToInt32(drow.Cells[0].Value);
                var adi = drow.Cells[1].Value;
                var soyadi = drow.Cells[2].Value;
                var tel = drow.Cells[3].Value;
                var yas = drow.Cells[4].Value;
                var maas = drow.Cells[5].Value;
                var adres = drow.Cells[6].Value;

                txtAdi.Text = adi.ToString();
                txtSoyadi.Text = soyadi.ToString();
                txtTel.Text = tel.ToString();
                txtYas.Text = yas.ToString();
                txtMaas.Text = maas.ToString();
                txtAdres.Text = adres.ToString();



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtLoginKadi.Text == "" || txtLoginSifre.Text == "" || txtLoginYetki.Text == "" || txtLoginAdi.Text == "" || txtLoginSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            }
            else
            {
                string sorgu = "insert into Login(KullaniciAdi,Sifre,Yetki,Adi,Soyadi) values('" + txtLoginKadi.Text + "','" + txtLoginSifre.Text + "','" + txtLoginYetki.Text + "','" + txtLoginAdi.Text + "','" + txtLoginSoyadi.Text + "')";
                DataTable dt1 = f.GetDataTable(sorgu);
                if (dt1 != null)
                {
                    txtLoginKadi.Text = "";
                    txtLoginSifre.Text = "";
                    txtLoginYetki.Text = "";
                    txtLoginAdi.Text = "";
                    txtLoginSoyadi.Text = "";
                    
                    LoginListele();

                    PersonelListele();
                    MessageBox.Show("Giriş Personeli Kaydedildi.");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
            {
                var id = drow.Cells[0].Value;
                string sorgu = "delete from Login where ID='" + id + "'";
                DataTable dt3 = f.GetDataTable(sorgu);
                if (dt3 != null)
                {
                    LoginListele();

                    PersonelListele();
                    MessageBox.Show("Giriş Kaydı Silindi.");
                }

            }
        }
    }
}
