﻿namespace ZimmetTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panelUst = new System.Windows.Forms.Panel();
            this.btnPersonelCİkar = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.simpleButton1);
            this.panelUst.Controls.Add(this.btnPersonelCİkar);
            this.panelUst.Controls.Add(this.btnListele);
            this.panelUst.Controls.Add(this.btnEkle);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(795, 55);
            this.panelUst.TabIndex = 0;
            // 
            // btnPersonelCİkar
            // 
            this.btnPersonelCİkar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnPersonelCİkar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelCİkar.ImageOptions.Image")));
            this.btnPersonelCİkar.Location = new System.Drawing.Point(256, 1);
            this.btnPersonelCİkar.Name = "btnPersonelCİkar";
            this.btnPersonelCİkar.Size = new System.Drawing.Size(117, 54);
            this.btnPersonelCİkar.TabIndex = 1;
            this.btnPersonelCİkar.Text = "Personel Çıkar";
            this.btnPersonelCİkar.Click += new System.EventHandler(this.btnPersonelCİkar_Click);
            // 
            // btnListele
            // 
            this.btnListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(124, 1);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(132, 54);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Personel Güncelle";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(1, 1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 55);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(795, 366);
            this.panelOrta.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(756, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraEditors.SimpleButton btnPersonelCİkar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}