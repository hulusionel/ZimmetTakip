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
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ZimmetTakip
{
    public partial class PersonelEkle : DevExpress.XtraEditors.XtraUserControl
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");
        //bağlantıyı yaptık
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand depratman = new SqlCommand("SELECT * FROM tbl_Departman", baglanti);
            SqlCommand Gorev = new SqlCommand("SELECT * FROM tbl_Gorev", baglanti);
            SqlDataReader readD = depratman.ExecuteReader();
            SqlDataReader readG = Gorev.ExecuteReader();
            while (readD.Read())
            {
                comboDepartman.Items.Add(readD[1]);//Combobox un içine Departmanları atar
            }
            while (readG.Read())
            {
                comboDepartman.Items.Add(readG[1]);//Combobox un içine görevleri atar
            }
            baglanti.Close();
        }
    }
}
