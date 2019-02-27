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
        //SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");

        private void ZimmetVer_Load(object sender, EventArgs e)
        {
            //baglanti.Open();
            /*SqlCommand departman = new SqlCommand("SELECT Departman_Adi FROM tbl_Departman", baglanti);
            SqlDataReader read = departman.ExecuteReader();
            while (read.Read())
            {
                comboPersonel.Items.Add(read[0]);//Combobox un içine Kategorileri atar
            }*/

            DataSet comboDepartman = islem.VeriCekDs("SELECT * FROM tbl_Departman");
            comboPersonel.ValueMember = "Depertman_Id";
            comboPersonel.DisplayMember = "Departman_Adi";
            comboPersonel.DataSource = comboDepartman.Tables[0];

            DataSet comboUrunKategori = islem.VeriCekDs("SELECT * FROM tbl_Kategori");
            comboUrun.ValueMember = "Kategori_Id";
            comboUrun.DisplayMember = "Kategori_Adi";
            comboUrun.DataSource = comboUrunKategori.Tables[0];

            //baglanti.Close();


            /*SqlDataAdapter da = new SqlDataAdapter(getir, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPersonel.DataSource = dt;
            */

            DataTable gridpersonel = islem.VeriCekDt("SELECT * FROM tbl_Personel");
            gridPersonel.DataSource = gridpersonel;

            DataTable gridUrun = islem.VeriCekDt("SELECT * FROM tbl_Stok");
            gridPersonel.DataSource = gridUrun;
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            if(secilenPersonelId.ToString() !="" && secilenUrunId.ToString() !="")
            {
                string stokKontrol = "SELECT Urun_Adet FROM tbl_Stok WHERE Urun_Id=('" + secilenUrunId + "')";
                DataSet stokKontrolDs = islem.VeriCekDs(stokKontrol);
                int gelen = Convert.ToInt32(stokKontrolDs.Tables[0].Rows[0]["Urun_Adet"]);
                int sonuc = (gelen - Convert.ToInt32(txtZimmetlenecekUrunAdet.Text));

                if (txtZimmetlenecekUrunAdet.Text!="")
                {
                    if (sonuc > 0)
                    {
                        string zimmetleSQL = ("INSERT INTO tbl_Zimmet(Personel_Id, Departman_Id, Urun_Id, Urun_Adet, Zimmetleme_Tarihi) VALUES ('" + secilenPersonelId + "','" + secilenUrunId + "','" + secilenPersonelDepartmanId + "','" + Convert.ToInt32(txtZimmetlenecekUrunAdet.Text.Trim()) + "','" + Convert.ToDateTime(DateTime.Now) + "') ");
                        string zimmetStokGuncelle = "";
                        //TODO: Stoktan adet düşme için güncelleme yapılacak ama adeti kotrol etmek lazım!!!!

                        islem.Guncelle(zimmetStokGuncelle);
                        islem.Ekle(zimmetleSQL, "Ürün Zİmmetleme İşlemi Başarı İle Yapıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Stok Sayısı Yeterli Değildir!");
                    }
                }
                else if(txtZimmetlenecekUrunAdet.Text=="")
                {
                    if ((gelen - 1) > 0)
                    {
                        string zimmetleSQL = ("INSERT INTO tbl_Zimmet(Personel_Id, Departman_Id, Urun_Id, Urun_Adet, Zimmetleme_Tarihi) VALUES ('" + secilenPersonelId + "','" + secilenUrunId + "','" + secilenPersonelDepartmanId + "','" + 1 + "','" + Convert.ToDateTime(DateTime.Now) + "') ");
                        string zimmetStokGuncelle = "";
                        //TODO: Stoktan adet düşme için güncelleme yapılacak ama adeti kotrol etmek lazım!!!!

                        islem.Guncelle(zimmetStokGuncelle);
                        islem.Ekle(zimmetleSQL, "Ürün Zİmmetleme İşlemi Başarı İle Yapıldı.");
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

        public static int secilenPersonelId, secilenPersonelDepartmanId, secilenUrunId;

        private void comboPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable gridpersonel = islem.VeriCekDt("SELECT * FROM tbl_Personel WHERE Personel_Id=('" + Convert.ToInt32(comboPersonel.SelectedValue) + "')");
            gridPersonel.DataSource = gridpersonel;
        }

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable gridUrun = islem.VeriCekDt("SELECT * FROM tbl_Stok WHERE Urun_Adet>0 AND Kategori_Id=('" + Convert.ToInt32(comboUrun.SelectedValue) + "')");
            gridPersonel.DataSource = gridUrun;
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            secilenPersonelId =Convert.ToInt32(gridPersonel.CurrentRow.Cells[1].Value);
            secilenPersonelDepartmanId = Convert.ToInt32(gridPersonel.CurrentRow.Cells[4].Value);
            lblSecilenPersonel.Text = lblSecilenPersonel.Text + gridPersonel.CurrentRow.Cells[2].ToString();
        }

        private void gridUrun_SelectionChanged(object sender, EventArgs e)
        {
            secilenUrunId = Convert.ToInt32(gridUrun.CurrentRow.Cells[1].Value);
            lblSecilenUrun.Text = lblSecilenUrun.Text + gridUrun.CurrentRow.Cells[2].ToString();
        }
    }
}