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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeKayit));
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.lbl_DogumTarihi = new System.Windows.Forms.Label();
            this.lbl_ÜyelikSüresi = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.dateTime_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.datagrid_ÜyeBilgileri = new System.Windows.Forms.DataGridView();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_KayıtAra = new System.Windows.Forms.TextBox();
            this.lbl_Kayıtara = new System.Windows.Forms.Label();
            this.btn_Üyeliksüresi = new System.Windows.Forms.Button();
            this.dateTime_Uyelikbaslangıç = new System.Windows.Forms.DateTimePicker();
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
            this.lbl_UyelıkPaketi = new System.Windows.Forms.Label();
            this.comboBox_Paket = new System.Windows.Forms.ComboBox();
            this.btn_MenuyeDon = new System.Windows.Forms.Button();
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
            this.txt_Tc.Size = new System.Drawing.Size(105, 20);
            this.txt_Tc.TabIndex = 8;
            this.txt_Tc.TextChanged += new System.EventHandler(this.txt_Tc_TextChanged);
            this.txt_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tc_KeyPress);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(126, 64);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(105, 20);
            this.txt_Ad.TabIndex = 9;
            this.txt_Ad.TextChanged += new System.EventHandler(this.txt_Ad_TextChanged);
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(126, 101);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(105, 20);
            this.txt_Soyad.TabIndex = 10;
            this.txt_Soyad.TextChanged += new System.EventHandler(this.txt_Soyad_TextChanged);
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(126, 135);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Size = new System.Drawing.Size(105, 20);
            this.txt_Yas.TabIndex = 11;
            this.txt_Yas.TextChanged += new System.EventHandler(this.txt_Yas_TextChanged);
            this.txt_Yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Yas_KeyPress);
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
            this.btn_Yenile.Location = new System.Drawing.Point(136, 305);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(105, 34);
            this.btn_Yenile.TabIndex = 18;
            this.btn_Yenile.Text = "Listeyi Yenile";
            this.btn_Yenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Yenile.UseVisualStyleBackColor = false;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // btn_Ara
            // 
            this.btn_Ara.BackColor = System.Drawing.Color.White;
            this.btn_Ara.Image = global::YönCalismaProje.Properties.Resources.images__1_;
            this.btn_Ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ara.Location = new System.Drawing.Point(247, 305);
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
            this.txt_KayıtAra.Location = new System.Drawing.Point(450, 172);
            this.txt_KayıtAra.Name = "txt_KayıtAra";
            this.txt_KayıtAra.Size = new System.Drawing.Size(169, 20);
            this.txt_KayıtAra.TabIndex = 25;
            this.txt_KayıtAra.TextChanged += new System.EventHandler(this.txt_KayıtAra_TextChanged);
            // 
            // lbl_Kayıtara
            // 
            this.lbl_Kayıtara.AutoSize = true;
            this.lbl_Kayıtara.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kayıtara.Location = new System.Drawing.Point(249, 172);
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
            this.btn_Üyeliksüresi.Location = new System.Drawing.Point(357, 305);
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
            this.dateTime_Uyelikbaslangıç.ValueChanged += new System.EventHandler(this.dateTime_Uyelikbaslangıç_ValueChanged);
            // 
            // lbl_ÜyelikbitişHesapla
            // 
            this.lbl_ÜyelikbitişHesapla.AutoSize = true;
            this.lbl_ÜyelikbitişHesapla.Location = new System.Drawing.Point(449, 107);
            this.lbl_ÜyelikbitişHesapla.Name = "lbl_ÜyelikbitişHesapla";
            this.lbl_ÜyelikbitişHesapla.Size = new System.Drawing.Size(0, 13);
            this.lbl_ÜyelikbitişHesapla.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 101);
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
            this.btn_Güncelle.Location = new System.Drawing.Point(510, 305);
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
            this.combo_Cinsiyet.Location = new System.Drawing.Point(126, 172);
            this.combo_Cinsiyet.Name = "combo_Cinsiyet";
            this.combo_Cinsiyet.Size = new System.Drawing.Size(105, 21);
            this.combo_Cinsiyet.TabIndex = 39;
            this.combo_Cinsiyet.SelectedIndexChanged += new System.EventHandler(this.combo_Cinsiyet_SelectedIndexChanged);
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(17, 170);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(74, 22);
            this.lbl_Cinsiyet.TabIndex = 40;
            this.lbl_Cinsiyet.Text = "Cinsiyet";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(126, 205);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(105, 20);
            this.txt_Email.TabIndex = 42;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Email.Location = new System.Drawing.Point(17, 203);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(61, 22);
            this.lbl_Email.TabIndex = 41;
            this.lbl_Email.Text = "E-Mail";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(452, 136);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(169, 20);
            this.txt_Adres.TabIndex = 44;
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adres.Location = new System.Drawing.Point(251, 136);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(57, 22);
            this.lbl_Adres.TabIndex = 43;
            this.lbl_Adres.Text = "Adres";
            // 
            // txt_Telno
            // 
            this.txt_Telno.Location = new System.Drawing.Point(126, 241);
            this.txt_Telno.Name = "txt_Telno";
            this.txt_Telno.Size = new System.Drawing.Size(105, 20);
            this.txt_Telno.TabIndex = 46;
            // 
            // lbl_Telno
            // 
            this.lbl_Telno.AutoSize = true;
            this.lbl_Telno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telno.Location = new System.Drawing.Point(15, 239);
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
            // lbl_UyelıkPaketi
            // 
            this.lbl_UyelıkPaketi.AutoSize = true;
            this.lbl_UyelıkPaketi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UyelıkPaketi.Location = new System.Drawing.Point(251, 205);
            this.lbl_UyelıkPaketi.Name = "lbl_UyelıkPaketi";
            this.lbl_UyelıkPaketi.Size = new System.Drawing.Size(116, 22);
            this.lbl_UyelıkPaketi.TabIndex = 48;
            this.lbl_UyelıkPaketi.Text = "Üyelik Paketi";
            // 
            // comboBox_Paket
            // 
            this.comboBox_Paket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Paket.FormattingEnabled = true;
            this.comboBox_Paket.Items.AddRange(new object[] {
            "5 GÜNLÜK",
            "20 GÜNLÜK"});
            this.comboBox_Paket.Location = new System.Drawing.Point(450, 208);
            this.comboBox_Paket.Name = "comboBox_Paket";
            this.comboBox_Paket.Size = new System.Drawing.Size(169, 21);
            this.comboBox_Paket.TabIndex = 47;
            this.comboBox_Paket.SelectedIndexChanged += new System.EventHandler(this.comboBox_Paket_SelectedIndexChanged);
            // 
            // btn_MenuyeDon
            // 
            this.btn_MenuyeDon.BackColor = System.Drawing.Color.White;
            this.btn_MenuyeDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_MenuyeDon.Image")));
            this.btn_MenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.Location = new System.Drawing.Point(620, 305);
            this.btn_MenuyeDon.Name = "btn_MenuyeDon";
            this.btn_MenuyeDon.Size = new System.Drawing.Size(128, 30);
            this.btn_MenuyeDon.TabIndex = 72;
            this.btn_MenuyeDon.Text = "Menüye Dön";
            this.btn_MenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuyeDon.UseVisualStyleBackColor = false;
            this.btn_MenuyeDon.Click += new System.EventHandler(this.btn_MenuyeDon_Click);
            // 
            // ÜyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 528);
            this.Controls.Add(this.btn_MenuyeDon);
            this.Controls.Add(this.lbl_UyelıkPaketi);
            this.Controls.Add(this.comboBox_Paket);
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
            this.Controls.Add(this.dateTime_Uyelikbaslangıç);
            this.Controls.Add(this.btn_Üyeliksüresi);
            this.Controls.Add(this.txt_KayıtAra);
            this.Controls.Add(this.lbl_Kayıtara);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.btn_KayitiOlustur);
            this.Controls.Add(this.datagrid_ÜyeBilgileri);
            this.Controls.Add(this.dateTime_DogumTarihi);
            this.Controls.Add(this.txt_Yas);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.lbl_ÜyelikSüresi);
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
        private System.Windows.Forms.Label lbl_ÜyelikSüresi;
        private System.Windows.Forms.Button btn_KayitiOlustur;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_KayıtAra;
        private System.Windows.Forms.Label lbl_Kayıtara;
        private System.Windows.Forms.Button btn_Üyeliksüresi;
        private System.Windows.Forms.Label lbl_ÜyelikbitişHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label lbl_usbl;
        private System.Windows.Forms.Label lbl_usbb;
        public System.Windows.Forms.TextBox txt_Tc;
        public System.Windows.Forms.TextBox txt_Ad;
        public System.Windows.Forms.TextBox txt_Soyad;
        public System.Windows.Forms.TextBox txt_Yas;
        public System.Windows.Forms.DateTimePicker dateTime_DogumTarihi;
        public System.Windows.Forms.DataGridView datagrid_ÜyeBilgileri;
        public System.Windows.Forms.DateTimePicker dateTime_Uyelikbaslangıç;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.ComboBox combo_Cinsiyet;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        public System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        public System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label lbl_Adres;
        public System.Windows.Forms.TextBox txt_Telno;
        private System.Windows.Forms.Label lbl_Telno;
        private System.Windows.Forms.Label lbl_UyelıkPaketi;
        private System.Windows.Forms.ComboBox comboBox_Paket;
        private System.Windows.Forms.Button btn_MenuyeDon;
    }
}

