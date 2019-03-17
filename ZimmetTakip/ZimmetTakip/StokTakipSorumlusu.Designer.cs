namespace ZimmetTakip
{
    partial class StokTakipSorumlusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokTakipSorumlusu));
            this.panelUst = new System.Windows.Forms.Panel();
            this.btnZimmet = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrun = new DevExpress.XtraEditors.SimpleButton();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.simpleButton1);
            this.panelUst.Controls.Add(this.btnZimmet);
            this.panelUst.Controls.Add(this.btnUrun);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1105, 59);
            this.panelUst.TabIndex = 0;
            // 
            // btnZimmet
            // 
            this.btnZimmet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnZimmet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmet.ImageOptions.Image")));
            this.btnZimmet.Location = new System.Drawing.Point(135, 1);
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.Size = new System.Drawing.Size(133, 58);
            this.btnZimmet.TabIndex = 0;
            this.btnZimmet.Text = "Zimmet Ver";
            this.btnZimmet.Click += new System.EventHandler(this.btnZimmet_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrun.ImageOptions.Image")));
            this.btnUrun.Location = new System.Drawing.Point(2, 1);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(133, 58);
            this.btnUrun.TabIndex = 0;
            this.btnUrun.Text = "Ürün Ekle";
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 59);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(1105, 300);
            this.panelOrta.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1067, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 35);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // StokTakipSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 359);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokTakipSorumlusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokTakipSorumlusu";
            this.Load += new System.EventHandler(this.StokTakipSorumlusu_Load);
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraEditors.SimpleButton btnUrun;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraEditors.SimpleButton btnZimmet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}