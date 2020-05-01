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
    public partial class GİrisSayfasi : Form
    {
        public GİrisSayfasi()
        {
            InitializeComponent();
        }

        public string kullanici, sifre;
        private void GİrisSayfasi_Load(object sender, EventArgs e)
        {

        }

        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
     

        private void btn_GirisYap_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "SELECT * FROM Üye_Giris where Kullanici_Adi='" + txt_KullaniciAdi.Text + "' AND Kullanici_Sifre='" + txt_Sifre.Text + "'";
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                Menu MenuSayfasi = new Menu();
                MenuSayfasi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }

        private void btn_YoneticiEkle_Click_1(object sender, EventArgs e)
        {
            YoneticiOlustur YoneticiOlusturmaSayfasi = new YoneticiOlustur();
            YoneticiOlusturmaSayfasi.Show();
            this.Hide();
        }

        
    }
}
