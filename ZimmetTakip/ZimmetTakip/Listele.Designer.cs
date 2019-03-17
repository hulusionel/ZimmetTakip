namespace ZimmetTakip
{
    partial class Listele
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPersonel = new System.Windows.Forms.DataGridView();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.comboPersonelDepartman = new System.Windows.Forms.ComboBox();
            this.comboPersonelGorev = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonel
            // 
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(15, 14);
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.Size = new System.Drawing.Size(558, 314);
            this.gridPersonel.TabIndex = 0;
            this.gridPersonel.SelectionChanged += new System.EventHandler(this.gridPersonel_SelectionChanged);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(614, 14);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(121, 21);
            this.txtPersonelAd.TabIndex = 1;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(614, 59);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(121, 21);
            this.txtPersonelSoyad.TabIndex = 1;
            // 
            // comboPersonelDepartman
            // 
            this.comboPersonelDepartman.FormattingEnabled = true;
            this.comboPersonelDepartman.Location = new System.Drawing.Point(614, 99);
            this.comboPersonelDepartman.Name = "comboPersonelDepartman";
            this.comboPersonelDepartman.Size = new System.Drawing.Size(121, 21);
            this.comboPersonelDepartman.TabIndex = 2;
            // 
            // comboPersonelGorev
            // 
            this.comboPersonelGorev.FormattingEnabled = true;
            this.comboPersonelGorev.Location = new System.Drawing.Point(614, 143);
            this.comboPersonelGorev.Name = "comboPersonelGorev";
            this.comboPersonelGorev.Size = new System.Drawing.Size(121, 21);
            this.comboPersonelGorev.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(614, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(121, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Personel Bilgisi Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.comboPersonelGorev);
            this.Controls.Add(this.comboPersonelDepartman);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.gridPersonel);
            this.Name = "Listele";
            this.Size = new System.Drawing.Size(773, 350);
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPersonel;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.ComboBox comboPersonelDepartman;
        private System.Windows.Forms.ComboBox comboPersonelGorev;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
