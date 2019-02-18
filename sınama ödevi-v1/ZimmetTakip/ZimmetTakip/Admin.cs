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
        public Admin()
        {
            InitializeComponent();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelOrta.Controls.Clear();
            //PersonelEkle ekle = new PersonelEkle();            
            //panelOrta.Controls.Add(ekle);
            //ekle.Show();
            //ekle.Dock = DockStyle.Fill;
            //ekle.BringToFront();
            PersonelEkle ekle = new PersonelEkle();
            ekle.Show();

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");

        private void Admin_Load(object sender, EventArgs e)
        {
            string getir = "SELECT * FROM tbl_Personel";
            SqlDataAdapter da = new SqlDataAdapter(getir,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPersonel.DataSource = dt;
        }
    }
}