namespace YönCalismaProje
{
    partial class GİrisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GİrisSayfasi));
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.btn_YoneticiEkle = new System.Windows.Forms.Button();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(23, 136);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(43, 18);
            this.lbl_Sifre.TabIndex = 66;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(23, 100);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(99, 18);
            this.lbl_KullaniciAdi.TabIndex = 65;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(153, 134);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(109, 20);
            this.txt_Sifre.TabIndex = 64;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(153, 98);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(109, 20);
            this.txt_KullaniciAdi.TabIndex = 63;
            // 
            // btn_YoneticiEkle
            // 
            this.btn_YoneticiEkle.BackColor = System.Drawing.Color.White;
            this.btn_YoneticiEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_YoneticiEkle.Image")));
            this.btn_YoneticiEkle.Location = new System.Drawing.Point(153, 206);
            this.btn_YoneticiEkle.Name = "btn_YoneticiEkle";
            this.btn_YoneticiEkle.Size = new System.Drawing.Size(109, 30);
            this.btn_YoneticiEkle.TabIndex = 67;
            this.btn_YoneticiEkle.Text = "Yönetici Ekle";
            this.btn_YoneticiEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_YoneticiEkle.UseVisualStyleBackColor = false;
            this.btn_YoneticiEkle.Click += new System.EventHandler(this.btn_YoneticiEkle_Click_1);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.Color.White;
            this.btn_GirisYap.Image = ((System.Drawing.Image)(resources.GetObject("btn_GirisYap.Image")));
            this.btn_GirisYap.Location = new System.Drawing.Point(153, 170);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(109, 30);
            this.btn_GirisYap.TabIndex = 62;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click_1);
            // 
            // GİrisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.btn_YoneticiEkle);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.btn_GirisYap);
            this.Name = "GİrisSayfasi";
            this.Text = "GİrisSayfasi";
            this.Load += new System.EventHandler(this.GİrisSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_YoneticiEkle;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Button btn_GirisYap;
    }
}