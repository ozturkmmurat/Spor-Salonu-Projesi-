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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiOlustur));
            this.lbl_SifreTekrar = new System.Windows.Forms.Label();
            this.lbl_Şifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_YoneticiOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SifreTekrar
            // 
            this.lbl_SifreTekrar.AutoSize = true;
            this.lbl_SifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SifreTekrar.Location = new System.Drawing.Point(19, 120);
            this.lbl_SifreTekrar.Name = "lbl_SifreTekrar";
            this.lbl_SifreTekrar.Size = new System.Drawing.Size(97, 18);
            this.lbl_SifreTekrar.TabIndex = 70;
            this.lbl_SifreTekrar.Text = "Şifre Tekrar";
            // 
            // lbl_Şifre
            // 
            this.lbl_Şifre.AutoSize = true;
            this.lbl_Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Şifre.Location = new System.Drawing.Point(17, 96);
            this.lbl_Şifre.Name = "lbl_Şifre";
            this.lbl_Şifre.Size = new System.Drawing.Size(43, 18);
            this.lbl_Şifre.TabIndex = 69;
            this.lbl_Şifre.Text = "Şifre";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(17, 70);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(99, 18);
            this.lbl_KullaniciAdi.TabIndex = 68;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(138, 68);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(107, 20);
            this.txt_KullaniciAdi.TabIndex = 67;
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(138, 120);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.PasswordChar = '*';
            this.txt_SifreTekrar.Size = new System.Drawing.Size(107, 20);
            this.txt_SifreTekrar.TabIndex = 66;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(138, 94);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(107, 20);
            this.txt_Sifre.TabIndex = 65;
            // 
            // btn_YoneticiOlustur
            // 
            this.btn_YoneticiOlustur.BackColor = System.Drawing.Color.White;
            this.btn_YoneticiOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btn_YoneticiOlustur.Image")));
            this.btn_YoneticiOlustur.Location = new System.Drawing.Point(138, 159);
            this.btn_YoneticiOlustur.Name = "btn_YoneticiOlustur";
            this.btn_YoneticiOlustur.Size = new System.Drawing.Size(107, 30);
            this.btn_YoneticiOlustur.TabIndex = 64;
            this.btn_YoneticiOlustur.Text = "Yönetici Oluştur";
            this.btn_YoneticiOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_YoneticiOlustur.UseVisualStyleBackColor = false;
            this.btn_YoneticiOlustur.Click += new System.EventHandler(this.btn_YoneticiOlustur_Click_1);
            // 
            // YoneticiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 391);
            this.Controls.Add(this.lbl_SifreTekrar);
            this.Controls.Add(this.lbl_Şifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.txt_SifreTekrar);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.btn_YoneticiOlustur);
            this.Name = "YoneticiOlustur";
            this.Text = "YonneticiOlustur";
            this.Load += new System.EventHandler(this.YonneticiOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SifreTekrar;
        private System.Windows.Forms.Label lbl_Şifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_YoneticiOlustur;
    }
}