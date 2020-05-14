using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YönCalismaProje
{
    public partial class ÜyeKayit : Form
    {


        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");


        public ÜyeKayit()
        {
            InitializeComponent();
            label_message.Text = " ";

        }
   

        private void ÜyeKayit_Load(object sender, EventArgs e)
        {
            Tablolustur();
            lbl_usbl.Text = dateTime_Uyelikbaslangıç.Value.ToString("ddd, MMM d, yyyy");
            
            
             
            
       

      


            //while (dr.Read())
            //{
            //    combo_Cinsiyet.Items.Add(dr["kitapadi"]);
            //}
            //Baglanti.Close();

            //    DateTime baslangic, bitis;
            //    baslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value);
            //    bitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value);

            //    //lbl_baslangic.Text = baslangic.ToString();
            //    //lbl_bitis.Text = bitis.ToString();
        }
        void Tablolustur()
        {

            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");        
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select * from Yön_CalismaProje ORDER BY id DESC", Baglanti);
            DataTable sqlVerialma = new DataTable();
            
            sqlVericekme.Fill(sqlVerialma);
            datagrid_ÜyeBilgileri.DataSource = sqlVerialma;
            Baglanti.Close();
        }



        DateTime lbl_usbl2;
        DateTime lbl_usbb2;
        public void btn_KayitiOlustur_Click(object sender, EventArgs e)
        {
            int GünSüresiniTut;
            string Tc = txt_Tc.Text;
           
            //Int64 test = Convert.ToInt64(txt_Tc.ToString());
            if (comboBox_Paket.Text == "")
            {
                MessageBox.Show("Lütfen bir paket seçiniz");
            }
            else
            {
                lbl_usbl2 = Convert.ToDateTime(lbl_usbl.Text);
                lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
            }
            

          

            
            if (lbl_usbl.Text == lbl_usbb.Text)
            {
                MessageBox.Show("Başlangıç tarihi ile bitiş tarihi aynı olamaz.");
            }



            else if (lbl_usbl2 > lbl_usbb2)
            {

                MessageBox.Show("Bitiş tarihi Başlangıç tarihinden daha küçük olamaz", "Uyarı");
            }
            else if ((lbl_ÜyelikbitişHesapla.Text) == "01.00:00:00")
            {
                lbl_ÜyelikbitişHesapla.Text = "0";
            }

            else if (comboBox_Paket.Text == "5 GÜNLÜK")
            {
                DateTime Uyebaslangic;
                DateTime Uyebitis;
                TimeSpan Hesapla;
                DateTime Dogumtarihi;
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
                Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
                Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
                Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
                Hesapla = Uyebitis - Uyebaslangic;
                lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());
                deneme(5);
            }
            else if (comboBox_Paket.Text == "20 GÜNLÜK")
            {

                DateTime Uyebaslangic;
                DateTime Uyebitis;
                TimeSpan Hesapla;
                DateTime Dogumtarihi;
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(20);
                Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
                Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
                Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
                Hesapla = Uyebitis - Uyebaslangic;
                lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());
                deneme(20);

                //deneme = denemem.ToString;



            }

        }
        public void deneme(int SüreyiYakala)
        {
            string Tc = txt_Tc.Text;
            DateTime Uyebaslangic;
            DateTime Uyebitis;
            DateTime Dogumtarihi;
            DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(SüreyiYakala);
            Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
            Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());

            if (txt_Tc.Text == "" || txt_Ad.Text == "" || txt_Soyad.Text == "" || txt_Yas.Text == "" || lbl_ÜyelikbitişHesapla.Text == "" || txt_Tc.Text == null || txt_Ad.Text == null || txt_Soyad.Text == null || txt_Yas.Text == null || combo_Cinsiyet.Text == null || comboBox_Paket.Text == "")
            {
                MessageBox.Show("Lütfen Bütün bilgilerinizi giriniz");
            }
            else
            {
                Baglanti.Open();

                string date1 = Uyebaslangic.ToString(("ddd, MMM d, yyyy"));
                string date2 = Uyebitis.ToString(("ddd, MMM d, yyyy"));

                string dtarih = Dogumtarihi.ToString("ddd, MMM d, yyyy");

                SqlCommand Komut = new SqlCommand("INSERT INTO Yön_Calismaproje ( Tc , Ad, Soyad , Yas,Dogum_Tarihi ,Uyelik_Suresibaslangic,Uyelik_Suresibitis,Uyelik_Kalansüre,Cinsiyet,E_mail,Adres,Telefon_No) VALUES (@Tc , @Ad , @Soyad ,@Yas, @Dogum_Tarihi , @Uyelik_Suresibaslangic,@Uyelik_Suresibitis,@Uyelik_Kalansüre,@Cinsiyet,@E_mail,@Adres,@Telefon_No )", Baglanti);
                //int id = Convert.ToInt32(drow.Cells[0].Value);


                //DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
                //int Tc = Convert.ToInt64(txt_Tc.Text);
                Komut.Parameters.AddWithValue("@Tc", Tc);
                Komut.Parameters.AddWithValue("@Ad", txt_Ad.Text);
                Komut.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
                Komut.Parameters.AddWithValue("@Yas", txt_Yas.Text);
                Komut.Parameters.AddWithValue("@Dogum_Tarihi", dtarih);
                Komut.Parameters.AddWithValue("@Uyelik_Suresibaslangic", date1);
                Komut.Parameters.AddWithValue("@Uyelik_Suresibitis", date2);
                Komut.Parameters.AddWithValue("@Uyelik_Kalansüre", lbl_ÜyelikbitişHesapla.Text);
                Komut.Parameters.AddWithValue("@Cinsiyet", combo_Cinsiyet.Text);
                Komut.Parameters.AddWithValue("@E_mail", txt_Email.Text);
                Komut.Parameters.AddWithValue("@Adres", txt_Adres.Text);
                Komut.Parameters.AddWithValue("Telefon_No", txt_Telno.Text);

                Komut.ExecuteNonQuery();

                ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");
                ÜyeBilgileri Üyebilgileri = new ÜyeBilgileri();
                Üyebilgileri.lbl_Blgad.Text = txt_Ad.Text;
                Üyebilgileri.lbl_Blgsoyad.Text = txt_Soyad.Text;
                Üyebilgileri.lbl_Blgüyeliksüresibaslangıc.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[8].Value.ToString();
                Üyebilgileri.lbl_Blgüyeliksüresibitis.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[9].Value.ToString();
                Üyebilgileri.lbl_Blgid.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[0].Value.ToString();
                //ÜyeBilgileri Üyebilgileri = new ÜyeBilgileri();

                Üyebilgileri.Show();

                Baglanti.Close();

            }



            //this.Hide();

        }
    

    private void datagrid_ÜyeBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            ÜyeBilgileri ÜyeBilgileri = new ÜyeBilgileri();
            ÜyeBilgileri.lbl_Blgid.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[0].Value.ToString();
            ÜyeBilgileri.lbl_Blgad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[2].Value.ToString();
            ÜyeBilgileri.lbl_Blgsoyad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[3].Value.ToString();
            ÜyeBilgileri.lbl_Blgüyeliksüresibaslangıc.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[8].Value.ToString();
            ÜyeBilgileri.lbl_Blgüyeliksüresibitis.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[9].Value.ToString();

            //ÜyeBilgileri.dataGrid_Program.CurrentRow.Cells[0] = datagrid_ÜyeBilgileri.CurrentRow.Cells[0];
            ÜyeBilgileri.Show();
            DateTime lbl_usbl2 = Convert.ToDateTime(lbl_usbl.Text);
            DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
            DateTime Uyebaslangic;
            DateTime Uyebitis;
            TimeSpan Hesapla;
            DateTime Dogumtarihi;
            DateTime ileriTarih;
            Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            Uyebitis = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
            Hesapla = Uyebitis - Uyebaslangic;
            lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());
            string date1 = Uyebaslangic.ToString();
            string date2 = Uyebitis.ToString();
            string dtarih = Dogumtarihi.ToString();
         
            txt_Tc.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[1].Value.ToString();
            txt_Ad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[2].Value.ToString();
            txt_Soyad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[3].Value.ToString();
            txt_Yas.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[4].Value.ToString();       
            dateTime_DogumTarihi.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[7].Value.ToString();         
            dateTime_Uyelikbaslangıç.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[8].Value.ToString();
            combo_Cinsiyet.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[11].Value.ToString();
            txt_Email.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[12].Value.ToString();
            txt_Adres.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[13].Value.ToString();
            txt_Telno.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[14].Value.ToString();


            //dtarih = Convert.ToDateTime(datagrid_ÜyeBilgileri.CurrentRow.Cells[5].Value)
            //datagrid_ÜyeBilgileri.CurrentRow.Cells[0] = datagrid_ÜyeBilgile ();
            //ÜyeBilgileri.lbl_Blgad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[1].Value.ToString();
            //ÜyeBilgileri.lbl_Blgsoyad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[2].Value.ToString();
            ////ÜyeBilgileri.lbl_Blgyas.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[3].Value.ToString();

            //// ÜyeBilgileri.lbl_Blgkilo.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[5].Value.ToString();       ÜyeBilgileri.lbl_Blgboy.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[6].Value.ToString();

            //ÜyeBilgileri.lbl_Blgüyeliksüresibaslangıc.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[7].Value.ToString();
            //ÜyeBilgileri.lbl_Blgüyeliksüresibitis.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[8].Value.ToString();


        }

        void ListeyiYenileme(string ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri,Baglanti);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            datagrid_ÜyeBilgileri.DataSource = ds.Tables[0];
        }
        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");

        }

    

        private void btn_Ara_Click(object sender, EventArgs e)
        {
           
            if(txt_KayıtAra.Text == "")
            {
                MessageBox.Show("Lütfen aramak istediğiniz üyenin Tc No bilgisini giriniz.", "Uyarı");

            }
            else
            {
                Baglanti.Open();
                SqlCommand KayıtAra = new SqlCommand("select * from Yön_CalismaProje where Tc like '%" + txt_KayıtAra.Text + "%'", Baglanti);
                SqlDataAdapter veri_KayıtAra = new SqlDataAdapter(KayıtAra);
                KayıtAra.ExecuteNonQuery();
                DataSet dss = new DataSet(); // Dataset ne işe yarıyor ?
                veri_KayıtAra.Fill(dss);
                datagrid_ÜyeBilgileri.DataSource = dss.Tables[0];
                Baglanti.Close();
            }

            
        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {
            txt_Ad.MaxLength = 25;
        }

        private void txt_Soyad_TextChanged(object sender, EventArgs e)
        {
            txt_Soyad.MaxLength = 25;
        }

        private void txt_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

   

        private void txt_Kayıtsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_Üyeliksüresi_Click(object sender, EventArgs e)
        {
            DateTime Uyebaslangic;
            DateTime Uyebitis;
     
            TimeSpan Hesapla;
            if(comboBox_Paket.Text=="5 GÜNLÜK")
            {
                lbl_ÜyelikbitişHesapla.Text = dateTime_Uyelikbaslangıç.Value.ToString();
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
                Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
                Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
                Hesapla = Uyebitis - Uyebaslangic;
                lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());
            }
            else if(comboBox_Paket.Text=="20 GÜNLÜK")
            {
                lbl_ÜyelikbitişHesapla.Text = dateTime_Uyelikbaslangıç.Value.ToString();
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(20);
                Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
                Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
                Hesapla = Uyebitis - Uyebaslangic;
                lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());
            }
          
           




        }


        private void dateTime_Uyeliksüresibitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
            lbl_usbb.Text = ileriTarih.ToString("ddd, MMM d, yyyy");
        }

        private void txt_Tc_TextChanged(object sender, EventArgs e)
        {
            txt_Tc.MaxLength = 11;   
         
        }

        private void txt_Yas_TextChanged(object sender, EventArgs e)
        {
            txt_Yas.MaxLength = 3;
        }

      

      

        private void txt_Yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txt_Kayıtsil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_KayıtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            DateTime Uyebaslangic;
            DateTime Uyebitis;
            TimeSpan Hesapla;
            DateTime Dogumtarihi;
            Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
            Uyebitis = Convert.ToDateTime(ileriTarih.ToShortDateString());
            Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
            Hesapla = Uyebitis - Uyebaslangic;
            lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());

            string datee1 = Uyebaslangic.ToString();
            string datee2 = Uyebitis.ToString();

            string dtarihh = Dogumtarihi.ToString();

            Baglanti.Open();


            SqlCommand GüncelleKomut = new SqlCommand("update Yön_CalismaProje set Tc='" + txt_Tc.Text + "' ,Ad='" + txt_Ad.Text + "', Soyad='" + txt_Soyad.Text + "' ,Yas='" + txt_Yas.Text + "'  ,Dogum_Tarihi='" + dtarihh + "' ,Uyelik_Suresibaslangic='" + datee1 + "',Uyelik_Suresibitis='" + datee2 + "' ,Uyelik_Kalansüre='" + lbl_ÜyelikbitişHesapla.Text + "'where id = '" + datagrid_ÜyeBilgileri.CurrentRow.Cells[0].Value.ToString() + "'", Baglanti);

            GüncelleKomut.ExecuteNonQuery();
            ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");
            Baglanti.Close();
        }

        private void combo_Cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Paket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Paket.Text == "")
            {
                MessageBox.Show("Lütfen Paket Türünü seçiniz");
            }
            else if(comboBox_Paket.Text=="5 GÜNLÜK")
            {
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
                lbl_usbb.Text = ileriTarih.ToString("ddd, MMM d, yyyy");
            }
            else if(comboBox_Paket.Text=="20 GÜNLÜK")
            {
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(20);
                lbl_usbb.Text = ileriTarih.ToString("ddd, MMM d, yyyy");
            }
          
        }

        private void dateTime_Uyelikbaslangıç_ValueChanged(object sender, EventArgs e)
        {
            lbl_usbl.Text = dateTime_Uyelikbaslangıç.Value.ToString("ddd, MMM d, yyyy");

              if (comboBox_Paket.Text == "5 GÜNLÜK")
            {
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(5);
                lbl_usbb.Text = ileriTarih.ToString("ddd, MMM d, yyyy");
            }
          else  if (comboBox_Paket.Text == "20 GÜNLÜK")
            {
                DateTime ileriTarih = dateTime_Uyelikbaslangıç.Value.AddDays(20);
                lbl_usbb.Text = ileriTarih.ToString("ddd, MMM d, yyyy");
            }
        }

        private void btn_MenuyeDon_Click(object sender, EventArgs e)
        {
            Menu MenuSayfasi = new Menu();
            MenuSayfasi.Show();
            this.Hide();
        }
    }
}

