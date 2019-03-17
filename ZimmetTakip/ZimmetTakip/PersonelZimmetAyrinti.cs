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
    public partial class PersonelZimmetAyrinti : DevExpress.XtraEditors.XtraUserControl
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public static string gelenId;

        public PersonelZimmetAyrinti()
        {
            InitializeComponent();
        }

        private void PersonelZimmetAyrinti_Load(object sender, EventArgs e)
        {
            gelenId = BolumSefi.secilenPersonelId;
            DataTable Personel = islem.VeriCekDt("sp_PersonelZimmetListele '" + Convert.ToInt32(gelenId) + "'");
            gridPersonelZimmet.DataSource = Personel;
            gridPersonelZimmet.AllowUserToAddRows = false;

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            BolumSefi sef = new BolumSefi();
            Form.ActiveForm.Close();
            sef.Show();
        }
    }
}
