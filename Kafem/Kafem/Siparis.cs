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
    public partial class Siparis : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Siparis()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.Columns.Clear();
            string sorgu = "select * from Siparisler s left join Masa m on s.MasaID=m.MasaID";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView1.DataSource = dt;
        }
        private void Siparis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            Listele();
        }
    }
}
