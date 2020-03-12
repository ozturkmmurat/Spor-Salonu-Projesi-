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
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Program_Bilgileri", Baglantim);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Ölcüm.DataSource = sqlVerialma;
            Baglantim.Close();
        }
        void Tablolustur3()
        {
            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Hareket_Beslenme", Baglantim);
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
            Tablolustur2();
            Tablolustur3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btn_Olustur_Click(object sender, EventArgs e)
        {

            //SqlCommand ProgramKomut = new SqlCommand("INSERT INTO Program_Bilgileri (Yapilacak_Hareketler,Beslenme_Programi) VALUES (  @Yapilacak_Hareketler,@Beslenme_Programi)", Baglantim);

            //ProgramKomut.Parameters.AddWithValue("@Yapilacak_Hareketler", List_Sporprogrami.Text[0]);
            //ProgramKomut.Parameters.AddWithValue("@Beslenme_Programi", List_Beslenmeprogrami.Text[0]);


            //int denemem = 0;
            if (List_Sporprogrami.Items.Count != 0 && List_Beslenmeprogrami.Items.Count != 0)
            {


                string sql = "INSERT  INTO Hareket_Beslenme (No,Yapilacak_Hareketler,Beslenme_Programi) VALUES (@No,@Yapilacak_Hareketler,@Beslenme_Programi)";

                SqlCommand komut2;
                //foreach (string kategori in List_Sporprogrami.Items)
                //{
                //for (int i = 0; i < List_Sporprogrami.Items.Count; i++)
                //{
                //    for (int j = 0; j < List_Beslenmeprogrami.Items.Count; j++)
                //    {

                //        komut2 = new SqlCommand(sql, Baglantim);
                //        komut2.Parameters.AddWithValue("@Yapilacak_Hareketler", i);
                //        komut2.Parameters.AddWithValue("@Beslenme_Programi", j);
                //        Baglantim.Open();

                //        komut2.ExecuteNonQuery();
                //        Baglantim.Close();
                //    }
                //}


                foreach (string program in List_Sporprogrami.Items)
                {
                   komut2 = new SqlCommand(sql, Baglantim);
                    komut2.Parameters.AddWithValue("@No", lbl_Blgid.Text);
                    komut2.Parameters.AddWithValue("@Yapilacak_Hareketler", program);
                    komut2.Parameters.AddWithValue("@Beslenme_Programi", program);
                    Baglantim.Open();
                    komut2.ExecuteNonQuery();
                    Baglantim.Close();
                }
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
            List_Sporprogrami.Items.Add(txt_Sporekle.Text);
            txt_Sporekle.Clear();
        }

        private void btn_Beslenmeprog_Click(object sender, EventArgs e)
        {
            List_Beslenmeprogrami.Items.Add(txt_Beslenmeekle.Text);
            txt_Beslenmeekle.Clear();
        }

        private void btn_Ölcüm_Click(object sender, EventArgs e)
        {
            Baglantim.Open();
            SqlCommand ProgramKomut = new SqlCommand("INSERT INTO Program_Bilgileri (No , Program_Baslangic , Program_Bitis , Program_KalanSure , Kilo , Boy , Su_Orani , Kas_Orani , Yag_Orani ) VALUES (@No,  @Program_Baslangic , @Program_Bitis , @Program_KalanSure , @Kilo , @Boy , @Su_Orani , @Kas_Orani , @Yag_Orani)", Baglantim);

            ProgramKomut.Parameters.AddWithValue("@No", lbl_Blgid.Text);
            ProgramKomut.Parameters.AddWithValue("@Program_Baslangic", dateTime_Programbaslangic.Value);
            ProgramKomut.Parameters.AddWithValue("@Program_Bitis", dateTime_Programbitis.Value);
            ProgramKomut.Parameters.AddWithValue("@Program_KalanSure", lbl_Programsurehesapla.Text);
            ProgramKomut.Parameters.AddWithValue("@Kilo", txt_Blgkilo.Text);
            ProgramKomut.Parameters.AddWithValue("@Boy", txt_Blgboy.Text);
            ProgramKomut.Parameters.AddWithValue("@Su_Orani", txt_Blgsu.Text);
            ProgramKomut.Parameters.AddWithValue("@Kas_Orani", txt_Kasoranı.Text);
            ProgramKomut.Parameters.AddWithValue("@Yag_Orani", txt_Blgyagorani.Text);

            ProgramKomut.ExecuteNonQuery();
            Baglantim.Close();
            Tablolustur2();
        }

        private void dateTime_Programbaslangic_ValueChanged(object sender, EventArgs e)
        {

            this.Text = "22/11/2009";

            DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
        }

        private void dateTime_Programbitis_ValueChanged(object sender, EventArgs e)
        {
            this.Text = "22/11/2009";

            DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
        }

        void Yenile(String ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri, Baglantim);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            dataGrid_Program.DataSource = ds.Tables[0];
            dataGrid_Ölcüm.DataSource = ds.Tables[0];
        }
        private void btn_Datagridyenile_Click(object sender, EventArgs e)
        {
            Yenile("SELECT * FROM Hareket_Beslenme");
            Yenile("Select * FROM Program_Bilgileri");
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
            string Sil = "DELETE FROM Program_Bilgileri WHERE No=@No";
            SqlCommand Komut = new SqlCommand(Sil, Baglantim);
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
                int No = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil2(No);
            }

        }


        private void List_Sporprogrami_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BlgYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Blgkilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Blgboy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Blgboy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Blgyagorani_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Sporekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Beslenmeekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Blgid_Click(object sender, EventArgs e)
        {

        }
    }
}