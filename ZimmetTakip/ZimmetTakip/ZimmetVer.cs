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
    public partial class ZimmetVer : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public ZimmetVer()
        {
            InitializeComponent();
        }

        private void ZimmetVer_Load(object sender, EventArgs e)
        {
            
            DataTable gridPersonelDoldur = islem.VeriCekDt("SELECT * FROM v_PersonelListele");
            gridPersonel.DataSource = gridPersonelDoldur;
            gridPersonel.AllowUserToAddRows = false;

            DataTable gridUrunDoldur = islem.VeriCekDt("SELECT * FROM tbl_Stok WHERE Urun_Kullanilabilirlik='"+1+"'");
            gridUrun.DataSource = gridUrunDoldur;
            gridUrun.AllowUserToAddRows = false;

            //Combobox Departmanların doldurulması
            DataSet comboDepartman = islem.VeriCekDs("SELECT * FROM tbl_Departman");
            comboPersonel.ValueMember = "Depertman_Id";
            comboPersonel.DisplayMember = "Departman_Adi";
            comboPersonel.DataSource = comboDepartman.Tables[0];

            //Combobox ürünlerin doldurulması
            DataSet comboUrunKategori = islem.VeriCekDs("SELECT * FROM tbl_Kategori");
            comboUrun.ValueMember = "Kategori_Id";
            comboUrun.DisplayMember = "Kategori_Adi";
            comboUrun.DataSource = comboUrunKategori.Tables[0];           
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            if (secilenPersonelId.ToString() != "" && secilenUrunId.ToString() != "")
            {
                string stokKontrol = "SELECT * FROM tbl_Stok WHERE Urun_Id=('" + secilenUrunId + "')";
                DataSet stokKontrolDs = islem.VeriCekDs(stokKontrol);
                int gelen = Convert.ToInt32(stokKontrolDs.Tables[0].Rows[0]["Urun_Adet"]);
                int sonuc;

                if (txtZimmetlenecekUrunAdet.Text != "")
                {
                     sonuc = (gelen - Convert.ToInt32(txtZimmetlenecekUrunAdet.Text));
                    if (sonuc >= 0)
                    {
                        string zimmetleSQL = ("INSERT INTO tbl_Zimmet(Personel_Id, Departman_Id, Urun_Id, Urun_Adet, Zimmetlenme_Tarihi) VALUES ('" + secilenPersonelId + "','" + secilenPersonelDepartmanId + "','" + secilenUrunId + "','" + Convert.ToInt32(txtZimmetlenecekUrunAdet.Text.Trim()) + "','" + DateTime.Now.ToShortDateString() + "') ");
                        string zimmetStokGuncelle = "UPDATE tbl_Stok SET Urun_Adet='" + sonuc + "'WHERE Urun_Id='"+secilenUrunId+"'";
                        //TODO: Stoktan adet düşme için güncelleme yapılacak ama adeti kotrol etmek lazım!!!!

                        islem.Guncelle(zimmetStokGuncelle);
                        islem.Ekle(zimmetleSQL, "Ürün Zİmmetleme İşlemi Başarı İle Yapıldı.");

                        DataTable gridUrunDoldur = islem.VeriCekDt("SELECT * FROM tbl_Stok WHERE Urun_Kullanilabilirlik='" + 1 + "'");
                        gridUrun.DataSource = gridUrunDoldur;
                        gridUrun.AllowUserToAddRows = false;

                    }
                    else
                    {
                        MessageBox.Show("Stok Sayısı Yeterli Değildir!");
                    }
                }
                else if (txtZimmetlenecekUrunAdet.Text == "")
                {
                    sonuc = gelen - 1;
                    if ((gelen - 1) >= 0)
                    {
                        string zimmetleSQL = ("INSERT INTO tbl_Zimmet(Personel_Id, Departman_Id, Urun_Id, Urun_Adet, Zimmetlenme_Tarihi) VALUES ('" + secilenPersonelId + "','" + secilenPersonelDepartmanId + "','" + secilenUrunId + "','" + 1 + "','" + DateTime.Now.ToShortDateString() + "') ");
                        string zimmetStokGuncelle = "UPDATE tbl_Stok SET Urun_Adet='" + sonuc + "'WHERE Urun_Id='" + secilenUrunId + "'";
                        //TODO: Stoktan adet düşme için güncelleme yapılacak ama adeti kotrol etmek lazım!!!!

                        islem.Guncelle(zimmetStokGuncelle);
                        islem.Ekle(zimmetleSQL, "Ürün Zİmmetleme İşlemi Başarı İle Yapıldı.");

                        DataTable gridUrunDoldur = islem.VeriCekDt("SELECT * FROM tbl_Stok WHERE Urun_Kullanilabilirlik='" + 1 + "'");
                        gridUrun.DataSource = gridUrunDoldur;
                        gridUrun.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Stok Sayısı Yeterli Değildir!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Personel ve Ürün Seçiniz!");
            }
        }

        public static string secilenPersonel, secilenUrunId, secilenPersonelId, secilenPersonelDepartmanId;

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboGelenDeger = (comboUrun.SelectedIndex + 1).ToString(); //DENEMEK İÇİN
            DataTable gridUrunDoldur = islem.VeriCekDt("sp_UrunListeleCombo " + comboGelenDeger + "");
            gridUrun.DataSource = gridUrunDoldur;
            gridUrun.AllowUserToAddRows = false;
        }

        private void gridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {              
                lblSecilenPersonel.Text = "Seçilen Personel: " + gridPersonel.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + gridPersonel.Rows[e.RowIndex].Cells[2].Value.ToString();
                string al = gridPersonel.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataSet secilenPer = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Id='" + al + "'");
                secilenPersonelId = secilenPer.Tables[0].Rows[0]["Personel_Id"].ToString();
                secilenPersonelDepartmanId = secilenPer.Tables[0].Rows[0]["Departman_Id"].ToString();
            }
        }

        private void gridUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lblSecilenUrun.Text = "Seçilen Ürün: " + gridUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
                string al = gridUrun.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataSet secilenUr = islem.VeriCekDs("SELECT * FROM tbl_Stok WHERE Urun_Kullanilabilirlik ='" + 1 + "' AND Urun_Id='" + al + "'");
                secilenUrunId = secilenUr.Tables[0].Rows[0]["Urun_Id"].ToString();
            }
        }

        private void comboPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboGelenDeger = (comboPersonel.SelectedIndex +1).ToString(); //DENEMEK İÇİN
            DataTable gridPersonelDoldur = islem.VeriCekDt("sp_PersonelListeleCombo " + comboGelenDeger +"");
            gridPersonel.DataSource = gridPersonelDoldur;
            gridPersonel.AllowUserToAddRows = false;
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            /*
            lblSecilenPersonel.Text = "Seçilen Personel: " + gridPersonel.CurrentRow.Cells[1].Value.ToString() + " " + gridPersonel.CurrentRow.Cells[2].Value.ToString();
            string al=gridPersonel.CurrentRow.Cells[0].Value.ToString();

            //Seçilen personelin ıd bilgisi ile departmanını ve personel ıd sini alıyoruz.  
            DataSet secilenPer = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Id='" + al + "'");
            secilenPersonelId = secilenPer.Tables[0].Rows[0]["Personel_Id"].ToString();
            secilenPersonelDepartmanId = secilenPer.Tables[0].Rows[0]["Departman_Id"].ToString();
            */
        }

        private void gridUrun_SelectionChanged(object sender, EventArgs e)
        {
            /*
            lblSecilenUrun.Text = "Seçilen Ürün: " + gridUrun.CurrentRow.Cells[2].Value.ToString();
            string al = gridUrun.CurrentRow.Cells[0].Value.ToString();
            DataSet secilenUr = islem.VeriCekDs("SELECT * FROM tbl_Stok WHERE Urun_Kullanilabilirlik ='" + 1+ "' AND Urun_Id='" + al + "'");
            secilenUrunId = secilenUr.Tables[0].Rows[0]["Urun_Id"].ToString();
            */
        }
    }
}