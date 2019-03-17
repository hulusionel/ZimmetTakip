﻿using System;
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
    public partial class Listele : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            DataTable goruntule = islem.VeriCekDt("SELECT * FROM v_PersonelListele");
            gridPersonel.DataSource = goruntule;
            gridPersonel.AllowUserToAddRows = false;

            DataSet departmanDoldur = islem.VeriCekDs("SELECT * FROM tbl_Departman");
            comboPersonelDepartman.ValueMember = "Departman_Id";
            comboPersonelDepartman.DisplayMember = "Departman_Adi";
            comboPersonelDepartman.DataSource = departmanDoldur.Tables[0];

            DataSet gorevDoldur = islem.VeriCekDs("SELECT * FROM tbl_Gorev");
            comboPersonelGorev.ValueMember = "Gorev_Id";
            comboPersonelGorev.DisplayMember = "Gorev_Tanimi";
            comboPersonelGorev.DataSource = gorevDoldur.Tables[0];

        }
        public static string secilenId;

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            txtPersonelAd.Text = gridPersonel.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = gridPersonel.CurrentRow.Cells[2].Value.ToString();
            secilenId = gridPersonel.CurrentRow.Cells[0].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string PersonelGuncelle = "UPDATE tbl_Personel SET Personel_Ad='" + txtPersonelAd.Text.Trim() + "', Personel_Soyad='"+txtPersonelSoyad.Text.Trim()+"', Departman_Id='"+comboPersonelDepartman.SelectedValue+"', Gorev_Id='"+comboPersonelGorev.SelectedValue+"'WHERE Personel_Id='" + Convert.ToInt32(secilenId) + "'";
            islem.Guncelle(PersonelGuncelle);
            MessageBox.Show("Personel Başarı İle Güncellendi.");
            DataTable goruntule = islem.VeriCekDt("SELECT * FROM v_PersonelListele");
            gridPersonel.DataSource = goruntule;
            gridPersonel.AllowUserToAddRows = false;
        }
    }
}
