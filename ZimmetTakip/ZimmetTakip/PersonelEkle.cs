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
    public partial class PersonelEkle : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelSoyad.Text != "")
            {
                string ekleSQL = "INSERT INTO tbl_Personel(Personel_Ad, Personel_Soyad, Departman_Id, Gorev_Id, Calisma_Durumu) VALUES ('" + txtPersonelAd.Text.Trim() + "','" + txtPersonelSoyad.Text.Trim() + "','" + comboDepartman.SelectedValue + "','" + comboGorev.SelectedValue + "','" + 1 + "') ";
                islem.Ekle(ekleSQL, "Personel Sisteme Başarı İle Eklendi.");
                txtPersonelAd.Text = "";
                txtPersonelSoyad.Text = "";
            }
            else
            {

                lblHata.Text = "*";
                lblHata2.Text = "*";
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            DataSet departmanDoldur = islem.VeriCekDs("SELECT * FROM tbl_Departman");
            comboDepartman.ValueMember = "Departman_Id";
            comboDepartman.DisplayMember = "Departman_Adi";
            comboDepartman.DataSource = departmanDoldur.Tables[0];

            DataSet gorevDoldur = islem.VeriCekDs("SELECT * FROM tbl_Gorev");
            comboGorev.ValueMember = "Gorev_Id";
            comboGorev.DisplayMember = "Gorev_Tanimi";
            comboGorev.DataSource = gorevDoldur.Tables[0];
        }

        private void txtPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void comboGorev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
