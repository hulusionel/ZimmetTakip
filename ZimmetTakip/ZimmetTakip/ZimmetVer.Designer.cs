namespace ZimmetTakip
{
    partial class ZimmetVer
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
            this.comboPersonel = new System.Windows.Forms.ComboBox();
            this.gridPersonel = new System.Windows.Forms.DataGridView();
            this.btnZimmet = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUrun = new System.Windows.Forms.ComboBox();
            this.gridUrun = new System.Windows.Forms.DataGridView();
            this.lblSecilenPersonel = new System.Windows.Forms.Label();
            this.lblSecilenUrun = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZimmetlenecekUrunAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seç:";
            // 
            // comboPersonel
            // 
            this.comboPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Location = new System.Drawing.Point(131, 13);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(121, 21);
            this.comboPersonel.TabIndex = 1;
            this.comboPersonel.SelectedIndexChanged += new System.EventHandler(this.comboPersonel_SelectedIndexChanged);
            // 
            // gridPersonel
            // 
            this.gridPersonel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(11, 47);
            this.gridPersonel.MultiSelect = false;
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.ReadOnly = true;
            this.gridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonel.Size = new System.Drawing.Size(560, 156);
            this.gridPersonel.TabIndex = 2;
            this.gridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonel_CellClick);
            this.gridPersonel.SelectionChanged += new System.EventHandler(this.gridPersonel_SelectionChanged);
            // 
            // btnZimmet
            // 
            this.btnZimmet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmet.Appearance.Options.UseFont = true;
            this.btnZimmet.Location = new System.Drawing.Point(983, 213);
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.Size = new System.Drawing.Size(82, 36);
            this.btnZimmet.TabIndex = 3;
            this.btnZimmet.Text = "Zimmetle";
            this.btnZimmet.Click += new System.EventHandler(this.btnZimmet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(616, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Kategori:";
            // 
            // comboUrun
            // 
            this.comboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUrun.FormattingEnabled = true;
            this.comboUrun.Location = new System.Drawing.Point(718, 11);
            this.comboUrun.Name = "comboUrun";
            this.comboUrun.Size = new System.Drawing.Size(121, 21);
            this.comboUrun.TabIndex = 1;
            this.comboUrun.SelectedIndexChanged += new System.EventHandler(this.comboUrun_SelectedIndexChanged);
            // 
            // gridUrun
            // 
            this.gridUrun.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrun.Location = new System.Drawing.Point(609, 47);
            this.gridUrun.MultiSelect = false;
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.ReadOnly = true;
            this.gridUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrun.Size = new System.Drawing.Size(466, 131);
            this.gridUrun.TabIndex = 2;
            this.gridUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrun_CellClick);
            this.gridUrun.SelectionChanged += new System.EventHandler(this.gridUrun_SelectionChanged);
            // 
            // lblSecilenPersonel
            // 
            this.lblSecilenPersonel.AutoSize = true;
            this.lblSecilenPersonel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenPersonel.Location = new System.Drawing.Point(8, 219);
            this.lblSecilenPersonel.Name = "lblSecilenPersonel";
            this.lblSecilenPersonel.Size = new System.Drawing.Size(118, 16);
            this.lblSecilenPersonel.TabIndex = 4;
            this.lblSecilenPersonel.Text = "Seçilen Personel:";
            // 
            // lblSecilenUrun
            // 
            this.lblSecilenUrun.AutoSize = true;
            this.lblSecilenUrun.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenUrun.Location = new System.Drawing.Point(629, 205);
            this.lblSecilenUrun.Name = "lblSecilenUrun";
            this.lblSecilenUrun.Size = new System.Drawing.Size(92, 16);
            this.lblSecilenUrun.TabIndex = 4;
            this.lblSecilenUrun.Text = "Seçilen Ürün:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(629, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zimmetlenecek Ürün Adedi:";
            // 
            // txtZimmetlenecekUrunAdet
            // 
            this.txtZimmetlenecekUrunAdet.Location = new System.Drawing.Point(818, 228);
            this.txtZimmetlenecekUrunAdet.MaxLength = 3;
            this.txtZimmetlenecekUrunAdet.Name = "txtZimmetlenecekUrunAdet";
            this.txtZimmetlenecekUrunAdet.Size = new System.Drawing.Size(78, 21);
            this.txtZimmetlenecekUrunAdet.TabIndex = 5;
            this.txtZimmetlenecekUrunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZimmetlenecekUrunAdet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(629, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(boş bırakıldığında varsayılan olarak 1 belirlenir)";
            // 
            // ZimmetVer
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtZimmetlenecekUrunAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSecilenUrun);
            this.Controls.Add(this.lblSecilenPersonel);
            this.Controls.Add(this.btnZimmet);
            this.Controls.Add(this.gridUrun);
            this.Controls.Add(this.gridPersonel);
            this.Controls.Add(this.comboUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPersonel);
            this.Controls.Add(this.label1);
            this.Name = "ZimmetVer";
            this.Size = new System.Drawing.Size(1132, 348);
            this.Load += new System.EventHandler(this.ZimmetVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPersonel;
        private System.Windows.Forms.DataGridView gridPersonel;
        private DevExpress.XtraEditors.SimpleButton btnZimmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboUrun;
        private System.Windows.Forms.DataGridView gridUrun;
        private System.Windows.Forms.Label lblSecilenPersonel;
        private System.Windows.Forms.Label lblSecilenUrun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZimmetlenecekUrunAdet;
        private System.Windows.Forms.Label label3;
    }
}
