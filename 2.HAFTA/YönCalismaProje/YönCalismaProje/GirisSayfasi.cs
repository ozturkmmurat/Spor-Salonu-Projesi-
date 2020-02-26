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

    public partial class GirisSayfasi : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        public string kullanici, sifre;

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
         SqlCommand  komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "SELECT * FROM Üye_Giris where Kullanici_Adi='" + txt_KullaniciAdi.Text + "' AND Kullanici_Sifre='" + txt_Sifre.Text + "'";
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                ÜyeKayit ÜyekayıtSayfası = new  ÜyeKayit();
                ÜyekayıtSayfası.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }

        private void btn_YoneticiEkle_Click(object sender, EventArgs e)
        {
            YoneticiOlustur YoneticiOlusturmaSayfasi = new YoneticiOlustur();
            YoneticiOlusturmaSayfasi.Show();
            this.Hide();
        }
    }
}
