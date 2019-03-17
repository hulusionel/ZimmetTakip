namespace ZimmetTakip
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUst = new System.Windows.Forms.Panel();
            this.btnPersonelCİkar = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.btnPersonelCİkar);
            this.panelUst.Controls.Add(this.btnListele);
            this.panelUst.Controls.Add(this.btnEkle);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(562, 79);
            this.panelUst.TabIndex = 0;
            // 
            // btnPersonelCİkar
            // 
            this.btnPersonelCİkar.Location = new System.Drawing.Point(224, 22);
            this.btnPersonelCİkar.Name = "btnPersonelCİkar";
            this.btnPersonelCİkar.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelCİkar.TabIndex = 1;
            this.btnPersonelCİkar.Text = "Personel Çıkar";
            this.btnPersonelCİkar.Click += new System.EventHandler(this.btnPersonelCİkar_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(118, 22);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Personel Güncelle";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(37, 22);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelOrta
            // 
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 79);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(562, 299);
            this.panelOrta.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 378);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelUst);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraEditors.SimpleButton btnPersonelCİkar;
    }
}