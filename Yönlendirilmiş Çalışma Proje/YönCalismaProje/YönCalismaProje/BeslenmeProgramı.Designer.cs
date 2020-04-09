namespace YönCalismaProje
{
    partial class BeslenmeProgramı
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
            this.dataGrid_Uyeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Uyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Uyeler
            // 
            this.dataGrid_Uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Uyeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid_Uyeler.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Uyeler.Name = "dataGrid_Uyeler";
            this.dataGrid_Uyeler.Size = new System.Drawing.Size(936, 160);
            this.dataGrid_Uyeler.TabIndex = 0;
            this.dataGrid_Uyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Uyeler_CellContentClick);
            // 
            // BeslenmeProgramı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 393);
            this.Controls.Add(this.dataGrid_Uyeler);
            this.Name = "BeslenmeProgramı";
            this.Text = "BeslenmeProgramı";
            this.Load += new System.EventHandler(this.BeslenmeProgramı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Uyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Uyeler;
    }
}