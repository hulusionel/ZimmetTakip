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
        private void UrunEkle_Load(object sender, EventArgs e)
        {         
            DataSet combo = islem.VeriCekDs("SELECT * FROM tbl_Kategori");
            comboKategori.ValueMember = "Kategori_Id";
            comboKategori.DisplayMember = "Kategori_Adi";
            comboKategori.DataSource = combo.Tables[0];
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {           
            string ekleSQL = "INSERT INTO tbl_Stok(Kategori_Id, Urun_Marka, Urun_Model, Urun_Fiyat, Urun_Adet, Urun_Kullanilabilirlik) VALUES ('" + comboKategori.SelectedValue + "','" + txtMarka.Text.Trim() + "','" + txtModel.Text.Trim() + "','" + txtFiyat.Text.Trim() + "','" + txtAdet.Text.Trim() + "','"+1+"') ";
            islem.Ekle(ekleSQL, "Ürün Başarı İle Eklendi");
            txtMarka.Text = "";
            txtModel.Text = "";
            txtFiyat.Text = "";
            txtAdet.Text = "";
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
