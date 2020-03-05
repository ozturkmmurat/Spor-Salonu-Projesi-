namespace YönCalismaProje
{
    partial class GirisSayfasi
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
            this.lbl_Kullaniciad = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.btn_YoneticiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kullaniciad
            // 
            this.lbl_Kullaniciad.AutoSize = true;
            this.lbl_Kullaniciad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullaniciad.Location = new System.Drawing.Point(44, 51);
            this.lbl_Kullaniciad.Name = "lbl_Kullaniciad";
            this.lbl_Kullaniciad.Size = new System.Drawing.Size(111, 22);
            this.lbl_Kullaniciad.TabIndex = 0;
            this.lbl_Kullaniciad.Text = "Kullanıcı Adı";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(44, 89);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(47, 22);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(204, 51);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_KullaniciAdi.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(204, 91);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(204, 138);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(100, 23);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.Text = "Giriş";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // btn_YoneticiEkle
            // 
            this.btn_YoneticiEkle.Location = new System.Drawing.Point(204, 180);
            this.btn_YoneticiEkle.Name = "btn_YoneticiEkle";
            this.btn_YoneticiEkle.Size = new System.Drawing.Size(100, 23);
            this.btn_YoneticiEkle.TabIndex = 5;
            this.btn_YoneticiEkle.Text = "Yönetici Ekle";
            this.btn_YoneticiEkle.UseVisualStyleBackColor = true;
            this.btn_YoneticiEkle.Click += new System.EventHandler(this.btn_YoneticiEkle_Click);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 401);
            this.Controls.Add(this.btn_YoneticiEkle);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kullaniciad);
            this.Name = "GirisSayfasi";
            this.Text = "GirisSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kullaniciad;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Button btn_YoneticiEkle;
    }
}