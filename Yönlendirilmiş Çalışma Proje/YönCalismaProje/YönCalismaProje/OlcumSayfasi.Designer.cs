namespace YönCalismaProje
{
    partial class OlcumSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlcumSayfasi));
            this.dataGrid_Uyeler = new System.Windows.Forms.DataGridView();
            this.btn_MenuyeDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Uyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Uyeler
            // 
            this.dataGrid_Uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Uyeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid_Uyeler.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Uyeler.Name = "dataGrid_Uyeler";
            this.dataGrid_Uyeler.Size = new System.Drawing.Size(943, 363);
            this.dataGrid_Uyeler.TabIndex = 1;
            this.dataGrid_Uyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Uyeler_CellContentClick);
            // 
            // btn_MenuyeDon
            // 
            this.btn_MenuyeDon.BackColor = System.Drawing.Color.White;
            this.btn_MenuyeDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_MenuyeDon.Image")));
            this.btn_MenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.Location = new System.Drawing.Point(0, 369);
            this.btn_MenuyeDon.Name = "btn_MenuyeDon";
            this.btn_MenuyeDon.Size = new System.Drawing.Size(128, 30);
            this.btn_MenuyeDon.TabIndex = 71;
            this.btn_MenuyeDon.Text = "Menüye Dön";
            this.btn_MenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuyeDon.UseVisualStyleBackColor = false;
            this.btn_MenuyeDon.Click += new System.EventHandler(this.btn_MenuyeDon_Click);
            // 
            // OlcumSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 401);
            this.Controls.Add(this.btn_MenuyeDon);
            this.Controls.Add(this.dataGrid_Uyeler);
            this.Name = "OlcumSayfasi";
            this.Text = "OlcumSayfasi";
            this.Load += new System.EventHandler(this.OlcumSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Uyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Uyeler;
        private System.Windows.Forms.Button btn_MenuyeDon;
    }
}