using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ZimmetTakip
{
    public partial class BolumSefi : DevExpress.XtraEditors.XtraForm
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public static string gelenDepartmanId,gelenPersonelId,secilenPersonelId;
        public BolumSefi()
        {
            InitializeComponent();
        }


        private void BolumSefi_Load(object sender, EventArgs e)
        {
            gelenDepartmanId = Login.gonderilenDepartmanId;
            gelenPersonelId = Login.gonderilenPersonelId;

            DataTable Personel = islem.VeriCekDt("sp_BolumSefPersonelListele "+ gelenDepartmanId + "");
            DataSet Bilgi = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Id='" + Convert.ToInt32(gelenPersonelId) + "'");

            lblPersonel.Text = "Hoşgeldiniz: " + Bilgi.Tables[0].Rows[0]["Personel_Ad"].ToString()+" "+ Bilgi.Tables[0].Rows[0]["Personel_Soyad"].ToString();
            gridPersonel.DataSource = Personel;
            gridPersonel.AllowUserToAddRows = false;

            lblDepartmanAdi.Text = Personel.Rows[0][3].ToString();
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            secilenPersonelId = gridPersonel.CurrentRow.Cells[0].Value.ToString();
        }

        private void gridPersonel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            panelOrta.Controls.Clear();
            PersonelZimmetAyrinti zimmetAyrinti = new PersonelZimmetAyrinti();
            panelOrta.Controls.Add(zimmetAyrinti);
            zimmetAyrinti.Show();
            zimmetAyrinti.Dock = DockStyle.Fill;
            zimmetAyrinti.BringToFront();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
          
        }
    }
}