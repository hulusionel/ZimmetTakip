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
            DataTable goruntule = islem.VeriCekDt("sp_PersonelCikarListele "+gelenId+"");
            gridPersonel.DataSource = goruntule;
            gridPersonel.AllowUserToAddRows = false;
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            lblPersonel.Text="Seçilen Personel: "+gridPersonel.CurrentRow.Cells[1].Value.ToString() +" "+ gridPersonel.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnPersonelCikar_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Devam etmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (sil == DialogResult.Yes)
            {
                //TODO: İŞLEMLER GELECEK
                DataTable kontrol = islem.VeriCekDt("SELECT * FROM tbl_Zimmet WHERE Personel_Id='" + gridPersonel.CurrentRow.Cells[0].Value + "'");
                if (kontrol.Rows.Count > 0)
                {
                    //TODO:Zimmetleri stok a at


                }
                else if (kontrol.Rows.Count < 0)
                {
                    //TODO: Direkt personeli sistemden sil

                }
                MessageBox.Show("Personel Silindi (MESELA YAANİ)");
            }
            
        }
    }
}
