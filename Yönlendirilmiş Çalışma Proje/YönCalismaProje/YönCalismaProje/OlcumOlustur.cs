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
            lbl_usbb.Text = dateTime_Programbaslangic.Value.ToString();
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString();
            Tablolustur();
        }
        void Tablolustur()
        {
            SqlConnection Baglantim = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglantim.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Program_Bilgileri where Program_Bilgileri.No like '" + idtut.ToString() + "%'", Baglantim);
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

                    string date1 = Programbaslangic.ToString();
                    string date2 = Programbitis.ToString();

                    SqlCommand ProgramKomut = new SqlCommand("INSERT INTO Program_Bilgileri (No , Program_Baslangic , Program_Bitis , Program_KalanSure , Kilo , Boy , Su_Orani , Kas_Orani , Yag_Orani ) VALUES (@No,  @Program_Baslangic , @Program_Bitis , @Program_KalanSure , @Kilo , @Boy , @Su_Orani , @Kas_Orani , @Yag_Orani)", Baglantim);

                    ProgramKomut.Parameters.AddWithValue("@No", idtut.ToString());
                    ProgramKomut.Parameters.AddWithValue("@Program_Baslangic", date1);
                    ProgramKomut.Parameters.AddWithValue("@Program_Bitis", date2);
                    ProgramKomut.Parameters.AddWithValue("@Program_KalanSure", lbl_Programsurehesapla.Text);
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
            lbl_usbts.Text = dateTime_Programbitis.Value.ToString();
        }
    }
}
