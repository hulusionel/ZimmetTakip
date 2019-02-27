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
          
        }
    }
}
