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
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.btnListele);
            this.panelUst.Controls.Add(this.btnEkle);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(503, 100);
            this.panelUst.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(155, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(88, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Personel Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(53, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelOrta
            // 
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 100);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(503, 236);
            this.panelOrta.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 336);
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
    }
}