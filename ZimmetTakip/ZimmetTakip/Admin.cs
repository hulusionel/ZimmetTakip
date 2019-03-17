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
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          

            panelOrta.Controls.Clear();
            PersonelEkle ekle = new PersonelEkle();
            panelOrta.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            panelOrta.Controls.Clear();
            Listele ekle = new Listele();
            panelOrta.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
        }

        private void btnPersonelCİkar_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            PersonelCikar cikar = new PersonelCikar();
            panelOrta.Controls.Add(cikar);
            cikar.Show();
            cikar.Dock = DockStyle.Fill;
        }
    }
}