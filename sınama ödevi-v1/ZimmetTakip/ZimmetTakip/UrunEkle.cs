using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ZimmetTakip
{
    public partial class UrunEkle : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand kategori = new SqlCommand("SELECT Kategori_Adi FROM tbl_Kategori", baglanti);      
            SqlDataReader read = kategori.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read[0]);//Combobox un içine Kategorileri atar
            }            
            baglanti.Close();*/

            DataSet combo = islem.VeriCekDs("SELECT * FROM tbl_Kategori");
            comboKategori.ValueMember = "Kategori_Id";
            comboKategori.DisplayMember = "Kategori_Adi";
            comboKategori.DataSource = combo.Tables[0];
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = ("INSERT INTO tbl_Stok(Kategori_Id, Urun_Marka, Urun_Model, Urun_Fiyat, Urun_Adet) VALUES ('"+comboKategori.SelectedIndex+"','"+txtMarka.Text.Trim()+"','"+txtModel.Text.Trim()+"','"+txtFiyat.Text.Trim()+"','"+txtAdet.Text.Trim()+"') ");
            */
            string ekleSQL = "INSERT INTO tbl_Stok(Kategori_Id, Urun_Marka, Urun_Model, Urun_Fiyat, Urun_Adet) VALUES ('" + comboKategori.SelectedValue + "','" + txtMarka.Text.Trim() + "','" + txtModel.Text.Trim() + "','" + txtFiyat.Text.Trim() + "','" + txtAdet.Text.Trim() + "') ";
            islem.Ekle(ekleSQL, "Ürün Başarı İle Eklendi");
        }
    }
}
