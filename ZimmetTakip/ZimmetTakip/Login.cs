using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ZimmetTakip
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public static string gonderilenDepartmanId, gonderilenPersonelId;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e) { }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            try
            {
                DataTable loginDt = islem.VeriCekDt("SELECT * FROM tbl_Personel WHERE Personel_Ad='" + txtName.Text.Trim() + "' AND Personel_Id='" + txtPassword.Text.Trim() + "'");
                DataSet loginDs = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Ad='" + txtName.Text.Trim() + "' AND Personel_Id='" + txtPassword.Text.Trim() + "'");

                if (loginDt.Rows.Count>0)
                {
                    switch (loginDs.Tables[0].Rows[0]["Gorev_Id"].ToString())
                    {
                        case "1":
                            gonderilenPersonelId = loginDs.Tables[0].Rows[0]["Personel_Id"].ToString();
                            Admin admin = new Admin();
                            admin.Show();
                            break;
                        case "2":
                            //TODO:Satın alma departmanı ise gidilecek sayfa
                            if (Convert.ToUInt32(loginDs.Tables[0].Rows[0]["Departman_Id"].ToString()) == 3)
                            {
                                StokTakipSorumlusu stokTakip = new StokTakipSorumlusu();
                                stokTakip.Show();
                                
                            }
                            else
                            {
                                //TODO:Satın alma departmanı değilse gidilecek sayfa
                                gonderilenDepartmanId = loginDs.Tables[0].Rows[0]["Departman_Id"].ToString();
                                gonderilenPersonelId= loginDs.Tables[0].Rows[0]["Personel_Id"].ToString();
                                BolumSefi sef = new BolumSefi();
                                sef.Show();
                            }
                            break;
                        case "3":
                            //çalışan
                            break;                   
                    }                
                }
            }
            catch { }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
