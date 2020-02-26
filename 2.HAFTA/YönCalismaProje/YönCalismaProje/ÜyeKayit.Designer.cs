namespace YönCalismaProje
{
    partial class ÜyeKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.lbl_DogumTarihi = new System.Windows.Forms.Label();
            this.lbl_Kilo = new System.Windows.Forms.Label();
            this.lbl_Boy = new System.Windows.Forms.Label();
            this.lbl_ÜyelikSüresi = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.txt_Kilo = new System.Windows.Forms.TextBox();
            this.txt_Boy = new System.Windows.Forms.TextBox();
            this.txt_ÜyelikSüresi = new System.Windows.Forms.TextBox();
            this.dateTime_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.datagrid_ÜyeBilgileri = new System.Windows.Forms.DataGridView();
            this.btn_KayitiOlustur = new System.Windows.Forms.Button();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.btn_KayıtSil = new System.Windows.Forms.Button();
            this.txt_Kayıtsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Toplukayıtsil = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_KayıtAra = new System.Windows.Forms.TextBox();
            this.lbl_Kayıtara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ÜyeBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tc.Location = new System.Drawing.Point(32, 37);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(58, 22);
            this.lbl_Tc.TabIndex = 0;
            this.lbl_Tc.Text = "Tc No";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(32, 76);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 22);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "Ad";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(30, 110);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(60, 22);
            this.lbl_Soyad.TabIndex = 2;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yas.Location = new System.Drawing.Point(36, 141);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(37, 22);
            this.lbl_Yas.TabIndex = 3;
            this.lbl_Yas.Text = "Yaş";
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.AutoSize = true;
            this.lbl_DogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(24, 242);
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(122, 22);
            this.lbl_DogumTarihi.TabIndex = 4;
            this.lbl_DogumTarihi.Text = "Doğum Tarihi";
            // 
            // lbl_Kilo
            // 
            this.lbl_Kilo.AutoSize = true;
            this.lbl_Kilo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kilo.Location = new System.Drawing.Point(36, 177);
            this.lbl_Kilo.Name = "lbl_Kilo";
            this.lbl_Kilo.Size = new System.Drawing.Size(42, 22);
            this.lbl_Kilo.TabIndex = 5;
            this.lbl_Kilo.Text = "Kilo";
            // 
            // lbl_Boy
            // 
            this.lbl_Boy.AutoSize = true;
            this.lbl_Boy.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Boy.Location = new System.Drawing.Point(32, 212);
            this.lbl_Boy.Name = "lbl_Boy";
            this.lbl_Boy.Size = new System.Drawing.Size(41, 22);
            this.lbl_Boy.TabIndex = 6;
            this.lbl_Boy.Text = "Boy";
            // 
            // lbl_ÜyelikSüresi
            // 
            this.lbl_ÜyelikSüresi.AutoSize = true;
            this.lbl_ÜyelikSüresi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ÜyelikSüresi.Location = new System.Drawing.Point(24, 274);
            this.lbl_ÜyelikSüresi.Name = "lbl_ÜyelikSüresi";
            this.lbl_ÜyelikSüresi.Size = new System.Drawing.Size(114, 22);
            this.lbl_ÜyelikSüresi.TabIndex = 7;
            this.lbl_ÜyelikSüresi.Text = "Üyelik Süresi";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(165, 40);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(100, 20);
            this.txt_Tc.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(165, 76);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ad.TabIndex = 9;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(165, 113);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_Soyad.TabIndex = 10;
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(165, 144);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Size = new System.Drawing.Size(100, 20);
            this.txt_Yas.TabIndex = 11;
            // 
            // txt_Kilo
            // 
            this.txt_Kilo.Location = new System.Drawing.Point(165, 180);
            this.txt_Kilo.Name = "txt_Kilo";
            this.txt_Kilo.Size = new System.Drawing.Size(100, 20);
            this.txt_Kilo.TabIndex = 12;
            // 
            // txt_Boy
            // 
            this.txt_Boy.Location = new System.Drawing.Point(165, 215);
            this.txt_Boy.Name = "txt_Boy";
            this.txt_Boy.Size = new System.Drawing.Size(100, 20);
            this.txt_Boy.TabIndex = 13;
            // 
            // txt_ÜyelikSüresi
            // 
            this.txt_ÜyelikSüresi.Location = new System.Drawing.Point(165, 277);
            this.txt_ÜyelikSüresi.Name = "txt_ÜyelikSüresi";
            this.txt_ÜyelikSüresi.Size = new System.Drawing.Size(100, 20);
            this.txt_ÜyelikSüresi.TabIndex = 14;
            // 
            // dateTime_DogumTarihi
            // 
            this.dateTime_DogumTarihi.Location = new System.Drawing.Point(165, 244);
            this.dateTime_DogumTarihi.Name = "dateTime_DogumTarihi";
            this.dateTime_DogumTarihi.Size = new System.Drawing.Size(169, 20);
            this.dateTime_DogumTarihi.TabIndex = 15;
            // 
            // datagrid_ÜyeBilgileri
            // 
            this.datagrid_ÜyeBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ÜyeBilgileri.Location = new System.Drawing.Point(28, 345);
            this.datagrid_ÜyeBilgileri.Name = "datagrid_ÜyeBilgileri";
            this.datagrid_ÜyeBilgileri.Size = new System.Drawing.Size(751, 150);
            this.datagrid_ÜyeBilgileri.TabIndex = 16;
            this.datagrid_ÜyeBilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ÜyeBilgileri_CellContentClick);
            // 
            // btn_KayitiOlustur
            // 
            this.btn_KayitiOlustur.Location = new System.Drawing.Point(63, 316);
            this.btn_KayitiOlustur.Name = "btn_KayitiOlustur";
            this.btn_KayitiOlustur.Size = new System.Drawing.Size(95, 23);
            this.btn_KayitiOlustur.TabIndex = 17;
            this.btn_KayitiOlustur.Text = "Kayıtı Oluştur";
            this.btn_KayitiOlustur.UseVisualStyleBackColor = true;
            this.btn_KayitiOlustur.Click += new System.EventHandler(this.btn_KayitiOlustur_Click);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Location = new System.Drawing.Point(366, 316);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(95, 23);
            this.btn_Yenile.TabIndex = 18;
            this.btn_Yenile.Text = "Listeyi Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // btn_KayıtSil
            // 
            this.btn_KayıtSil.Location = new System.Drawing.Point(164, 316);
            this.btn_KayıtSil.Name = "btn_KayıtSil";
            this.btn_KayıtSil.Size = new System.Drawing.Size(95, 23);
            this.btn_KayıtSil.TabIndex = 19;
            this.btn_KayıtSil.Text = "Kayıtı Sil";
            this.btn_KayıtSil.UseVisualStyleBackColor = true;
            this.btn_KayıtSil.Click += new System.EventHandler(this.btn_KayıtSil_Click);
            // 
            // txt_Kayıtsil
            // 
            this.txt_Kayıtsil.Location = new System.Drawing.Point(567, 37);
            this.txt_Kayıtsil.Name = "txt_Kayıtsil";
            this.txt_Kayıtsil.Size = new System.Drawing.Size(100, 20);
            this.txt_Kayıtsil.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(434, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kayıt Sil";
            // 
            // btn_Toplukayıtsil
            // 
            this.btn_Toplukayıtsil.Location = new System.Drawing.Point(265, 316);
            this.btn_Toplukayıtsil.Name = "btn_Toplukayıtsil";
            this.btn_Toplukayıtsil.Size = new System.Drawing.Size(95, 23);
            this.btn_Toplukayıtsil.TabIndex = 22;
            this.btn_Toplukayıtsil.Text = "Toplu Kayıt Sil";
            this.btn_Toplukayıtsil.UseVisualStyleBackColor = true;
            this.btn_Toplukayıtsil.Click += new System.EventHandler(this.btn_Toplukayıtsil_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(467, 316);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(95, 23);
            this.btn_Ara.TabIndex = 23;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // txt_KayıtAra
            // 
            this.txt_KayıtAra.Location = new System.Drawing.Point(567, 79);
            this.txt_KayıtAra.Name = "txt_KayıtAra";
            this.txt_KayıtAra.Size = new System.Drawing.Size(100, 20);
            this.txt_KayıtAra.TabIndex = 25;
            // 
            // lbl_Kayıtara
            // 
            this.lbl_Kayıtara.AutoSize = true;
            this.lbl_Kayıtara.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kayıtara.Location = new System.Drawing.Point(434, 79);
            this.lbl_Kayıtara.Name = "lbl_Kayıtara";
            this.lbl_Kayıtara.Size = new System.Drawing.Size(84, 22);
            this.lbl_Kayıtara.TabIndex = 24;
            this.lbl_Kayıtara.Text = "Kayıt Ara";
            // 
            // ÜyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 470);
            this.Controls.Add(this.txt_KayıtAra);
            this.Controls.Add(this.lbl_Kayıtara);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.btn_Toplukayıtsil);
            this.Controls.Add(this.txt_Kayıtsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KayıtSil);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.btn_KayitiOlustur);
            this.Controls.Add(this.datagrid_ÜyeBilgileri);
            this.Controls.Add(this.dateTime_DogumTarihi);
            this.Controls.Add(this.txt_ÜyelikSüresi);
            this.Controls.Add(this.txt_Boy);
            this.Controls.Add(this.txt_Kilo);
            this.Controls.Add(this.txt_Yas);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.lbl_ÜyelikSüresi);
            this.Controls.Add(this.lbl_Boy);
            this.Controls.Add(this.lbl_Kilo);
            this.Controls.Add(this.lbl_DogumTarihi);
            this.Controls.Add(this.lbl_Yas);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.lbl_Tc);
            this.Name = "ÜyeKayit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ÜyeKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ÜyeBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tc;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Yas;
        private System.Windows.Forms.Label lbl_DogumTarihi;
        private System.Windows.Forms.Label lbl_Kilo;
        private System.Windows.Forms.Label lbl_Boy;
        private System.Windows.Forms.Label lbl_ÜyelikSüresi;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.TextBox txt_Kilo;
        private System.Windows.Forms.TextBox txt_Boy;
        private System.Windows.Forms.TextBox txt_ÜyelikSüresi;
        private System.Windows.Forms.DateTimePicker dateTime_DogumTarihi;
        private System.Windows.Forms.DataGridView datagrid_ÜyeBilgileri;
        private System.Windows.Forms.Button btn_KayitiOlustur;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button btn_KayıtSil;
        private System.Windows.Forms.TextBox txt_Kayıtsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Toplukayıtsil;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_KayıtAra;
        private System.Windows.Forms.Label lbl_Kayıtara;
    }
}

