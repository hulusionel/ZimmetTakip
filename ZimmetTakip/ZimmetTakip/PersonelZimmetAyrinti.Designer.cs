namespace ZimmetTakip
{
    partial class PersonelZimmetAyrinti
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
            this.gridPersonelZimmet = new System.Windows.Forms.DataGridView();
            this.btnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonelZimmet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonelZimmet
            // 
            this.gridPersonelZimmet.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPersonelZimmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonelZimmet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPersonelZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonelZimmet.Location = new System.Drawing.Point(3, 42);
            this.gridPersonelZimmet.MultiSelect = false;
            this.gridPersonelZimmet.Name = "gridPersonelZimmet";
            this.gridPersonelZimmet.ReadOnly = true;
            this.gridPersonelZimmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonelZimmet.Size = new System.Drawing.Size(549, 250);
            this.gridPersonelZimmet.TabIndex = 0;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(21, 13);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 23);
            this.btnRapor.TabIndex = 1;
            this.btnRapor.Text = "Rapor Al";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(451, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(77, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // PersonelZimmetAyrinti
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.gridPersonelZimmet);
            this.Name = "PersonelZimmetAyrinti";
            this.Size = new System.Drawing.Size(568, 361);
            this.Load += new System.EventHandler(this.PersonelZimmetAyrinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonelZimmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPersonelZimmet;
        private DevExpress.XtraEditors.SimpleButton btnRapor;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
    }
}
