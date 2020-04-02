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
    public partial class ÜyeBilgileri : Form
    {
        SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        public ÜyeBilgileri()
        {
            InitializeComponent();
        }
      
        void Tablolustur2()
        {
            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Program_Bilgileri where Program_Bilgileri.No like '" + lbl_Blgid.Text + "%'", Baglantim);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Ölcüm.DataSource = sqlVerialma;
            Baglantim.Close();
        }
        void Tablolustur3()
        {
            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Hareket_Beslenme where Hareket_Beslenme.No like '" + lbl_Blgid.Text + "%'", Baglantim);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Program.DataSource = sqlVerialma;
            Baglantim.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ÜyeBilgileri_Load(object sender, EventArgs e)
        {

            lbl_usbb.Text = dateTime_Programbaslangic.Value.ToString();
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString();
            Tablolustur2();
            Tablolustur3();
            


        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
            DateTime lbl_usbts2 = Convert.ToDateTime(lbl_usbts.Text);

            if (lbl_usbb.Text == lbl_usbts.Text)
            {
                MessageBox.Show("Başlangıç tarihi ile bitiş tarihi aynı olamaz.");
            }
            else if (lbl_usbb2 > lbl_usbts2)
            {

                MessageBox.Show("Bitiş tarihi Başlangıç tarihinden daha küçük olamaz", "Uyarı");
            }
            else if (List_Sporprogrami.Items.Count != 0 && List_Beslenmeprogrami.Items.Count != 0)
            {


                string sql = "INSERT  INTO Hareket_Beslenme (No,Program_Baslangic,Program_Bitis,Program_Kalansure,Yapilacak_Hareketler,Beslenme_Programi) VALUES (@No,@Program_Baslangic,@Program_Bitis,@Program_Kalansure,@Yapilacak_Hareketler,@Beslenme_Programi)";
                string date1 = dateTime_Programbaslangic.Value.ToString();
                string date2 = dateTime_Programbitis.Value.ToString();

                string sporProgrami = "";
                string beslenmeProgrami = "";
                int i = 0;
                foreach (string deneme in List_Sporprogrami.Items)
                {
                    sporProgrami += List_Sporprogrami.Items[i] + ",";
                    i++;
                }
                int x = 0;
                foreach (string deneme in List_Beslenmeprogrami.Items)
                {
                    beslenmeProgrami += List_Beslenmeprogrami.Items[x] + ",";
                    x++;
                }

                SqlCommand komut2;
                string beslenmeDeneme;
                beslenmeDeneme = List_Beslenmeprogrami.Items.ToString();


               
                    komut2 = new SqlCommand(sql, Baglantim);
                    komut2.Parameters.AddWithValue("Program_Baslangic", date1);
                    komut2.Parameters.AddWithValue("Program_Bitis", date2);
                    komut2.Parameters.AddWithValue("@Program_Kalansure", lbl_Programsurehesapla.Text);
                    komut2.Parameters.AddWithValue("@No", lbl_Blgid.Text);
                    komut2.Parameters.AddWithValue("@Yapilacak_Hareketler", sporProgrami);
                    komut2.Parameters.AddWithValue("@Beslenme_Programi", beslenmeProgrami);
                    Baglantim.Open();
                    komut2.ExecuteNonQuery();
                    Baglantim.Close();
                    i = 0;
                
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Listbox' ta Veri Yok");
            }



            //ProgramKomut.ExecuteNonQuery();
            //Baglantim.Close();
            Tablolustur3();

        }

        private void dataGrid_Programbilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            List_Sporprogrami.Text = dataGrid_Ölcüm.CurrentRow.Cells[0].Value.ToString();
            List_Beslenmeprogrami.Text = dataGrid_Ölcüm.CurrentRow.Cells[1].Value.ToString();
            dateTime_Programbaslangic.Text = dataGrid_Ölcüm.CurrentRow.Cells[2].Value.ToString();
            dateTime_Programbitis.Text = dataGrid_Ölcüm.CurrentRow.Cells[3].Value.ToString();
            lbl_Programsurehesapla.Text = dataGrid_Ölcüm.CurrentRow.Cells[4].Value.ToString();
            txt_Blgkilo.Text = dataGrid_Ölcüm.CurrentRow.Cells[5].Value.ToString();
            txt_Blgboy.Text = dataGrid_Ölcüm.CurrentRow.Cells[6].Value.ToString();
            txt_Blgsu.Text = dataGrid_Ölcüm.CurrentRow.Cells[7].Value.ToString();
            txt_Kasoranı.Text = dataGrid_Ölcüm.CurrentRow.Cells[8].Value.ToString();
            txt_Blgyagorani.Text = dataGrid_Ölcüm.CurrentRow.Cells[9].Value.ToString();

        }

        private void btn_Sporprog_Click(object sender, EventArgs e)
        {
            if (txt_Sporekle.Text == "" || txt_Sporekle.Text == null)
            {
                MessageBox.Show("Spor programı listesine boş bilgi ekleyemezsiniz !", "Uyarı");
            }
            else
            {
                List_Sporprogrami.Items.Add(txt_Sporekle.Text);
                txt_Sporekle.Clear();
            }
        }

        private void btn_Beslenmeprog_Click(object sender, EventArgs e)
        {
            if(txt_Beslenmeekle.Text == "" || txt_Beslenmeekle.Text == null)
            {
                MessageBox.Show("Beslenme programı listesine boş bilgi ekleyemezsiniz !", "Uyarı");
            }
            else
            {
            List_Beslenmeprogrami.Items.Add(txt_Beslenmeekle.Text);
            txt_Beslenmeekle.Clear();
            }
            

           
        }

        private void btn_Ölcüm_Click(object sender, EventArgs e)
        {
            DateTime lbl_usbb2 = Convert.ToDateTime(lbl_usbb.Text);
            DateTime lbl_usbts2 = Convert.ToDateTime(lbl_usbts.Text);

            if (lbl_usbb.Text == lbl_usbts.Text)
            {
                MessageBox.Show("Başlangıç tarihi ile bitiş tarihi aynı olamaz.");
            }
            else if (lbl_usbb2 > lbl_usbts2)
            {

                MessageBox.Show("Bitiş tarihi Başlangıç tarihinden daha küçük olamaz", "Uyarı");
            }


            else
            {

                DateTime Programbaslangic;
                DateTime Programbitis;
                TimeSpan Programsurehesapla;

                Programbaslangic = Convert.ToDateTime(dateTime_Programbaslangic.Value.ToShortDateString());
                Programbitis = Convert.ToDateTime(dateTime_Programbitis.Value.ToShortDateString());

                Programsurehesapla = Programbitis - Programbaslangic;
                lbl_Programsurehesapla.Text = (Programsurehesapla.ToString());
            

                if (lbl_Programsurehesapla.Text == "" || txt_Blgkilo.Text == "" || txt_Blgboy.Text == "" || txt_Blgsu.Text == "" || txt_Kasoranı.Text == "" || txt_Blgyagorani.Text == "")
            {
                MessageBox.Show("Lütfen Bütün bilgilerinizi giriniz");
            }
            else
            {
                    Baglantim.Open();

                    string date1 =  Programbaslangic.ToString();
                string date2 = Programbitis.ToString();

                SqlCommand ProgramKomut = new SqlCommand("INSERT INTO Program_Bilgileri (No , Program_Baslangic , Program_Bitis , Program_KalanSure , Kilo , Boy , Su_Orani , Kas_Orani , Yag_Orani ) VALUES (@No,  @Program_Baslangic , @Program_Bitis , @Program_KalanSure , @Kilo , @Boy , @Su_Orani , @Kas_Orani , @Yag_Orani)", Baglantim);

                ProgramKomut.Parameters.AddWithValue("@No", lbl_Blgid.Text);
                ProgramKomut.Parameters.AddWithValue("@Program_Baslangic", date1);
                ProgramKomut.Parameters.AddWithValue("@Program_Bitis", date2);
                ProgramKomut.Parameters.AddWithValue("@Program_KalanSure", lbl_Programsurehesapla.Text);
                ProgramKomut.Parameters.AddWithValue("@Kilo", txt_Blgkilo.Text);
                ProgramKomut.Parameters.AddWithValue("@Boy", txt_Blgboy.Text);
                ProgramKomut.Parameters.AddWithValue("@Su_Orani", txt_Blgsu.Text);
                ProgramKomut.Parameters.AddWithValue("@Kas_Orani", txt_Kasoranı.Text);
                ProgramKomut.Parameters.AddWithValue("@Yag_Orani", txt_Blgyagorani.Text);

                ProgramKomut.ExecuteNonQuery();               

                    Tablolustur2();
                    Baglantim.Close();

                     }

            }          
          
        }

       

        void Yenile(String ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri, Baglantim);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            dataGrid_Ölcüm.DataSource = ds.Tables[0];
            
        }
        void Yenile2(String ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri, Baglantim);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            dataGrid_Program.DataSource = ds.Tables[0];
        }
        private void btn_Datagridyenile_Click(object sender, EventArgs e)
        {
            Yenile("SELECT * from Program_Bilgileri where Program_Bilgileri.No like '" + lbl_Blgid.Text + "%'");
            Yenile2("SELECT * from Hareket_Beslenme where Hareket_Beslenme.No like '" + lbl_Blgid.Text + "%'");
         
        }

        void SecerekSil(int Kullanici_İd){
            string Sil = "DELETE FROM Hareket_Beslenme WHERE No=@No";
             SqlCommand Komut = new SqlCommand(Sil, Baglantim);
            Komut.Parameters.AddWithValue("@No",Kullanici_İd);
            Baglantim.Open();
            Komut.ExecuteNonQuery();
            Baglantim.Close();
            }

        void SecerekSil2(int Kullanici_İd)
        {
            string Sil2 = "DELETE FROM Program_Bilgileri WHERE No=@No";
            SqlCommand Komut = new SqlCommand(Sil2, Baglantim);
            Komut.Parameters.AddWithValue("@No", Kullanici_İd);
            Baglantim.Open();
            Komut.ExecuteNonQuery();
            Baglantim.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGrid_Program.SelectedRows)  //Seçili Satırları Silme
            {
                int No = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil(No);
            }
            foreach (DataGridViewRow drow in dataGrid_Ölcüm.SelectedRows)  //Seçili Satırları Silme
            {
                int No2 = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil2(No2);
            }

        }


        private void List_Sporprogrami_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BlgYas_TextChanged(object sender, EventArgs e)
        {
            txt_BlgYas.MaxLength = 3;
        }

        private void txt_Blgkilo_TextChanged(object sender, EventArgs e)
        {
            txt_Blgkilo.MaxLength = 10;
        }

        private void txt_Blgboy_TextChanged(object sender, EventArgs e)
        {
            txt_Blgboy.MaxLength = 5;
        }

      

        private void txt_Blgyagorani_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            }
        }

        private void txt_Sporekle_TextChanged(object sender, EventArgs e)
        {
            txt_Sporekle.MaxLength = 30;
        }

        private void txt_Beslenmeekle_TextChanged(object sender, EventArgs e)
        {
            txt_Beslenmeekle.MaxLength = 30;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Blgid_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_Programbitis_ValueChanged(object sender, EventArgs e)
        {
           lbl_usbts.Text = dateTime_Programbitis.Value.ToString();

        }

        private void txt_Kasoranı_TextChanged(object sender, EventArgs e)
        {
            txt_Kasoranı.MaxLength = 5;
        }

        private void txt_Blgyagorani_TextChanged(object sender, EventArgs e)
        {
            txt_Blgyagorani.MaxLength = 5;
        }

        private void txt_Blgsu_TextChanged(object sender, EventArgs e)
        {
            txt_Blgsu.MaxLength = 5;
        }

        private void txt_Blgboy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            }
        }

        private void txt_BlgYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }

         }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {

            Baglantim.Open();
            //txt_Blgboy.Text = dataGrid_Ölcüm.CurrentRow.Cells["Boy"].Value.ToString();
            //txt_Blgsu.Text = dataGrid_Ölcüm.CurrentRow.Cells["Su_Orani"].Value.ToString();
            //txt_Kasoranı.Text = dataGrid_Ölcüm.CurrentRow.Cells["Kas_Orani"].Value.ToString();
            //txt_Blgyagorani.Text = dataGrid_Ölcüm.CurrentRow.Cells["Yag_Orani"].Value.ToString();


            SqlCommand GüncelleKomut = new SqlCommand("update Program_Bilgileri set Program_Baslangic='" + dataGrid_Ölcüm.CurrentRow.Cells[1].Value.ToString() + "' ,Program_Bitis='" + dataGrid_Ölcüm.CurrentRow.Cells[2].Value.ToString() + "', Program_KalanSure='" + dataGrid_Ölcüm.CurrentRow.Cells[3].Value.ToString() + "' ,Kilo='" + dataGrid_Ölcüm.CurrentRow.Cells[4].Value.ToString() + "'  ,Boy='" + dataGrid_Ölcüm.CurrentRow.Cells[5].Value.ToString() + "',Su_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells[6].Value.ToString() + "',Kas_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells[7].Value.ToString() + "' ,Yag_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells[8].Value.ToString() +  "'where No = '" + dataGrid_Ölcüm.CurrentRow.Cells[0].Value.ToString() + "'", Baglantim);
            GüncelleKomut.ExecuteNonQuery();
            Baglantim.Close();

        }
    }
}