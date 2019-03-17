namespace ZimmetTakip
{
    partial class UrunEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(113, 109);
            this.txtMarka.MaxLength = 10;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 21);
            this.txtMarka.TabIndex = 1;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // comboKategori
            // 
            this.comboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(113, 45);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 21);
            this.comboKategori.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(113, 136);
            this.txtModel.MaxLength = 10;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 21);
            this.txtModel.TabIndex = 1;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(113, 163);
            this.txtFiyat.MaxLength = 5;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 21);
            this.txtFiyat.TabIndex = 1;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(113, 190);
            this.txtAdet.MaxLength = 3;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 21);
            this.txtAdet.TabIndex = 1;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(113, 243);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunEkle";
            this.Size = new System.Drawing.Size(296, 326);
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdet;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
    }
}
