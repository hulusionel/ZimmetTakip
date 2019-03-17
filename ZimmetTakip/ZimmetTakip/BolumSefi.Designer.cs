namespace ZimmetTakip
{
    partial class BolumSefi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BolumSefi));
            this.btnRaporAl = new DevExpress.XtraEditors.SimpleButton();
            this.gridPersonel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.panelUst = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.panelOrta.SuspendLayout();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(6, 7);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(75, 23);
            this.btnRaporAl.TabIndex = 0;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // gridPersonel
            // 
            this.gridPersonel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(6, 35);
            this.gridPersonel.MultiSelect = false;
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.ReadOnly = true;
            this.gridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonel.Size = new System.Drawing.Size(546, 228);
            this.gridPersonel.TabIndex = 1;
            this.gridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonel_CellClick);
            this.gridPersonel.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPersonel_CellMouseDoubleClick);
            this.gridPersonel.SelectionChanged += new System.EventHandler(this.gridPersonel_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departman:";
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDepartmanAdi.Location = new System.Drawing.Point(100, 40);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(46, 16);
            this.lblDepartmanAdi.TabIndex = 3;
            this.lblDepartmanAdi.Text = "label2";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPersonel.Location = new System.Drawing.Point(17, 10);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(80, 16);
            this.lblPersonel.TabIndex = 2;
            this.lblPersonel.Text = "Hoşgeldiniz";
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOrta.Controls.Add(this.gridPersonel);
            this.panelOrta.Controls.Add(this.btnRaporAl);
            this.panelOrta.Location = new System.Drawing.Point(0, 63);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(697, 393);
            this.panelOrta.TabIndex = 4;
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUst.Controls.Add(this.simpleButton1);
            this.panelUst.Controls.Add(this.lblPersonel);
            this.panelUst.Controls.Add(this.label1);
            this.panelUst.Controls.Add(this.lblDepartmanAdi);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(697, 67);
            this.panelUst.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(656, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 35);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BolumSefi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 365);
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.panelOrta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BolumSefi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BolumSefi";
            this.Load += new System.EventHandler(this.BolumSefi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.panelOrta.ResumeLayout(false);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRaporAl;
        private System.Windows.Forms.DataGridView gridPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}