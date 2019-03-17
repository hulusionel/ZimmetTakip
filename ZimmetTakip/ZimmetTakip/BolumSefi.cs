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
    public partial class BolumSefi : DevExpress.XtraEditors.XtraForm
    {
        DataBaseIslemleri islem = new DataBaseIslemleri();
        public static string gelenDepartmanId,gelenPersonelId,secilenPersonelId;
        public BolumSefi()
        {
            InitializeComponent();
        }


        private void BolumSefi_Load(object sender, EventArgs e)
        {
            gelenDepartmanId = Login.gonderilenDepartmanId;
            gelenPersonelId = Login.gonderilenPersonelId;

            DataTable Personel = islem.VeriCekDt("sp_BolumSefPersonelListele "+ gelenDepartmanId + "");
            DataSet Bilgi = islem.VeriCekDs("SELECT * FROM tbl_Personel WHERE Personel_Id='" + Convert.ToInt32(gelenPersonelId) + "'");

            lblPersonel.Text = "Hoşgeldiniz: " + Bilgi.Tables[0].Rows[0]["Personel_Ad"].ToString()+" "+ Bilgi.Tables[0].Rows[0]["Personel_Soyad"].ToString();
            gridPersonel.DataSource = Personel;
            gridPersonel.AllowUserToAddRows = false;

            lblDepartmanAdi.Text = Personel.Rows[0][3].ToString();
        }

        private void gridPersonel_SelectionChanged(object sender, EventArgs e)
        {
            secilenPersonelId = gridPersonel.CurrentRow.Cells[0].Value.ToString();
        }

        private void gridPersonel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            panelOrta.Controls.Clear();
            PersonelZimmetAyrinti zimmetAyrinti = new PersonelZimmetAyrinti();
            panelOrta.Controls.Add(zimmetAyrinti);
            zimmetAyrinti.Show();
            zimmetAyrinti.Dock = DockStyle.Fill;
            zimmetAyrinti.BringToFront();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
        //    //Creating iTextSharp Table from the DataTable data
        //    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
        //    pdfTable.DefaultCell.Padding = 3;
        //    pdfTable.WidthPercentage = 30;
        //    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    pdfTable.DefaultCell.BorderWidth = 1;

        //    //Adding Header row
        //    foreach (DataGridViewColumn column in dataGridView1.Columns)
        //    {
        //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
        //        pdfTable.AddCell(cell);
        //    }

        //    //Adding DataRow
        //    //foreach (DataGridViewRow row in dataGridView1.Rows)
        //    //{
        //    //    foreach (DataGridViewCell cell in row.Cells)
        //    //    {
        //    //        pdfTable.AddCell(cell.Value.ToString());
        //    //    }
        //    //}
        //    int row = dataGridView1.Rows.Count;
        //    int cell2 = dataGridView1.Rows[1].Cells.Count;
        //    for (int i = 0; i < row - 1; i++)
        //    {
        //        for (int j = 0; j < cell2; j++)
        //        {
        //            if (dataGridView1.Rows[i].Cells[j].Value == null)
        //            {
        //                //return directly
        //                //return;
        //                //or set a value for the empty data
        //                dataGridView1.Rows[i].Cells[j].Value = "null";
        //            }
        //            pdfTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
        //        }
        //    }

        //    //Exporting to PDF
        //    string folderPath = @"D:\Log\";
        //    if (!Directory.Exists(folderPath))
        //    {
        //        Directory.CreateDirectory(folderPath);
        //    }
        //    using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
        //    {
        //        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
        //        PdfWriter.GetInstance(pdfDoc, stream);
        //        pdfDoc.Open();
        //        pdfDoc.Add(pdfTable);
        //        pdfDoc.Close();
        //        stream.Close();
        //    }
        //    MessageBox.Show("Done");
        }
    }
}