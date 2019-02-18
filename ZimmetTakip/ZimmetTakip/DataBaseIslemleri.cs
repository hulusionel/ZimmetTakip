using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZimmetTakip
{
   public class DataBaseIslemleri
    {
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");
      
        public DataTable VeriCekDt(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public DataSet VeriCekDs(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }

        public void Ekle(string sorgu, string mesaj)
        {
            baglanti.Open();
            SqlCommand cmd_insert = new SqlCommand(sorgu, baglanti);
            int kontrol = cmd_insert.ExecuteNonQuery();
            if (kontrol > 0)
            {
                MessageBox.Show(mesaj);
                baglanti.Close();
            }
        }

        public void Guncelle(string sorgu, string mesaj)
        {
            baglanti.Open();
            SqlCommand cmd_update = new SqlCommand(sorgu, baglanti);
            int kontrol = cmd_update.ExecuteNonQuery();
            if (kontrol > 0)
            {
                MessageBox.Show(mesaj);
                baglanti.Close();
            }
        }
    }
}

