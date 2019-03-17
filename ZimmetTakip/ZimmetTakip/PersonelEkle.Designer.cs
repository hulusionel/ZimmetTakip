namespace ZimmetTakip
{
    partial class PersonelEkle
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
            this.comboGorev = new System.Windows.Forms.ComboBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.lblHata = new System.Windows.Forms.Label();
            this.lblHata2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGorev
            // 
            this.comboGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGorev.FormattingEnabled = true;
            this.comboGorev.Location = new System.Drawing.Point(117, 159);
            this.comboGorev.Name = "comboGorev";
            this.comboGorev.Size = new System.Drawing.Size(121, 21);
            this.comboGorev.TabIndex = 23;
            this.comboGorev.SelectedIndexChanged += new System.EventHandler(this.comboGorev_SelectedIndexChanged);
            // 
            // comboDepartman
            // 
            this.comboDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(117, 114);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(121, 21);
            this.comboDepartman.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Görevi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Departmanı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Personel Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Personel Adı:";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(117, 210);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(121, 23);
            this.btnPersonelEkle.TabIndex = 3;
            this.btnPersonelEkle.Text = "Personeli Sisteme Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(118, 79);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Properties.MaxLength = 10;
            this.txtPersonelSoyad.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelSoyad.TabIndex = 2;
            this.txtPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(118, 40);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Properties.MaxLength = 15;
            this.txtPersonelAd.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelAd.TabIndex = 1;
            this.txtPersonelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAd_KeyPress);
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHata.Location = new System.Drawing.Point(244, 43);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 24;
            // 
            // lblHata2
            // 
            this.lblHata2.AutoSize = true;
            this.lblHata2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHata2.Location = new System.Drawing.Point(244, 82);
            this.lblHata2.Name = "lblHata2";
            this.lblHata2.Size = new System.Drawing.Size(0, 13);
            this.lblHata2.TabIndex = 25;
            // 
            // PersonelEkle
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHata2);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.comboGorev);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Name = "PersonelEkle";
            this.Size = new System.Drawing.Size(272, 308);
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGorev;
        private System.Windows.Forms.ComboBox comboDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.TextEdit txtPersonelSoyad;
        private DevExpress.XtraEditors.TextEdit txtPersonelAd;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblHata2;
    }
}
