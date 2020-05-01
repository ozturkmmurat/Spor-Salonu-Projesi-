namespace YönCalismaProje
{
    partial class UyeSilmeBolumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeSilmeBolumu));
            this.dataGridUyeSilme = new System.Windows.Forms.DataGridView();
            this.txt_Kayıtsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MenuyeDon = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_TopluKayıtSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUyeSilme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUyeSilme
            // 
            this.dataGridUyeSilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUyeSilme.Location = new System.Drawing.Point(-5, 235);
            this.dataGridUyeSilme.Name = "dataGridUyeSilme";
            this.dataGridUyeSilme.Size = new System.Drawing.Size(878, 150);
            this.dataGridUyeSilme.TabIndex = 0;
            // 
            // txt_Kayıtsil
            // 
            this.txt_Kayıtsil.Location = new System.Drawing.Point(112, 45);
            this.txt_Kayıtsil.Name = "txt_Kayıtsil";
            this.txt_Kayıtsil.Size = new System.Drawing.Size(100, 20);
            this.txt_Kayıtsil.TabIndex = 1;
            this.txt_Kayıtsil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İD";
            // 
            // btn_MenuyeDon
            // 
            this.btn_MenuyeDon.BackColor = System.Drawing.Color.White;
            this.btn_MenuyeDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_MenuyeDon.Image")));
            this.btn_MenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.Location = new System.Drawing.Point(42, 157);
            this.btn_MenuyeDon.Name = "btn_MenuyeDon";
            this.btn_MenuyeDon.Size = new System.Drawing.Size(128, 30);
            this.btn_MenuyeDon.TabIndex = 72;
            this.btn_MenuyeDon.Text = "Menüye Dön";
            this.btn_MenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuyeDon.UseVisualStyleBackColor = false;
            this.btn_MenuyeDon.Click += new System.EventHandler(this.btn_MenuyeDon_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.White;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Location = new System.Drawing.Point(42, 85);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(128, 30);
            this.btn_Sil.TabIndex = 74;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click_1);
            // 
            // btn_TopluKayıtSil
            // 
            this.btn_TopluKayıtSil.BackColor = System.Drawing.Color.White;
            this.btn_TopluKayıtSil.Image = ((System.Drawing.Image)(resources.GetObject("btn_TopluKayıtSil.Image")));
            this.btn_TopluKayıtSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TopluKayıtSil.Location = new System.Drawing.Point(42, 121);
            this.btn_TopluKayıtSil.Name = "btn_TopluKayıtSil";
            this.btn_TopluKayıtSil.Size = new System.Drawing.Size(128, 30);
            this.btn_TopluKayıtSil.TabIndex = 75;
            this.btn_TopluKayıtSil.Text = "Toplu Kayıt Sil";
            this.btn_TopluKayıtSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TopluKayıtSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TopluKayıtSil.UseVisualStyleBackColor = false;
            this.btn_TopluKayıtSil.Click += new System.EventHandler(this.btn_TopluKayıtSil_Click_1);
            // 
            // UyeSilmeBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 383);
            this.Controls.Add(this.btn_TopluKayıtSil);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_MenuyeDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Kayıtsil);
            this.Controls.Add(this.dataGridUyeSilme);
            this.Name = "UyeSilmeBolumu";
            this.Text = "UyeSilmeBolumu";
            this.Load += new System.EventHandler(this.UyeSilmeBolumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUyeSilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUyeSilme;
        private System.Windows.Forms.TextBox txt_Kayıtsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MenuyeDon;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_TopluKayıtSil;
    }
}