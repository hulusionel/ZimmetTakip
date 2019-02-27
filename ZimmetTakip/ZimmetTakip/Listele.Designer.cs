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
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonel
            // 
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Location = new System.Drawing.Point(15, 14);
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.Size = new System.Drawing.Size(485, 304);
            this.gridPersonel.TabIndex = 0;
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPersonel);
            this.Name = "Listele";
            this.Size = new System.Drawing.Size(515, 336);
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPersonel;
    }
}
