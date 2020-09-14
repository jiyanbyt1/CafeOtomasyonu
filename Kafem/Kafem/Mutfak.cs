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
    public partial class Mutfak : Form
    {
        Fonksiyonlar f = new Fonksiyonlar();
        public Mutfak()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.Columns.Clear();
            string sorgu = "select * from Siparisler";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView1.DataSource = dt;
        }
        public void MasaListele()
        {
            dataGridView2.Columns.Clear();
            string sorgu = "select * from Masa";
            DataTable dt = f.GetDataTable(sorgu);
            dataGridView2.DataSource = dt;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            MasaListele();

            Listele();
        }

        private void Mutfak_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Start();
        }
    }
}
