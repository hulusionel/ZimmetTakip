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
        public Login()
        {
            InitializeComponent();
           // DataBaseIslemleri db = new DataBaseIslemleri();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=HULUSI\SQLSERVER;Initial Catalog=DemirbasTakip;Integrated Security=True");
        

        private void Login_Load(object sender, EventArgs e) { }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                baglanti.Open();
                string sql = "SELECT * FROM tbl_Personel WHERE Personel_Ad=@adi AND Personel_Id=@Id";
                SqlParameter ad = new SqlParameter("adi", txtName.Text);
                SqlParameter sifre = new SqlParameter("Id", txtPassword.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(ad);
                komut.Parameters.Add(sifre);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                */
                DataTable loginDt = islem.VeriCekDt("SELECT * FROM tbl_Personel WHERE Personel_Ad='" + txtName.Text.Trim() + "' AND Personel_Id='" + txtPassword.Text.Trim() + "'");
                DataSet loginDs = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Ad='" + txtName.Text.Trim() + "' AND Personel_Id='" + txtPassword.Text.Trim() + "'");

                if (loginDt.Rows.Count>0)
                {
                    switch (loginDs.Tables[0].Rows[0]["Gorev_Id"].ToString())
                    {
                        case "1":
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
                                StokTakipSorumlusu stokTakip2 = new StokTakipSorumlusu();
                                stokTakip2.Show();
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
