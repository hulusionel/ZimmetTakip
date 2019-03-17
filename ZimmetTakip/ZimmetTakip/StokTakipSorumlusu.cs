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
    public partial class StokTakipSorumlusu : DevExpress.XtraEditors.XtraForm
    {
        public StokTakipSorumlusu()
        {
            InitializeComponent();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            UrunEkle urunEkle = new UrunEkle();
            panelOrta.Controls.Add(urunEkle);
            urunEkle.Show();
            urunEkle.Dock = DockStyle.Fill;
            urunEkle.BringToFront();
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            ZimmetVer zimmet = new ZimmetVer();
            panelOrta.Controls.Add(zimmet);
            zimmet.Show();
            zimmet.Dock = DockStyle.Fill;
            zimmet.BringToFront();
        }

        private void StokTakipSorumlusu_Load(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            ZimmetVer zimmet = new ZimmetVer();
            panelOrta.Controls.Add(zimmet);
            zimmet.Show();
            zimmet.Dock = DockStyle.Fill;
            zimmet.BringToFront();
        }
    }
}