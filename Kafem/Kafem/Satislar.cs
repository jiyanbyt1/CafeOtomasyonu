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
    public partial class Satislar : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Satislar()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.Columns.Clear();
            string sorgu = "select * from Gecmis g left join Masa m on g.MasaID=m.MasaID";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView1.DataSource = dt;

            string sorgu2 = "select sum(ToplamKazanc) from Gecmis";
            DataRow dr2 = f.GetDataRow(sorgu2);
            int kazanc = Convert.ToInt32(dr2.ItemArray[0]);
            label3.Text = kazanc.ToString()+" ₺";
        }
        
        private void Satislar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
