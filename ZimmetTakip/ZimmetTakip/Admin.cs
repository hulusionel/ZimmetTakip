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
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZimmetTakip
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {           
            DataTable goruntule=islem.VeriCekDt("SELECT * FROM v_PersonelListele");
            gridPersonel.DataSource = goruntule;

        }
    
        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle ekle = new PersonelEkle();
            ekle.Show();
            //ekle.Parent = this;
            //ekle.ShowDialog();


           /* panelOrta.Controls.Clear();
            PersonelEkle ekle = new PersonelEkle();
            panelOrta.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();*/
        }
    }
}