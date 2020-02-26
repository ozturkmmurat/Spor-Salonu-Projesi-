namespace YönCalismaProje
{
    partial class YoneticiOlustur
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
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_Sifretekrar = new System.Windows.Forms.Label();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.btn_KayıtOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(32, 22);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(106, 20);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(32, 55);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(47, 20);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // lbl_Sifretekrar
            // 
            this.lbl_Sifretekrar.AutoSize = true;
            this.lbl_Sifretekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifretekrar.Location = new System.Drawing.Point(32, 91);
            this.lbl_Sifretekrar.Name = "lbl_Sifretekrar";
            this.lbl_Sifretekrar.Size = new System.Drawing.Size(107, 20);
            this.lbl_Sifretekrar.TabIndex = 2;
            this.lbl_Sifretekrar.Text = "Şifre Tekrarı";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(177, 21);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_KullaniciAdi.TabIndex = 3;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(177, 57);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 4;
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(177, 93);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_SifreTekrar.TabIndex = 5;
            // 
            // btn_KayıtOlustur
            // 
            this.btn_KayıtOlustur.Location = new System.Drawing.Point(177, 142);
            this.btn_KayıtOlustur.Name = "btn_KayıtOlustur";
            this.btn_KayıtOlustur.Size = new System.Drawing.Size(100, 23);
            this.btn_KayıtOlustur.TabIndex = 6;
            this.btn_KayıtOlustur.Text = "Kayıt Oluştur";
            this.btn_KayıtOlustur.UseVisualStyleBackColor = true;
            this.btn_KayıtOlustur.Click += new System.EventHandler(this.btn_KayıtOlustur_Click);
            // 
            // YoneticiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.btn_KayıtOlustur);
            this.Controls.Add(this.txt_SifreTekrar);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.lbl_Sifretekrar);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Name = "YoneticiOlustur";
            this.Text = "YoneticiOlustur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_Sifretekrar;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.Button btn_KayıtOlustur;
    }
}