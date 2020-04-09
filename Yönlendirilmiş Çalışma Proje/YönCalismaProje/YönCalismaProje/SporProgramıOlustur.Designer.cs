namespace YönCalismaProje
{
    partial class SporProgramıOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SporProgramıOlustur));
            this.txt_Sporekle = new System.Windows.Forms.TextBox();
            this.btn_Sporprog = new System.Windows.Forms.Button();
            this.lbl_BlgSoyad = new System.Windows.Forms.Label();
            this.lbl_blgAd = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lbl_Programsurehesapla = new System.Windows.Forms.Label();
            this.dateTime_Programbitis = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Programbaslangic = new System.Windows.Forms.DateTimePicker();
            this.lbl_usbts = new System.Windows.Forms.Label();
            this.lbl_usbb = new System.Windows.Forms.Label();
            this.btn_Olustur = new System.Windows.Forms.Button();
            this.dataGrid_Program = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.List_SporProgrami = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Program)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Sporekle
            // 
            this.txt_Sporekle.Location = new System.Drawing.Point(26, 79);
            this.txt_Sporekle.Name = "txt_Sporekle";
            this.txt_Sporekle.Size = new System.Drawing.Size(125, 20);
            this.txt_Sporekle.TabIndex = 39;
            // 
            // btn_Sporprog
            // 
            this.btn_Sporprog.BackColor = System.Drawing.Color.White;
            this.btn_Sporprog.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sporprog.Image")));
            this.btn_Sporprog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sporprog.Location = new System.Drawing.Point(169, 72);
            this.btn_Sporprog.Name = "btn_Sporprog";
            this.btn_Sporprog.Size = new System.Drawing.Size(131, 27);
            this.btn_Sporprog.TabIndex = 38;
            this.btn_Sporprog.Text = "Spor Programı";
            this.btn_Sporprog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sporprog.UseVisualStyleBackColor = false;
            this.btn_Sporprog.Click += new System.EventHandler(this.btn_Sporprog_Click);
            // 
            // lbl_BlgSoyad
            // 
            this.lbl_BlgSoyad.AutoSize = true;
            this.lbl_BlgSoyad.Location = new System.Drawing.Point(120, 46);
            this.lbl_BlgSoyad.Name = "lbl_BlgSoyad";
            this.lbl_BlgSoyad.Size = new System.Drawing.Size(35, 13);
            this.lbl_BlgSoyad.TabIndex = 58;
            this.lbl_BlgSoyad.Text = "label1";
            // 
            // lbl_blgAd
            // 
            this.lbl_blgAd.AutoSize = true;
            this.lbl_blgAd.Location = new System.Drawing.Point(120, 17);
            this.lbl_blgAd.Name = "lbl_blgAd";
            this.lbl_blgAd.Size = new System.Drawing.Size(35, 13);
            this.lbl_blgAd.TabIndex = 57;
            this.lbl_blgAd.Text = "label1";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(37, 40);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(60, 22);
            this.lbl_Soyad.TabIndex = 56;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(37, 9);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 22);
            this.lbl_Ad.TabIndex = 55;
            this.lbl_Ad.Text = "Ad";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.White;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Location = new System.Drawing.Point(537, 106);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(128, 26);
            this.btn_Sil.TabIndex = 65;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // lbl_Programsurehesapla
            // 
            this.lbl_Programsurehesapla.AutoSize = true;
            this.lbl_Programsurehesapla.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Programsurehesapla.Location = new System.Drawing.Point(876, 10);
            this.lbl_Programsurehesapla.Name = "lbl_Programsurehesapla";
            this.lbl_Programsurehesapla.Size = new System.Drawing.Size(46, 22);
            this.lbl_Programsurehesapla.TabIndex = 64;
            this.lbl_Programsurehesapla.Text = "Süre";
            // 
            // dateTime_Programbitis
            // 
            this.dateTime_Programbitis.Location = new System.Drawing.Point(320, 107);
            this.dateTime_Programbitis.Name = "dateTime_Programbitis";
            this.dateTime_Programbitis.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Programbitis.TabIndex = 63;
            this.dateTime_Programbitis.ValueChanged += new System.EventHandler(this.dateTime_Programbitis_ValueChanged);
            // 
            // dateTime_Programbaslangic
            // 
            this.dateTime_Programbaslangic.Location = new System.Drawing.Point(320, 79);
            this.dateTime_Programbaslangic.Name = "dateTime_Programbaslangic";
            this.dateTime_Programbaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTime_Programbaslangic.TabIndex = 62;
            // 
            // lbl_usbts
            // 
            this.lbl_usbts.AutoSize = true;
            this.lbl_usbts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usbts.Location = new System.Drawing.Point(701, 110);
            this.lbl_usbts.Name = "lbl_usbts";
            this.lbl_usbts.Size = new System.Drawing.Size(0, 22);
            this.lbl_usbts.TabIndex = 61;
            // 
            // lbl_usbb
            // 
            this.lbl_usbb.AutoSize = true;
            this.lbl_usbb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usbb.Location = new System.Drawing.Point(682, 85);
            this.lbl_usbb.Name = "lbl_usbb";
            this.lbl_usbb.Size = new System.Drawing.Size(0, 22);
            this.lbl_usbb.TabIndex = 60;
            // 
            // btn_Olustur
            // 
            this.btn_Olustur.BackColor = System.Drawing.Color.White;
            this.btn_Olustur.Image = ((System.Drawing.Image)(resources.GetObject("btn_Olustur.Image")));
            this.btn_Olustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Olustur.Location = new System.Drawing.Point(537, 77);
            this.btn_Olustur.Name = "btn_Olustur";
            this.btn_Olustur.Size = new System.Drawing.Size(128, 26);
            this.btn_Olustur.TabIndex = 59;
            this.btn_Olustur.Text = "Programı Oluştur";
            this.btn_Olustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Olustur.UseVisualStyleBackColor = false;
            this.btn_Olustur.Click += new System.EventHandler(this.btn_Olustur_Click);
            // 
            // dataGrid_Program
            // 
            this.dataGrid_Program.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGrid_Program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Program.Location = new System.Drawing.Point(169, 198);
            this.dataGrid_Program.Name = "dataGrid_Program";
            this.dataGrid_Program.Size = new System.Drawing.Size(772, 209);
            this.dataGrid_Program.TabIndex = 66;
            this.dataGrid_Program.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Program_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-3, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Beslenme Programı";
            // 
            // List_SporProgrami
            // 
            this.List_SporProgrami.FormattingEnabled = true;
            this.List_SporProgrami.Location = new System.Drawing.Point(1, 198);
            this.List_SporProgrami.Name = "List_SporProgrami";
            this.List_SporProgrami.Size = new System.Drawing.Size(166, 199);
            this.List_SporProgrami.TabIndex = 67;
            // 
            // SporProgramıOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.List_SporProgrami);
            this.Controls.Add(this.dataGrid_Program);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_Programsurehesapla);
            this.Controls.Add(this.dateTime_Programbitis);
            this.Controls.Add(this.dateTime_Programbaslangic);
            this.Controls.Add(this.lbl_usbts);
            this.Controls.Add(this.lbl_usbb);
            this.Controls.Add(this.btn_Olustur);
            this.Controls.Add(this.lbl_BlgSoyad);
            this.Controls.Add(this.lbl_blgAd);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.txt_Sporekle);
            this.Controls.Add(this.btn_Sporprog);
            this.Name = "SporProgramıOlustur";
            this.Text = "SporProgramıOlustur";
            this.Load += new System.EventHandler(this.SporProgramıOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Program)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sporekle;
        private System.Windows.Forms.Button btn_Sporprog;
        public System.Windows.Forms.Label lbl_BlgSoyad;
        public System.Windows.Forms.Label lbl_blgAd;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label lbl_Programsurehesapla;
        private System.Windows.Forms.DateTimePicker dateTime_Programbitis;
        private System.Windows.Forms.DateTimePicker dateTime_Programbaslangic;
        private System.Windows.Forms.Label lbl_usbts;
        private System.Windows.Forms.Label lbl_usbb;
        private System.Windows.Forms.Button btn_Olustur;
        public System.Windows.Forms.DataGridView dataGrid_Program;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox List_SporProgrami;
    }
}