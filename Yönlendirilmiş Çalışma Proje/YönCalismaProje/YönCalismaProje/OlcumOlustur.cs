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
    public partial class OlcumOlustur : Form
    {
        public OlcumOlustur()
        {
            InitializeComponent();
        }
        public static string idtut;
        SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
       
        private void OlcumOlustur_Load(object sender, EventArgs e)
        {
            lbl_Programsurehesapla.Visible = false;
            dateTime_Programbaslangic.Visible = false;
            lbl_usbb.Visible = false;
            lbl_usbts.Visible = false;
            lbl_usbb.Text = dateTime_Programbaslangic.Value.ToString();
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString("ddd, MMM d, yyyy"); ;
            Tablolustur();

      
        }
        void Tablolustur()
        {
            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT No,Program_Bitis,Kilo,Boy,Su_Orani,Kas_Orani,Yag_Orani from Program_Bilgileri where Program_Bilgileri.id like '" + idtut.ToString() + "%'", Baglantim);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Ölcüm.DataSource = sqlVerialma;
            Baglantim.Close();
        }
        private void btn_Olcum_Click(object sender, EventArgs e)
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

           
                DateTime Programbitis;        
                Programbitis = Convert.ToDateTime(dateTime_Programbitis.Value.ToShortDateString());

              ;


                if ( txt_Blgkilo.Text == "" || txt_Blgboy.Text == "" || txt_Blgsu.Text == "" || txt_Kasoranı.Text == "" || txt_Blgyagorani.Text == "")
                {
                    MessageBox.Show("Lütfen Bütün bilgilerinizi giriniz");
                }
                else
                {
                    Baglantim.Open();

                  
                    string date2 = Programbitis.ToString("ddd, MMM d, yyyy"); ;

                    SqlCommand ProgramKomut = new SqlCommand("INSERT INTO Program_Bilgileri (id  , Program_Bitis , Kilo , Boy , Su_Orani , Kas_Orani , Yag_Orani ) VALUES (@id, @Program_Bitis  , @Kilo , @Boy , @Su_Orani , @Kas_Orani , @Yag_Orani)", Baglantim);

                    ProgramKomut.Parameters.AddWithValue("@id", idtut.ToString());              
                    ProgramKomut.Parameters.AddWithValue("@Program_Bitis", date2);
                    ProgramKomut.Parameters.AddWithValue("@Kilo", txt_Blgkilo.Text);
                    ProgramKomut.Parameters.AddWithValue("@Boy", txt_Blgboy.Text);
                    ProgramKomut.Parameters.AddWithValue("@Su_Orani", txt_Blgsu.Text);
                    ProgramKomut.Parameters.AddWithValue("@Kas_Orani", txt_Kasoranı.Text);
                    ProgramKomut.Parameters.AddWithValue("@Yag_Orani", txt_Blgyagorani.Text);

                    ProgramKomut.ExecuteNonQuery();

                    Tablolustur();
                    Baglantim.Close();

                }

            }

        }

        private void dateTime_Programbitis_ValueChanged(object sender, EventArgs e)
        {
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString("ddd, MMM d, yyyy"); ;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
           

            Baglantim.Open();
            SqlCommand GüncelleKomut = new SqlCommand("update Program_Bilgileri set Program_Bitis='" + dataGrid_Ölcüm.CurrentRow.Cells["Program_Bitis"].Value.ToString() + "' ,Kilo='" + dataGrid_Ölcüm.CurrentRow.Cells["Kilo"].Value.ToString() + "', Boy='" + dataGrid_Ölcüm.CurrentRow.Cells["Boy"].Value.ToString() + "' ,Su_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells["Su_Orani"].Value.ToString() + "' ,Kas_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells["Kas_Orani"].Value.ToString() + "' ,Yag_Orani='" + dataGrid_Ölcüm.CurrentRow.Cells["Yag_Orani"].Value.ToString() + "'where No = '" + dataGrid_Ölcüm.CurrentRow.Cells[0].Value.ToString() + "'", Baglantim);
            GüncelleKomut.ExecuteNonQuery();
            Baglantim.Close();
        }
        void SecerekSil(int Kullanici_İd)
        {
            SqlCommand komut;
            string sql = "DELETE FROM Program_Bilgileri WHERE No=@No";
            komut = new SqlCommand(sql, Baglantim);
            komut.Parameters.AddWithValue("@No", Kullanici_İd);
            Baglantim.Open();
            komut.ExecuteNonQuery();
            Baglantim.Close();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGrid_Ölcüm.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil(numara);

            }
            Tablolustur();
        }

    }
}
      
       
