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
using System.Data.SqlClient;
namespace ZimmetTakip
{
    public partial class ZimmetVer : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public ZimmetVer()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");

        private void ZimmetVer_Load(object sender, EventArgs e)
        {
            //baglanti.Open();
            /*SqlCommand departman = new SqlCommand("SELECT Departman_Adi FROM tbl_Departman", baglanti);
            SqlDataReader read = departman.ExecuteReader();
            while (read.Read())
            {
                comboPersonel.Items.Add(read[0]);//Combobox un içine Kategorileri atar
            }*/

            DataSet combo = islem.VeriCekDs("SELECT * FROM tbl_Departman");
            comboPersonel.ValueMember = "Depertman_Id";
            comboPersonel.DisplayMember = "Departman_Adi";
            comboPersonel.DataSource = combo.Tables[0];

            //baglanti.Close();

            
            /*SqlDataAdapter da = new SqlDataAdapter(getir, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPersonel.DataSource = dt;
            */

            DataTable grid = islem.VeriCekDt("SELECT * FROM tbl_Personel");
            gridPersonel.DataSource = grid;


        }
    }
}
