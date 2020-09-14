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

namespace Kafem
{

    public partial class Siparisler : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Siparisler()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.Columns.Clear();
            string sorgu = @"select s.SiparislerID,s.UrunAdi,s.UrunTutari, m.Masalar 
            from Siparisler s left join Masa m on s.MasaID=m.MasaID where s.MasaID='" + Fonksiyonlar.Masaid + "'";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView1.DataSource = dt;
        }
        private void Siparisler_Load(object sender, EventArgs e)
        {
            Listele();
            // TODO: Bu kod satırı 'kafemDataSet.Siparisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.siparislerTableAdapter.Fill(this.kafemDataSet.Siparisler);
            string sorgu = "select GrupAdi from Gruplar";
            DataTable dt = f.GetDataTable(sorgu);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i].ItemArray[0]);
            }
            lblMasa.Text = Fonksiyonlar.masa;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int x = comboBox1.SelectedIndex + 1;
            string sorgu2 = "select MenuUrunAdi from Menu where GrupID='" + x + "'";
            DataTable dt2 = f.GetDataTable(sorgu2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt2.Rows[i].ItemArray[0]);
            }

        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {





            if (comboBox1.Text=="" || comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen ürün Seçimi Yapınız.");
            }
            else
            {
                string fiyatsorgu = "select MenuUrunFiyati from Menu where MenuUrunAdi='" + comboBox2.Text + "'";
                DataRow drFiyat = f.GetDataRow(fiyatsorgu);
                var Fiyat = drFiyat.ItemArray[0];

                string sorgu = "insert into Siparisler(MasaID,UrunAdi,UrunTutari) values('" + Fonksiyonlar.Masaid + "','" + comboBox2.Text + "','" + Fiyat + "')";
                DataTable dt1 = f.GetDataTable(sorgu);
                if (dt1 != null)
                {
                    Listele();
                    MessageBox.Show("Sipariş Alındı.");
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                
            }



            
            
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                var id = drow.Cells[0].Value;
                string sorgu = "delete from Siparisler where SiparislerID='"+id+"'";
                DataTable dt3 = f.GetDataTable(sorgu);
                if (dt3 != null)
                {
                    Listele();
                    MessageBox.Show("Sipariş İptal Edildi");
                }
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu1 = "select sum(UrunTutari) toplam from Siparisler where MasaID='"+Fonksiyonlar.Masaid+"'";
            DataRow dr1 = f.GetDataRow(sorgu1);
            var toplamTutar = dr1.ItemArray[0];
            var tarihsaat = DateTime.Now;
            string sorgu2 = "insert into Gecmis(MasaID,ToplamKazanc,tarihsaat) values('"+Fonksiyonlar.Masaid+"','"+toplamTutar+"','"+tarihsaat+"')";
            DataTable dt1 = f.GetDataTable(sorgu2);
            if (dt1 != null)
            {
                string sorgu3 = "delete from Siparisler where MasaID='" + Fonksiyonlar.Masaid + "'";
                DataRow dr2 = f.GetDataRow(sorgu3);
                MessageBox.Show("Masa Kapatıldı");
                AnaSayfa grs = new AnaSayfa();
                this.Hide();
                if (Fonksiyonlar.Masaid == 1)
                {
                    grs.btnMasa1.BackColor = Color.Red;
                    grs.Refresh();
                    grs.label1.Text = "Heyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";
                }
                if (Fonksiyonlar.Masaid == 2)
                {
                    grs.btnMasa2.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 3)
                {
                    grs.btnMasa3.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 4)
                {
                    grs.btnMasa4.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 5)
                {
                    grs.btnMasa5.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 6)
                {
                    grs.btnMasa6.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 7)
                {
                    grs.btnMasa7.BackColor = Color.Red;
                }
                if (Fonksiyonlar.Masaid == 8)
                {
                    grs.btnMasa8.BackColor = Color.Red;
                }

            }
        }
    }
}
