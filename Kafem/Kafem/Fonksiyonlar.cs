using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kafem
{
    class Fonksiyonlar
    {
        public static string masa = "0";
        public static int Masaid = 0;

        public SqlConnection Baglan()
        {
            SqlConnection baglanti = new SqlConnection("Server=.;Database=Kafem;integrated Security=true;connection timeout=0;");
            if (baglanti.State != System.Data.ConnectionState.Open)
            {
                try
                {

                    baglanti.Open();
                    SqlConnection.ClearPool(baglanti);

                }
                catch (SqlException)
                {
                }

            }

            return baglanti;

        }

        public int cmd(string sqlcumle)
        {
            SqlConnection baglan = this.Baglan();
            SqlCommand cmd = new SqlCommand(sqlcumle, baglan);


            int sonuc = 0;
            try
            {
                sonuc = cmd.ExecuteNonQuery();
                cmd.CommandTimeout = 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            cmd.CommandTimeout = 0;
            cmd.Dispose();
            baglan.Close();
            baglan.Dispose();

            return (sonuc);
        }

        public DataTable GetDataTable(string sql)
        {
            SqlConnection baglan = this.Baglan();
            SqlDataAdapter adap = new SqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adap.Fill(dt);

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            adap.Dispose();
            baglan.Close();

            return dt;

        }

        public DataTable Listele(string TabloAdi)
        {
            string sorgu = "select * from  " + TabloAdi + "";


            return GetDataTable(sorgu);
        }
        public DataTable WhereListele(string TabloAdi, string sart)
        {
            string sorgu = "select * from  " + TabloAdi + "  where  '" + sart + "'";
            return GetDataTable(sorgu);
        }
        public DataRow GetDataRow(string sql)
        {

            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 0)
                return null;
            return dt.Rows[0];
        }
        public string GetDataCell(string sql)
        {
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 0) return null;
            return dt.Rows[0][0].ToString();

        }
    }
}
