namespace ZimmetTakip
{
    partial class PersonelCikar
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
            this.lblPersonel = new System.Windows.Forms.Label();
            this.btnPersonelCikar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonel
            // 
            this.gridPersonel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(12, 16);
            this.gridPersonel.MultiSelect = false;
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.ReadOnly = true;
            this.gridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonel.Size = new System.Drawing.Size(554, 297);
            this.gridPersonel.TabIndex = 0;
            this.gridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonel_CellClick);
            this.gridPersonel.SelectionChanged += new System.EventHandler(this.gridPersonel_SelectionChanged);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPersonel.Location = new System.Drawing.Point(12, 329);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(118, 16);
            this.lblPersonel.TabIndex = 1;
            this.lblPersonel.Text = "Seçilen Personel:";
            // 
            // btnPersonelCikar
            // 
            this.btnPersonelCikar.Location = new System.Drawing.Point(481, 319);
            this.btnPersonelCikar.Name = "btnPersonelCikar";
            this.btnPersonelCikar.Size = new System.Drawing.Size(85, 23);
            this.btnPersonelCikar.TabIndex = 2;
            this.btnPersonelCikar.Text = "Personeli Çıkar";
            this.btnPersonelCikar.Click += new System.EventHandler(this.btnPersonelCikar_Click);
            // 
            // PersonelCikar
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPersonelCikar);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.gridPersonel);
            this.Name = "PersonelCikar";
            this.Size = new System.Drawing.Size(592, 406);
            this.Load += new System.EventHandler(this.PersonelCikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPersonel;
        private System.Windows.Forms.Label lblPersonel;
        private DevExpress.XtraEditors.SimpleButton btnPersonelCikar;
    }
}
