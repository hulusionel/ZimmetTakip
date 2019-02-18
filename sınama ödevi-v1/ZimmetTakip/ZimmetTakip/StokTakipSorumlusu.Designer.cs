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
            this.panelUst = new System.Windows.Forms.Panel();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.btnUrun = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmet = new DevExpress.XtraEditors.SimpleButton();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.btnZimmet);
            this.panelUst.Controls.Add(this.btnUrun);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(620, 77);
            this.panelUst.TabIndex = 0;
            // 
            // panelOrta
            // 
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 77);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(620, 282);
            this.panelOrta.TabIndex = 1;
            // 
            // btnUrun
            // 
            this.btnUrun.Location = new System.Drawing.Point(0, 21);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(133, 56);
            this.btnUrun.TabIndex = 0;
            this.btnUrun.Text = "Ürün Ekle";
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnZimmet
            // 
            this.btnZimmet.Location = new System.Drawing.Point(139, 21);
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.Size = new System.Drawing.Size(133, 56);
            this.btnZimmet.TabIndex = 0;
            this.btnZimmet.Text = "Zimmet Ver";
            this.btnZimmet.Click += new System.EventHandler(this.btnZimmet_Click);
            // 
            // StokTakipSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelUst);
            this.Name = "StokTakipSorumlusu";
            this.Text = "StokTakipSorumlusu";
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraEditors.SimpleButton btnUrun;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraEditors.SimpleButton btnZimmet;
    }
}