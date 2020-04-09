namespace YönCalismaProje
{
    partial class Menu
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
            this.btn_Uyeolustur = new System.Windows.Forms.Button();
            this.btn_UyeSil = new System.Windows.Forms.Button();
            this.btn_SporProgramıOlustur = new System.Windows.Forms.Button();
            this.btn_BeslenmeOlustur = new System.Windows.Forms.Button();
            this.btn_OlcumBilgisiOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Uyeolustur
            // 
            this.btn_Uyeolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Uyeolustur.Location = new System.Drawing.Point(94, 94);
            this.btn_Uyeolustur.Name = "btn_Uyeolustur";
            this.btn_Uyeolustur.Size = new System.Drawing.Size(171, 50);
            this.btn_Uyeolustur.TabIndex = 0;
            this.btn_Uyeolustur.Text = "Üye Oluştur";
            this.btn_Uyeolustur.UseVisualStyleBackColor = true;
            this.btn_Uyeolustur.Click += new System.EventHandler(this.btn_Uyeolustur_Click);
            // 
            // btn_UyeSil
            // 
            this.btn_UyeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeSil.Location = new System.Drawing.Point(294, 94);
            this.btn_UyeSil.Name = "btn_UyeSil";
            this.btn_UyeSil.Size = new System.Drawing.Size(171, 50);
            this.btn_UyeSil.TabIndex = 1;
            this.btn_UyeSil.Text = "Üye Sil";
            this.btn_UyeSil.UseVisualStyleBackColor = true;
            this.btn_UyeSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SporProgramıOlustur
            // 
            this.btn_SporProgramıOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SporProgramıOlustur.Location = new System.Drawing.Point(294, 167);
            this.btn_SporProgramıOlustur.Name = "btn_SporProgramıOlustur";
            this.btn_SporProgramıOlustur.Size = new System.Drawing.Size(171, 50);
            this.btn_SporProgramıOlustur.TabIndex = 2;
            this.btn_SporProgramıOlustur.Text = "Spor Programı Oluştur";
            this.btn_SporProgramıOlustur.UseVisualStyleBackColor = true;
            this.btn_SporProgramıOlustur.Click += new System.EventHandler(this.btn_SporProgramıOlustur_Click);
            // 
            // btn_BeslenmeOlustur
            // 
            this.btn_BeslenmeOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BeslenmeOlustur.Location = new System.Drawing.Point(94, 167);
            this.btn_BeslenmeOlustur.Name = "btn_BeslenmeOlustur";
            this.btn_BeslenmeOlustur.Size = new System.Drawing.Size(171, 50);
            this.btn_BeslenmeOlustur.TabIndex = 3;
            this.btn_BeslenmeOlustur.Text = "Beslenme Programı Oluştur";
            this.btn_BeslenmeOlustur.UseVisualStyleBackColor = true;
            this.btn_BeslenmeOlustur.Click += new System.EventHandler(this.btn_BeslenmeOlustur_Click);
            // 
            // btn_OlcumBilgisiOlustur
            // 
            this.btn_OlcumBilgisiOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OlcumBilgisiOlustur.Location = new System.Drawing.Point(94, 242);
            this.btn_OlcumBilgisiOlustur.Name = "btn_OlcumBilgisiOlustur";
            this.btn_OlcumBilgisiOlustur.Size = new System.Drawing.Size(171, 50);
            this.btn_OlcumBilgisiOlustur.TabIndex = 4;
            this.btn_OlcumBilgisiOlustur.Text = "Ölçüm Bilgisi Oluştur";
            this.btn_OlcumBilgisiOlustur.UseVisualStyleBackColor = true;
            this.btn_OlcumBilgisiOlustur.Click += new System.EventHandler(this.btn_OlcumBilgisiOlustur_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 381);
            this.Controls.Add(this.btn_OlcumBilgisiOlustur);
            this.Controls.Add(this.btn_BeslenmeOlustur);
            this.Controls.Add(this.btn_SporProgramıOlustur);
            this.Controls.Add(this.btn_UyeSil);
            this.Controls.Add(this.btn_Uyeolustur);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Uyeolustur;
        private System.Windows.Forms.Button btn_UyeSil;
        private System.Windows.Forms.Button btn_SporProgramıOlustur;
        private System.Windows.Forms.Button btn_BeslenmeOlustur;
        private System.Windows.Forms.Button btn_OlcumBilgisiOlustur;
    }
}