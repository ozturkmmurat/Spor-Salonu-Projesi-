﻿using System;
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
    public partial class SporProgramıOlustur : Form
    {
        public SporProgramıOlustur()
        {
            InitializeComponent();
        }
        public static string idtut;
        public static string sporHarketidtut;
        SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        string sporProgrami = "";

        private void SporProgramıOlustur_Load(object sender, EventArgs e)
        {
            lbl_usbb.Visible = false;
            lbl_usbts.Visible = false;
            lbl_Programsurehesapla.Visible = false;
            dateTime_Programbaslangic.Visible = false;
            lbl_usbb.Text = dateTime_Programbaslangic.Value.ToString("ddd, MMM d, yyyy"); ;
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString("ddd, MMM d, yyyy"); ;
            Tablolustur();
        }

        void Tablolustur()
        {
            idtut = idtut.ToString();


            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT No,Spor_Gun,Program_Baslangic,Program_Bitis,Program_Kalansure,Yapilacak_Hareketler from Spor_Programı_tbl where Spor_Programı_tbl.id like '" + idtut.ToString() + "%'", Baglantim);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Program.DataSource = sqlVerialma;
            Baglantim.Close();

        }
        //void SporHareketidYakala()
        //{
        //    SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        //    Baglantim.Open();
        //    SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT No from Spor_Programı_tbl where Spor_Programı_tbl.id like '" + sporHarketidtut.ToString() + "%'", Baglantim);
        //    DataTable sqlVerialma = new DataTable();
        //    sqlVericekme.Fill(sqlVerialma);          
        //    Baglantim.Close();
        //}

        private void btn_Sporprog_Click(object sender, EventArgs e)
        {
            if (txt_Sporekle.Text == "" || txt_Sporekle.Text == null )
            {
                MessageBox.Show("Beslenme programı listesine boş bilgi ekleyemezsiniz !", "Uyarı");
            }
            else
            {
                List_SporProgrami.Items.Add(txt_Sporekle.Text);
                txt_Sporekle.Clear();
            }
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
            else
            {


                string sql = "INSERT  INTO Spor_Programı_tbl (id,Spor_Gun,Program_Baslangic,Program_Bitis,Program_Kalansure,Yapilacak_Hareketler) VALUES (@id,@Spor_Gun,@Program_Baslangic,@Program_Bitis,@Program_Kalansure,@Yapilacak_Hareketler)"; /*select ident_current('Spor_Programı_tbl')*/
                string date1 = dateTime_Programbaslangic.Value.ToString("ddd, MMM d, yyyy"); ;
                string date2 = dateTime_Programbitis.Value.ToString("ddd, MMM d, yyyy"); ;

                string sqlSporKontrol = "INSET INTO SporProgramı_Kontrol_tbl (id,Yapilacak_Hareket) VALUES (@id,@Yapilacak_Hareket)";




                int i = 0;
                foreach (string deneme in List_SporProgrami.Items)
                {
                    sporProgrami += List_SporProgrami.Items[i] + ",";
                    i++;
                }


                SqlCommand komut2;
                SqlCommand HareketKontrolKomut;
                string beslenmeDeneme;
                beslenmeDeneme = List_SporProgrami.Items.ToString();

                DateTime Programbaslangic;
                DateTime Programbitis;
                TimeSpan Programsurehesapla;

                Programbaslangic = Convert.ToDateTime(dateTime_Programbaslangic.Value.ToShortDateString());
                Programbitis = Convert.ToDateTime(dateTime_Programbitis.Value.ToShortDateString());

                Programsurehesapla = Programbitis - Programbaslangic;
                lbl_Programsurehesapla.Text = (Programsurehesapla.ToString());
                if (comboBox_Gun.Text == "")
                {
                    MessageBox.Show("Lütfen Gün tekrarını seçiniz");
                }
              
                else
                {
                    komut2 = new SqlCommand(sql, Baglantim);
                    Baglantim.Open();
                    komut2.Parameters.AddWithValue("id", idtut.ToString());
                    komut2.Parameters.AddWithValue("@Spor_Gun", comboBox_Gun.Text);
                    komut2.Parameters.AddWithValue("Program_Baslangic", date1);
                    komut2.Parameters.AddWithValue("Program_Bitis", date2);
                    komut2.Parameters.AddWithValue("@Program_Kalansure", lbl_Programsurehesapla.Text);
                    komut2.Parameters.AddWithValue("@Yapilacak_Hareketler", sporProgrami);
                   
                    komut2.ExecuteNonQuery();
                    //int id = Convert.ToInt16(komut2.ExecuteScalar());
                    //MessageBox.Show("Son eklenen kimlik:" + id);
                    //sporHarketidtut = Convert.ToString(komut2.Parameters["@No"]);

                    //string[] SporHareketi = sporProgrami.Split(',');
                    //HareketKontrolKomut = new SqlCommand(sql, Baglantim);
                    //HareketKontrolKomut.Parameters.AddWithValue("No", sporHarketidtut.ToString());
                    //int id = Convert.ToInt16(komut2.ExecuteScalar());
                    //MessageBox.Show("Son eklenen kimlik:" + id);
                    Baglantim.Close();
                  
                    MessageBox.Show("Kayıt Eklendi");
                }

            }             
                Tablolustur();
             sporProgrami = "";
            List_SporProgrami.Items.Clear();

        }

        private void dataGrid_Program_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTime_Programbitis_ValueChanged(object sender, EventArgs e)
        {
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString("ddd, MMM d, yyyy");
        }

        void SecerekSil(int Kullanici_İd)
        {
            SqlCommand komut;
            string sql = "DELETE FROM Spor_Programı_tbl WHERE No=@No";
            komut = new SqlCommand(sql, Baglantim);
            komut.Parameters.AddWithValue("@No", Kullanici_İd);
            Baglantim.Open();
            komut.ExecuteNonQuery();
            Baglantim.Close();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGrid_Program.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil(numara);

            }
            Tablolustur();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Baglantim.Open();
            SqlCommand GüncelleKomut = new SqlCommand("update Spor_Programı_tbl set Program_Baslangic='" + dataGrid_Program.CurrentRow.Cells["Program_Baslangic"].Value.ToString() + "' ,Program_Bitis='" + dataGrid_Program.CurrentRow.Cells["Program_Bitis"].Value.ToString() + "', Program_KalanSure='" + dataGrid_Program.CurrentRow.Cells["Program_KalanSure"].Value.ToString() + "' ,Yapilacak_Hareketler='" + dataGrid_Program.CurrentRow.Cells["Yapilacak_Hareketler"].Value.ToString() + "'where No = '" + dataGrid_Program.CurrentRow.Cells[0].Value.ToString() + "'", Baglantim);
            GüncelleKomut.ExecuteNonQuery();
            Baglantim.Close();
        }
    }
}
