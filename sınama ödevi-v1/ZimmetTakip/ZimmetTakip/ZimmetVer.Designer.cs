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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridUrun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seç:";
            // 
            // comboPersonel
            // 
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Location = new System.Drawing.Point(157, 30);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(121, 21);
            this.comboPersonel.TabIndex = 1;
            // 
            // gridPersonel
            // 
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(11, 70);
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.Size = new System.Drawing.Size(564, 118);
            this.gridPersonel.TabIndex = 2;
            // 
            // btnZimmet
            // 
            this.btnZimmet.Location = new System.Drawing.Point(500, 427);
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.Size = new System.Drawing.Size(75, 30);
            this.btnZimmet.TabIndex = 3;
            this.btnZimmet.Text = "Zimmetle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Kategori:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // gridUrun
            // 
            this.gridUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrun.Location = new System.Drawing.Point(11, 274);
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.Size = new System.Drawing.Size(564, 118);
            this.gridUrun.TabIndex = 2;
            // 
            // ZimmetVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZimmet);
            this.Controls.Add(this.gridUrun);
            this.Controls.Add(this.gridPersonel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPersonel);
            this.Controls.Add(this.label1);
            this.Name = "ZimmetVer";
            this.Size = new System.Drawing.Size(620, 489);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridUrun;
    }
}
