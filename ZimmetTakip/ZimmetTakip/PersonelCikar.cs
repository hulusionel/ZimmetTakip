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

namespace ZimmetTakip
{
    public partial class PersonelCikar : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public static string gelenId;

        public PersonelCikar()
        {
            InitializeComponent();
        }

        private void PersonelCikar_Load(object sender, EventArgs e)
        {
            gelenId = Login.gonderilenPersonelId;
            DataTable goruntule = islem.VeriCekDt("sp_PersonelCikarListele "+gelenId+"");//prosedür ile kendisi dışındaki personellerin listelenmesi sağlandı
            gridPersonel.DataSource = goruntule;//kendi dışındakiler grid ekranına eklendi
            gridPersonel.AllowUserToAddRows = false;//gridin en alttaki boş satırı kapatıldı
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            //lblPersonel.Text="Seçilen Personel: "+gridPersonel.CurrentRow.Cells[1].Value.ToString() +" "+ gridPersonel.CurrentRow.Cells[2].Value.ToString();//alttaki labele çıkarılmak için seçilen personel ismi yazıldı
        }

        private void btnPersonelCikar_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Devam etmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo);
            //seçilen personelin çıkarılma işlemi için ikinci bir onay istendi
            if (sil == DialogResult.Yes)
            {
                //TODO: İŞLEMLER GELECEK
                DataTable kontrol = islem.VeriCekDt("SELECT * FROM tbl_Zimmet WHERE Personel_Id='" + gridPersonel.CurrentRow.Cells[0].Value + "'");
                //Çıkarılacak personelin üzerinde zimmet varmı yokmu kontrol edildi
                if (kontrol.Rows.Count > 0)//zimmet var ise parçalar tekrar depoya eklendi
                {
                    
                    //TODO:Zimmetleri stok a at
                    //string stokTabloGuncelle = "UPDATE tbl_Stok SET   Urun_Adet='" +  + "'WHERE Urun_Id='" + Convert.ToInt32() + "'";
                    //islem.Guncelle(stokTabloGuncelle);
                   
                }
                else if (kontrol.Rows.Count < 0)//personel üzerinde zimmet yok ise çıkarılma islemi gerçekleştirildi
                {
                    //TODO: Direkt personeli sistemden sil
                }
                MessageBox.Show("Personel Silindi (MESELA YAANİ)");
            }
            
        }

        private void gridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            { 
                lblPersonel.Text = "Seçilen Personel: " + gridPersonel.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + gridPersonel.Rows[e.RowIndex].Cells[2].Value.ToString();//alttaki labele çıkarılmak için seçilen personel ismi yazıldı
            }
        }
    }
}
