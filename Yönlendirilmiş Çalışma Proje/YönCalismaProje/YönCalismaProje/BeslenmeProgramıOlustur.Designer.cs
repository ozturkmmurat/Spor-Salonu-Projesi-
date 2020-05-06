namespace YönCalismaProje
{
    partial class BeslenmeProgramıOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeslenmeProgramıOlustur));
            this.txt_Beslenmeekle = new System.Windows.Forms.TextBox();
            this.btn_Beslenmeprog = new System.Windows.Forms.Button();
            this.lbl_BeslenmeProg = new System.Windows.Forms.Label();
            this.List_Beslenmeprogrami = new System.Windows.Forms.ListBox();
            this.dataGridBeslenme = new System.Windows.Forms.DataGridView();
            this.btn_Olustur = new System.Windows.Forms.Button();
            this.lbl_usbts = new System.Windows.Forms.Label();
            this.lbl_usbb = new System.Windows.Forms.Label();
            this.dateTime_Programbitis = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Programbaslangic = new System.Windows.Forms.DateTimePicker();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_blgAd = new System.Windows.Forms.Label();
            this.lbl_BlgSoyad = new System.Windows.Forms.Label();
            this.lbl_Programsurehesapla = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lbl_Programbitis = new System.Windows.Forms.Label();
            this.comboBox_Gun = new System.Windows.Forms.ComboBox();
            this.lbl_Gün = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBeslenme)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Beslenmeekle
            // 
            this.txt_Beslenmeekle.Location = new System.Drawing.Point(19, 88);
            this.txt_Beslenmeekle.Name = "txt_Beslenmeekle";
            this.txt_Beslenmeekle.Size = new System.Drawing.Size(125, 20);
            this.txt_Beslenmeekle.TabIndex = 40;
            // 
            // btn_Beslenmeprog
            // 
            this.btn_Beslenmeprog.BackColor = System.Drawing.Color.White;
            this.btn_Beslenmeprog.Image = ((System.Drawing.Image)(resources.GetObject("btn_Beslenmeprog.Image")));
            this.btn_Beslenmeprog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Beslenmeprog.Location = new System.Drawing.Point(191, 88);
            this.btn_Beslenmeprog.Name = "btn_Beslenmeprog";
            this.btn_Beslenmeprog.Size = new System.Drawing.Size(132, 26);
            this.btn_Beslenmeprog.TabIndex = 39;
            this.btn_Beslenmeprog.Text = "Beslenme Programı";
            this.btn_Beslenmeprog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Beslenmeprog.UseVisualStyleBackColor = false;
            this.btn_Beslenmeprog.Click += new System.EventHandler(this.btn_Beslenmeprog_Click);
            // 
            // lbl_BeslenmeProg
            // 
            this.lbl_BeslenmeProg.AutoSize = true;
            this.lbl_BeslenmeProg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BeslenmeProg.Location = new System.Drawing.Point(-1, 130);
            this.lbl_BeslenmeProg.Name = "lbl_BeslenmeProg";
            this.lbl_BeslenmeProg.Size = new System.Drawing.Size(156, 19);
            this.lbl_BeslenmeProg.TabIndex = 42;
            this.lbl_BeslenmeProg.Text = "Beslenme Programı";
            // 
            // List_Beslenmeprogrami
            // 
            this.List_Beslenmeprogrami.FormattingEnabled = true;
            this.List_Beslenmeprogrami.Location = new System.Drawing.Point(3, 152);
            this.List_Beslenmeprogrami.Name = "List_Beslenmeprogrami";
            this.List_Beslenmeprogrami.Size = new System.Drawing.Size(175, 251);
            this.List_Beslenmeprogrami.TabIndex = 41;
            // 
            // dataGridBeslenme
            // 
            this.dataGridBeslenme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBeslenme.Location = new System.Drawing.Point(184, 151);
            this.dataGridBeslenme.Name = "dataGridBeslenme";
            this.dataGridBeslenme.Size = new System.Drawing.Size(761, 252);
            this.dataGridBeslenme.TabIndex = 43;
            this.dataGridBeslenme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Olustur
            // 
            this.btn_Olustur.BackColor = System.Drawing.Color.White;
            this.btn_Olustur.Image = ((System.Drawing.Image)(resources.GetObject("btn_Olustur.Image")));
            this.btn_Olustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Olustur.Location = new System.Drawing.Point(325, 88);
            this.btn_Olustur.Name = "btn_Olustur";
            this.btn_Olustur.Size = new System.Drawing.Size(128, 26);
            this.btn_Olustur.TabIndex = 44;
            this.btn_Olustur.Text = "Programı Oluştur";
            this.btn_Olustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Olustur.UseVisualStyleBackColor = false;
            this.btn_Olustur.Click += new System.EventHandler(this.btn_Olustur_Click);
            // 
            // lbl_usbts
            // 
            this.lbl_usbts.AutoSize = true;
            this.lbl_usbts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usbts.Location = new System.Drawing.Point(638, 126);
            this.lbl_usbts.Name = "lbl_usbts";
            this.lbl_usbts.Size = new System.Drawing.Size(0, 22);
            this.lbl_usbts.TabIndex = 48;
            // 
            // lbl_usbb
            // 
            this.lbl_usbb.AutoSize = true;
            this.lbl_usbb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usbb.Location = new System.Drawing.Point(655, 92);
            this.lbl_usbb.Name = "lbl_usbb";
            this.lbl_usbb.Size = new System.Drawing.Size(0, 22);
            this.lbl_usbb.TabIndex = 47;
            // 
            // dateTime_Programbitis
            // 
            this.dateTime_Programbitis.Location = new System.Drawing.Point(341, 13);
            this.dateTime_Programbitis.Name = "dateTime_Programbitis";
            this.dateTime_Programbitis.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Programbitis.TabIndex = 50;
            this.dateTime_Programbitis.ValueChanged += new System.EventHandler(this.dateTime_Programbitis_ValueChanged);
            // 
            // dateTime_Programbaslangic
            // 
            this.dateTime_Programbaslangic.Location = new System.Drawing.Point(714, 128);
            this.dateTime_Programbaslangic.Name = "dateTime_Programbaslangic";
            this.dateTime_Programbaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Programbaslangic.TabIndex = 49;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(15, 40);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(60, 22);
            this.lbl_Soyad.TabIndex = 52;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(15, 9);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 22);
            this.lbl_Ad.TabIndex = 51;
            this.lbl_Ad.Text = "Ad";
            // 
            // lbl_blgAd
            // 
            this.lbl_blgAd.AutoSize = true;
            this.lbl_blgAd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_blgAd.Location = new System.Drawing.Point(97, 11);
            this.lbl_blgAd.Name = "lbl_blgAd";
            this.lbl_blgAd.Size = new System.Drawing.Size(50, 19);
            this.lbl_blgAd.TabIndex = 53;
            this.lbl_blgAd.Text = "label1";
            // 
            // lbl_BlgSoyad
            // 
            this.lbl_BlgSoyad.AutoSize = true;
            this.lbl_BlgSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BlgSoyad.Location = new System.Drawing.Point(98, 44);
            this.lbl_BlgSoyad.Name = "lbl_BlgSoyad";
            this.lbl_BlgSoyad.Size = new System.Drawing.Size(51, 16);
            this.lbl_BlgSoyad.TabIndex = 54;
            this.lbl_BlgSoyad.Text = "label1";
            // 
            // lbl_Programsurehesapla
            // 
            this.lbl_Programsurehesapla.AutoSize = true;
            this.lbl_Programsurehesapla.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Programsurehesapla.Location = new System.Drawing.Point(849, 17);
            this.lbl_Programsurehesapla.Name = "lbl_Programsurehesapla";
            this.lbl_Programsurehesapla.Size = new System.Drawing.Size(46, 22);
            this.lbl_Programsurehesapla.TabIndex = 55;
            this.lbl_Programsurehesapla.Text = "Süre";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.White;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Location = new System.Drawing.Point(325, 122);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(128, 26);
            this.btn_Sil.TabIndex = 57;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.White;
            this.btn_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.Image")));
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.Location = new System.Drawing.Point(191, 122);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(128, 26);
            this.btn_Guncelle.TabIndex = 71;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // lbl_Programbitis
            // 
            this.lbl_Programbitis.AutoSize = true;
            this.lbl_Programbitis.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Programbitis.Location = new System.Drawing.Point(161, 11);
            this.lbl_Programbitis.Name = "lbl_Programbitis";
            this.lbl_Programbitis.Size = new System.Drawing.Size(174, 22);
            this.lbl_Programbitis.TabIndex = 72;
            this.lbl_Programbitis.Text = "Program Bitiş Tarihi";
            // 
            // comboBox_Gun
            // 
            this.comboBox_Gun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gun.FormattingEnabled = true;
            this.comboBox_Gun.Items.AddRange(new object[] {
            "Birinci Gün",
            "İkinci Gün",
            "Üçüncü Gün"});
            this.comboBox_Gun.Location = new System.Drawing.Point(341, 40);
            this.comboBox_Gun.Name = "comboBox_Gun";
            this.comboBox_Gun.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Gun.TabIndex = 73;
            // 
            // lbl_Gün
            // 
            this.lbl_Gün.AutoSize = true;
            this.lbl_Gün.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gün.Location = new System.Drawing.Point(161, 40);
            this.lbl_Gün.Name = "lbl_Gün";
            this.lbl_Gün.Size = new System.Drawing.Size(124, 22);
            this.lbl_Gün.TabIndex = 74;
            this.lbl_Gün.Text = "Beslenme Gün";
            // 
            // BeslenmeProgramıOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 406);
            this.Controls.Add(this.lbl_Gün);
            this.Controls.Add(this.comboBox_Gun);
            this.Controls.Add(this.lbl_Programbitis);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_Programsurehesapla);
            this.Controls.Add(this.lbl_BlgSoyad);
            this.Controls.Add(this.lbl_blgAd);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.dateTime_Programbitis);
            this.Controls.Add(this.dateTime_Programbaslangic);
            this.Controls.Add(this.lbl_usbts);
            this.Controls.Add(this.lbl_usbb);
            this.Controls.Add(this.btn_Olustur);
            this.Controls.Add(this.dataGridBeslenme);
            this.Controls.Add(this.lbl_BeslenmeProg);
            this.Controls.Add(this.List_Beslenmeprogrami);
            this.Controls.Add(this.txt_Beslenmeekle);
            this.Controls.Add(this.btn_Beslenmeprog);
            this.Name = "BeslenmeProgramıOlustur";
            this.Text = "BeslenmeProgramıOlustur";
            this.Load += new System.EventHandler(this.BeslenmeProgramıOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBeslenme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Beslenmeekle;
        private System.Windows.Forms.Button btn_Beslenmeprog;
        private System.Windows.Forms.Label lbl_BeslenmeProg;
        public System.Windows.Forms.ListBox List_Beslenmeprogrami;
        private System.Windows.Forms.DataGridView dataGridBeslenme;
        private System.Windows.Forms.Button btn_Olustur;
        private System.Windows.Forms.Label lbl_usbts;
        private System.Windows.Forms.Label lbl_usbb;
        private System.Windows.Forms.DateTimePicker dateTime_Programbitis;
        private System.Windows.Forms.DateTimePicker dateTime_Programbaslangic;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        public System.Windows.Forms.Label lbl_blgAd;
        public System.Windows.Forms.Label lbl_BlgSoyad;
        private System.Windows.Forms.Label lbl_Programsurehesapla;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label lbl_Programbitis;
        private System.Windows.Forms.ComboBox comboBox_Gun;
        private System.Windows.Forms.Label lbl_Gün;
    }
}