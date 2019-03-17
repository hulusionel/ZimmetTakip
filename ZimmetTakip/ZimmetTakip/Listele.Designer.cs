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
            this.lblHata = new System.Windows.Forms.Label();
            this.lblHata2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonel
            // 
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(15, 14);
            this.gridPersonel.MultiSelect = false;
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.ReadOnly = true;
            this.gridPersonel.RowHeadersVisible = false;
            this.gridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonel.Size = new System.Drawing.Size(558, 314);
            this.gridPersonel.TabIndex = 0;
            this.gridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonel_CellClick);
            this.gridPersonel.SelectionChanged += new System.EventHandler(this.gridPersonel_SelectionChanged);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(614, 14);
            this.txtPersonelAd.MaxLength = 15;
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(121, 21);
            this.txtPersonelAd.TabIndex = 1;
            this.txtPersonelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAd_KeyPress);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(614, 59);
            this.txtPersonelSoyad.MaxLength = 10;
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(121, 21);
            this.txtPersonelSoyad.TabIndex = 1;
            this.txtPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // comboPersonelDepartman
            // 
            this.comboPersonelDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonelDepartman.FormattingEnabled = true;
            this.comboPersonelDepartman.Location = new System.Drawing.Point(614, 99);
            this.comboPersonelDepartman.Name = "comboPersonelDepartman";
            this.comboPersonelDepartman.Size = new System.Drawing.Size(121, 21);
            this.comboPersonelDepartman.TabIndex = 2;
            // 
            // comboPersonelGorev
            // 
            this.comboPersonelGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(742, 21);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 4;
            // 
            // lblHata2
            // 
            this.lblHata2.AutoSize = true;
            this.lblHata2.ForeColor = System.Drawing.Color.Red;
            this.lblHata2.Location = new System.Drawing.Point(742, 62);
            this.lblHata2.Name = "lblHata2";
            this.lblHata2.Size = new System.Drawing.Size(0, 13);
            this.lblHata2.TabIndex = 5;
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHata2);
            this.Controls.Add(this.lblHata);
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
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblHata2;
    }
}
