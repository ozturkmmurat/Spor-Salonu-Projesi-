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
            lbl_usbl.Text = dateTime_Uyelikbaslangıç.Value.ToString();
            lbl_usbb.Text = dateTime_Uyeliksüresibitis.Value.ToString();
         


            //    DateTime baslangic, bitis;
            //    baslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value);
            //    bitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value);

            //    //lbl_baslangic.Text = baslangic.ToString();
            //    //lbl_bitis.Text = bitis.ToString();
        }
        void Tablolustur()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglanti.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select * from Yön_CalismaProje ORDER BY id DESC", Baglanti);
            DataTable sqlVerialma = new DataTable();
            
            sqlVericekme.Fill(sqlVerialma);
            datagrid_ÜyeBilgileri.DataSource = sqlVerialma;
            Baglanti.Close();
        }




        public void btn_KayitiOlustur_Click(object sender, EventArgs e)
        {

            string Tc = txt_Tc.Text;
            //Int64 test = Convert.ToInt64(txt_Tc.ToString());
            DateTime lbl_usbl2 = Convert.ToDateTime(lbl_usbl.Text);
            DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
            if (lbl_usbl.Text == lbl_usbb.Text )
            {
                MessageBox.Show  ("Başlangıç tarihi ile bitiş tarihi aynı olamaz.");
            }



            else if (lbl_usbl2 > lbl_usbb2)
            {

                MessageBox.Show("Bitiş tarihi Başlangıç tarihinden daha küçük olamaz", "Uyarı");
            }

            else
            {

                DateTime Uyebaslangic;
                DateTime Uyebitis;
                TimeSpan Hesapla;
                DateTime Dogumtarihi;
                Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
                Uyebitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value.ToShortDateString());
                Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
                Hesapla = Uyebitis - Uyebaslangic;
                lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());


                //deneme = denemem.ToString;

                if (txt_Tc.Text == "" || txt_Ad.Text == "" || txt_Soyad.Text == "" || txt_Kilo.Text == "" || txt_Yas.Text == "" || lbl_ÜyelikbitişHesapla.Text == ""  ||txt_Tc.Text == null || txt_Ad.Text == null || txt_Soyad.Text == null || txt_Yas.Text == null)
                {
                    MessageBox.Show("Lütfen Bütün bilgilerinizi giriniz");
                }
                else
                {
                    Baglanti.Open();

                   string  date1 = Uyebaslangic.ToString();
                    string date2 = Uyebitis.ToString();

                    string dtarih = Dogumtarihi.ToString();

                    SqlCommand Komut = new SqlCommand("INSERT INTO Yön_Calismaproje ( Tc , Ad, Soyad , Yas,Dogum_Tarihi ,Kilo , Boy ,Uyelik_Suresibaslangic,Uyelik_Suresibitis,Uyelik_Kalansüre) VALUES (@Tc , @Ad , @Soyad ,@Yas, @Dogum_Tarihi , @Kilo , @Boy ,  @Uyelik_Suresibaslangic,@Uyelik_Suresibitis,@Uyelik_Kalansüre )", Baglanti);
                    //int id = Convert.ToInt32(drow.Cells[0].Value);


                    //DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
                    //int Tc = Convert.ToInt64(txt_Tc.Text);
                    Komut.Parameters.AddWithValue("@Tc", Tc);
                    Komut.Parameters.AddWithValue("@Ad", txt_Ad.Text);
                    Komut.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
                    Komut.Parameters.AddWithValue("@Yas", txt_Yas.Text);
                    Komut.Parameters.AddWithValue("@Dogum_Tarihi", dtarih);
                    Komut.Parameters.AddWithValue("@Kilo", txt_Kilo.Text);
                    Komut.Parameters.AddWithValue("@Boy", txt_Boy.Text);
                    Komut.Parameters.AddWithValue("@Uyelik_Suresibaslangic", date1);
                    Komut.Parameters.AddWithValue("@Uyelik_Suresibitis", date2);
                    Komut.Parameters.AddWithValue("@Uyelik_Kalansüre", lbl_ÜyelikbitişHesapla.Text);
                 
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
            Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            Uyebitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value.ToShortDateString());
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
            txt_Kilo.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[5].Value.ToString();
            txt_Boy.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[6].Value.ToString();
            dateTime_DogumTarihi.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[7].Value.ToString(); ;           
            dateTime_Uyelikbaslangıç.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[8].Value.ToString();
            dateTime_Uyeliksüresibitis.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[9].Value.ToString();


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

        private void btn_KayıtSil_Click(object sender, EventArgs e)
        {
           
          
            if(txt_Kayıtsil.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz Kayıtın İd bilgisini giriniz.", "Uyarı");
            }
         
            else {  
                Baglanti.Open();
                SqlCommand Komut2 = new SqlCommand("DELETE  FROM Yön_Calismaproje where id =@id", Baglanti);
                Komut2.Parameters.AddWithValue("@id", txt_Kayıtsil.Text);
                Komut2.ExecuteNonQuery();
                Baglanti.Close();

            }

        }

        void TopluKayıtSilme(int id)
        {
            string TopluSilme = "delete from Yön_Calismaproje where id=@id";
            SqlCommand TopluSilmeKomutu = new SqlCommand(TopluSilme, Baglanti);
            TopluSilmeKomutu.Parameters.AddWithValue("id", @id);
            Baglanti.Open();
            TopluSilmeKomutu.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void btn_Toplukayıtsil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_ÜyeBilgileri.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                TopluKayıtSilme(id);
            }
            Tablolustur();
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
            lbl_ÜyelikbitişHesapla.Text = dateTime_Uyelikbaslangıç.Text.Substring(15);

            Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            Uyebitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value.ToShortDateString());
            Hesapla = Uyebitis - Uyebaslangic;
            lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());

        }


        private void dateTime_Uyeliksüresibitis_ValueChanged(object sender, EventArgs e)
        {
            lbl_usbb.Text = dateTime_Uyeliksüresibitis.Value.ToString();
        }

        private void txt_Tc_TextChanged(object sender, EventArgs e)
        {
            txt_Tc.MaxLength = 11;   
         
        }

        private void txt_Yas_TextChanged(object sender, EventArgs e)
        {
            txt_Yas.MaxLength = 3;
        }

        private void txt_Kilo_TextChanged(object sender, EventArgs e)
        {
            txt_Kilo.MaxLength = 10;
        }

        private void txt_Boy_TextChanged(object sender, EventArgs e)
        {
            txt_Boy.MaxLength = 5;
          
        }

        private void txt_Boy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            }
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
            //DateTime Uyebaslangic;
            //DateTime Uyebitis;
            //TimeSpan Hesapla;
            //DateTime Dogumtarihi;
            //Uyebaslangic = Convert.ToDateTime(dateTime_Uyelikbaslangıç.Value.ToShortDateString());
            //Uyebitis = Convert.ToDateTime(dateTime_Uyeliksüresibitis.Value.ToShortDateString());
            //Dogumtarihi = Convert.ToDateTime(dateTime_DogumTarihi.Value.ToString());
            //Hesapla = Uyebitis - Uyebaslangic;
            //lbl_ÜyelikbitişHesapla.Text = (Hesapla.ToString());

            //string datee1 = Uyebaslangic.ToString();
            //string datee2 = Uyebitis.ToString();

            //string dtarihh = Dogumtarihi.ToString();

            //Baglanti.Open();

          
            //SqlCommand GüncelleKomut = new SqlCommand("update Yön_CalismaProje set Tc='" + txt_Tc.Text + "' ,Ad='" + txt_Ad.Text + "', Soyad='" + txt_Soyad.Text + "' ,Yas='" + txt_Yas.Text + "'  ,Dogum_Tarihi='" + dtarihh + "',Kilo='" + txt_Kilo.Text + "',Boy='" + txt_Boy.Text + "' ,Uyelik_Suresibaslangic='" + datee1 + "',Uyelik_Suresibitis='" + datee2 + "' ,Uyelik_Kalansüre='" + lbl_ÜyelikbitişHesapla.Text + "'where id = '"+datagrid_ÜyeBilgileri.CurrentRow.Cells[0].Value.ToString()+"'", Baglanti);
            
            //GüncelleKomut.ExecuteNonQuery();
            //ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");
            //Baglanti.Close();
        }
    }
}

