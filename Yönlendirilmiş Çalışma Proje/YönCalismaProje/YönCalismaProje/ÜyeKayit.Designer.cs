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
            this.dateTime_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.datagrid_ÜyeBilgileri = new System.Windows.Forms.DataGridView();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.btn_KayıtSil = new System.Windows.Forms.Button();
            this.txt_Kayıtsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Toplukayıtsil = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_KayıtAra = new System.Windows.Forms.TextBox();
            this.lbl_Kayıtara = new System.Windows.Forms.Label();
            this.btn_Üyeliksüresi = new System.Windows.Forms.Button();
            this.dateTime_Uyelikbaslangıç = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime_Uyeliksüresibitis = new System.Windows.Forms.DateTimePicker();
            this.lbl_ÜyelikbitişHesapla = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.lbl_usbl = new System.Windows.Forms.Label();
            this.lbl_usbb = new System.Windows.Forms.Label();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.combo_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.txt_Telno = new System.Windows.Forms.TextBox();
            this.lbl_Telno = new System.Windows.Forms.Label();
            this.btn_KayitiOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ÜyeBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tc.Location = new System.Drawing.Point(17, 26);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(58, 22);
            this.lbl_Tc.TabIndex = 0;
            this.lbl_Tc.Text = "Tc No";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(17, 67);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 22);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "Ad";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(17, 100);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(60, 22);
            this.lbl_Soyad.TabIndex = 2;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yas.Location = new System.Drawing.Point(17, 133);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(37, 22);
            this.lbl_Yas.TabIndex = 3;
            this.lbl_Yas.Text = "Yaş";
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.AutoSize = true;
            this.lbl_DogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(251, 28);
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(122, 22);
            this.lbl_DogumTarihi.TabIndex = 4;
            this.lbl_DogumTarihi.Text = "Doğum Tarihi";
            // 
            // lbl_Kilo
            // 
            this.lbl_Kilo.AutoSize = true;
            this.lbl_Kilo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kilo.Location = new System.Drawing.Point(17, 166);
            this.lbl_Kilo.Name = "lbl_Kilo";
            this.lbl_Kilo.Size = new System.Drawing.Size(42, 22);
            this.lbl_Kilo.TabIndex = 5;
            this.lbl_Kilo.Text = "Kilo";
            // 
            // lbl_Boy
            // 
            this.lbl_Boy.AutoSize = true;
            this.lbl_Boy.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Boy.Location = new System.Drawing.Point(17, 204);
            this.lbl_Boy.Name = "lbl_Boy";
            this.lbl_Boy.Size = new System.Drawing.Size(41, 22);
            this.lbl_Boy.TabIndex = 6;
            this.lbl_Boy.Text = "Boy";
            // 
            // lbl_ÜyelikSüresi
            // 
            this.lbl_ÜyelikSüresi.AutoSize = true;
            this.lbl_ÜyelikSüresi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ÜyelikSüresi.Location = new System.Drawing.Point(251, 61);
            this.lbl_ÜyelikSüresi.Name = "lbl_ÜyelikSüresi";
            this.lbl_ÜyelikSüresi.Size = new System.Drawing.Size(195, 22);
            this.lbl_ÜyelikSüresi.TabIndex = 7;
            this.lbl_ÜyelikSüresi.Text = "Üyelik Süresi Başlangıç";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(126, 28);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(100, 20);
            this.txt_Tc.TabIndex = 8;
            this.txt_Tc.TextChanged += new System.EventHandler(this.txt_Tc_TextChanged);
            this.txt_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tc_KeyPress);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(126, 64);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ad.TabIndex = 9;
            this.txt_Ad.TextChanged += new System.EventHandler(this.txt_Ad_TextChanged);
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(126, 101);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_Soyad.TabIndex = 10;
            this.txt_Soyad.TextChanged += new System.EventHandler(this.txt_Soyad_TextChanged);
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(126, 135);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Size = new System.Drawing.Size(100, 20);
            this.txt_Yas.TabIndex = 11;
            this.txt_Yas.TextChanged += new System.EventHandler(this.txt_Yas_TextChanged);
            this.txt_Yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Yas_KeyPress);
            // 
            // txt_Kilo
            // 
            this.txt_Kilo.Location = new System.Drawing.Point(126, 168);
            this.txt_Kilo.Name = "txt_Kilo";
            this.txt_Kilo.Size = new System.Drawing.Size(100, 20);
            this.txt_Kilo.TabIndex = 12;
            this.txt_Kilo.TextChanged += new System.EventHandler(this.txt_Kilo_TextChanged);
            this.txt_Kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Boy_KeyPress);
            // 
            // txt_Boy
            // 
            this.txt_Boy.Location = new System.Drawing.Point(126, 203);
            this.txt_Boy.Name = "txt_Boy";
            this.txt_Boy.Size = new System.Drawing.Size(100, 20);
            this.txt_Boy.TabIndex = 13;
            this.txt_Boy.TextChanged += new System.EventHandler(this.txt_Boy_TextChanged);
            this.txt_Boy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Boy_KeyPress);
            // 
            // dateTime_DogumTarihi
            // 
            this.dateTime_DogumTarihi.Location = new System.Drawing.Point(452, 35);
            this.dateTime_DogumTarihi.Name = "dateTime_DogumTarihi";
            this.dateTime_DogumTarihi.Size = new System.Drawing.Size(169, 20);
            this.dateTime_DogumTarihi.TabIndex = 15;
            // 
            // datagrid_ÜyeBilgileri
            // 
            this.datagrid_ÜyeBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_ÜyeBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ÜyeBilgileri.Location = new System.Drawing.Point(28, 345);
            this.datagrid_ÜyeBilgileri.Name = "datagrid_ÜyeBilgileri";
            this.datagrid_ÜyeBilgileri.Size = new System.Drawing.Size(942, 148);
            this.datagrid_ÜyeBilgileri.TabIndex = 16;
            this.datagrid_ÜyeBilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ÜyeBilgileri_CellContentClick);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.BackColor = System.Drawing.Color.White;
            this.btn_Yenile.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Yenile.Location = new System.Drawing.Point(333, 305);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(105, 34);
            this.btn_Yenile.TabIndex = 18;
            this.btn_Yenile.Text = "Listeyi Yenile";
            this.btn_Yenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Yenile.UseVisualStyleBackColor = false;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // btn_KayıtSil
            // 
            this.btn_KayıtSil.BackColor = System.Drawing.Color.White;
            this.btn_KayıtSil.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_KayıtSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KayıtSil.Location = new System.Drawing.Point(126, 305);
            this.btn_KayıtSil.Name = "btn_KayıtSil";
            this.btn_KayıtSil.Size = new System.Drawing.Size(95, 34);
            this.btn_KayıtSil.TabIndex = 19;
            this.btn_KayıtSil.Text = "Kayıtı Sil";
            this.btn_KayıtSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KayıtSil.UseVisualStyleBackColor = false;
            this.btn_KayıtSil.Click += new System.EventHandler(this.btn_KayıtSil_Click);
            // 
            // txt_Kayıtsil
            // 
            this.txt_Kayıtsil.Location = new System.Drawing.Point(452, 236);
            this.txt_Kayıtsil.Name = "txt_Kayıtsil";
            this.txt_Kayıtsil.Size = new System.Drawing.Size(169, 20);
            this.txt_Kayıtsil.TabIndex = 21;
            this.txt_Kayıtsil.TextChanged += new System.EventHandler(this.txt_Kayıtsil_TextChanged);
            this.txt_Kayıtsil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kayıtsil_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kayıt Sil";
            // 
            // btn_Toplukayıtsil
            // 
            this.btn_Toplukayıtsil.BackColor = System.Drawing.Color.White;
            this.btn_Toplukayıtsil.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Toplukayıtsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Toplukayıtsil.Location = new System.Drawing.Point(224, 305);
            this.btn_Toplukayıtsil.Name = "btn_Toplukayıtsil";
            this.btn_Toplukayıtsil.Size = new System.Drawing.Size(103, 34);
            this.btn_Toplukayıtsil.TabIndex = 22;
            this.btn_Toplukayıtsil.Text = "Toplu Kayıt Sil";
            this.btn_Toplukayıtsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Toplukayıtsil.UseVisualStyleBackColor = false;
            this.btn_Toplukayıtsil.Click += new System.EventHandler(this.btn_Toplukayıtsil_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.BackColor = System.Drawing.Color.White;
            this.btn_Ara.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ara.Location = new System.Drawing.Point(444, 305);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(104, 34);
            this.btn_Ara.TabIndex = 23;
            this.btn_Ara.Text = "Üye Ara";
            this.btn_Ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ara.UseVisualStyleBackColor = false;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // txt_KayıtAra
            // 
            this.txt_KayıtAra.Location = new System.Drawing.Point(452, 267);
            this.txt_KayıtAra.Name = "txt_KayıtAra";
            this.txt_KayıtAra.Size = new System.Drawing.Size(169, 20);
            this.txt_KayıtAra.TabIndex = 25;
            this.txt_KayıtAra.TextChanged += new System.EventHandler(this.txt_KayıtAra_TextChanged);
            // 
            // lbl_Kayıtara
            // 
            this.lbl_Kayıtara.AutoSize = true;
            this.lbl_Kayıtara.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kayıtara.Location = new System.Drawing.Point(251, 269);
            this.lbl_Kayıtara.Name = "lbl_Kayıtara";
            this.lbl_Kayıtara.Size = new System.Drawing.Size(84, 22);
            this.lbl_Kayıtara.TabIndex = 24;
            this.lbl_Kayıtara.Text = "Kayıt Ara";
            // 
            // btn_Üyeliksüresi
            // 
            this.btn_Üyeliksüresi.BackColor = System.Drawing.Color.White;
            this.btn_Üyeliksüresi.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Üyeliksüresi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Üyeliksüresi.Location = new System.Drawing.Point(554, 305);
            this.btn_Üyeliksüresi.Name = "btn_Üyeliksüresi";
            this.btn_Üyeliksüresi.Size = new System.Drawing.Size(147, 34);
            this.btn_Üyeliksüresi.TabIndex = 26;
            this.btn_Üyeliksüresi.Text = "Üyelik Süresini Göster";
            this.btn_Üyeliksüresi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Üyeliksüresi.UseVisualStyleBackColor = false;
            this.btn_Üyeliksüresi.Click += new System.EventHandler(this.btn_Üyeliksüresi_Click);
            // 
            // dateTime_Uyelikbaslangıç
            // 
            this.dateTime_Uyelikbaslangıç.Location = new System.Drawing.Point(452, 67);
            this.dateTime_Uyelikbaslangıç.Name = "dateTime_Uyelikbaslangıç";
            this.dateTime_Uyelikbaslangıç.Size = new System.Drawing.Size(169, 20);
            this.dateTime_Uyelikbaslangıç.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Üyelik Süresi Bitiş";
            // 
            // dateTime_Uyeliksüresibitis
            // 
            this.dateTime_Uyeliksüresibitis.Location = new System.Drawing.Point(452, 100);
            this.dateTime_Uyeliksüresibitis.Name = "dateTime_Uyeliksüresibitis";
            this.dateTime_Uyeliksüresibitis.Size = new System.Drawing.Size(169, 20);
            this.dateTime_Uyeliksüresibitis.TabIndex = 29;
            this.dateTime_Uyeliksüresibitis.ValueChanged += new System.EventHandler(this.dateTime_Uyeliksüresibitis_ValueChanged);
            // 
            // lbl_ÜyelikbitişHesapla
            // 
            this.lbl_ÜyelikbitişHesapla.AutoSize = true;
            this.lbl_ÜyelikbitişHesapla.Location = new System.Drawing.Point(449, 138);
            this.lbl_ÜyelikbitişHesapla.Name = "lbl_ÜyelikbitişHesapla";
            this.lbl_ÜyelikbitişHesapla.Size = new System.Drawing.Size(0, 13);
            this.lbl_ÜyelikbitişHesapla.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Üyelik Süresi";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(80, 506);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(35, 13);
            this.label_message.TabIndex = 35;
            this.label_message.Text = "label4";
            // 
            // lbl_usbl
            // 
            this.lbl_usbl.AutoSize = true;
            this.lbl_usbl.Location = new System.Drawing.Point(669, 72);
            this.lbl_usbl.Name = "lbl_usbl";
            this.lbl_usbl.Size = new System.Drawing.Size(0, 13);
            this.lbl_usbl.TabIndex = 36;
            // 
            // lbl_usbb
            // 
            this.lbl_usbb.AutoSize = true;
            this.lbl_usbb.Location = new System.Drawing.Point(661, 109);
            this.lbl_usbb.Name = "lbl_usbb";
            this.lbl_usbb.Size = new System.Drawing.Size(0, 13);
            this.lbl_usbb.TabIndex = 37;
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.BackColor = System.Drawing.Color.White;
            this.btn_Güncelle.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Güncelle.Location = new System.Drawing.Point(707, 305);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(104, 34);
            this.btn_Güncelle.TabIndex = 38;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Güncelle.UseVisualStyleBackColor = false;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // combo_Cinsiyet
            // 
            this.combo_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Cinsiyet.FormattingEnabled = true;
            this.combo_Cinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.combo_Cinsiyet.Location = new System.Drawing.Point(126, 236);
            this.combo_Cinsiyet.Name = "combo_Cinsiyet";
            this.combo_Cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.combo_Cinsiyet.TabIndex = 39;
            this.combo_Cinsiyet.SelectedIndexChanged += new System.EventHandler(this.combo_Cinsiyet_SelectedIndexChanged);
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(17, 234);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(74, 22);
            this.lbl_Cinsiyet.TabIndex = 40;
            this.lbl_Cinsiyet.Text = "Cinsiyet";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(126, 269);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 42;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Email.Location = new System.Drawing.Point(17, 267);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(61, 22);
            this.lbl_Email.TabIndex = 41;
            this.lbl_Email.Text = "E-Mail";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(452, 166);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(169, 20);
            this.txt_Adres.TabIndex = 44;
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adres.Location = new System.Drawing.Point(251, 163);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(57, 22);
            this.lbl_Adres.TabIndex = 43;
            this.lbl_Adres.Text = "Adres";
            // 
            // txt_Telno
            // 
            this.txt_Telno.Location = new System.Drawing.Point(452, 200);
            this.txt_Telno.Name = "txt_Telno";
            this.txt_Telno.Size = new System.Drawing.Size(169, 20);
            this.txt_Telno.TabIndex = 46;
            // 
            // lbl_Telno
            // 
            this.lbl_Telno.AutoSize = true;
            this.lbl_Telno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telno.Location = new System.Drawing.Point(251, 200);
            this.lbl_Telno.Name = "lbl_Telno";
            this.lbl_Telno.Size = new System.Drawing.Size(100, 22);
            this.lbl_Telno.TabIndex = 45;
            this.lbl_Telno.Text = "Telefon No";
            // 
            // btn_KayitiOlustur
            // 
            this.btn_KayitiOlustur.BackColor = System.Drawing.Color.White;
            this.btn_KayitiOlustur.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_KayitiOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KayitiOlustur.Location = new System.Drawing.Point(27, 305);
            this.btn_KayitiOlustur.Name = "btn_KayitiOlustur";
            this.btn_KayitiOlustur.Size = new System.Drawing.Size(95, 34);
            this.btn_KayitiOlustur.TabIndex = 17;
            this.btn_KayitiOlustur.Text = "Kayıtı Oluştur";
            this.btn_KayitiOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KayitiOlustur.UseVisualStyleBackColor = false;
            this.btn_KayitiOlustur.Click += new System.EventHandler(this.btn_KayitiOlustur_Click);
            // 
            // ÜyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 528);
            this.Controls.Add(this.txt_Telno);
            this.Controls.Add(this.lbl_Telno);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Cinsiyet);
            this.Controls.Add(this.combo_Cinsiyet);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.lbl_usbb);
            this.Controls.Add(this.lbl_usbl);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ÜyelikbitişHesapla);
            this.Controls.Add(this.dateTime_Uyeliksüresibitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTime_Uyelikbaslangıç);
            this.Controls.Add(this.btn_Üyeliksüresi);
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
        private System.Windows.Forms.Button btn_KayitiOlustur;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button btn_KayıtSil;
        private System.Windows.Forms.TextBox txt_Kayıtsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Toplukayıtsil;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_KayıtAra;
        private System.Windows.Forms.Label lbl_Kayıtara;
        private System.Windows.Forms.Button btn_Üyeliksüresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ÜyelikbitişHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label lbl_usbl;
        private System.Windows.Forms.Label lbl_usbb;
        public System.Windows.Forms.TextBox txt_Tc;
        public System.Windows.Forms.TextBox txt_Ad;
        public System.Windows.Forms.TextBox txt_Soyad;
        public System.Windows.Forms.TextBox txt_Yas;
        public System.Windows.Forms.TextBox txt_Kilo;
        public System.Windows.Forms.TextBox txt_Boy;
        public System.Windows.Forms.DateTimePicker dateTime_DogumTarihi;
        public System.Windows.Forms.DataGridView datagrid_ÜyeBilgileri;
        public System.Windows.Forms.DateTimePicker dateTime_Uyelikbaslangıç;
        public System.Windows.Forms.DateTimePicker dateTime_Uyeliksüresibitis;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.ComboBox combo_Cinsiyet;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        public System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        public System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label lbl_Adres;
        public System.Windows.Forms.TextBox txt_Telno;
        private System.Windows.Forms.Label lbl_Telno;
    }
}

