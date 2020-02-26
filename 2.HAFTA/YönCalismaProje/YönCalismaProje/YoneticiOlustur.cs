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
    public partial class YoneticiOlustur : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        public YoneticiOlustur()
        {
            InitializeComponent();
        }

        private void btn_KayıtOlustur_Click(object sender, EventArgs e)
        {
            if (txt_Sifre.Text == txt_SifreTekrar.Text)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Üye_Giris(Kullanici_Adi,Kullanici_Sifre) VALUES(@Kullanici_Adi,@Kullanici_Sifre)", baglanti);
                baglanti.Open();

                MessageBox.Show("Tebrikler! Başarılı bir şekilde Kayıt oldunuz. ");
                komut.Parameters.AddWithValue("@Kullanici_Adi", txt_KullaniciAdi.Text);
                komut.Parameters.AddWithValue("@Kullanici_Sifre", txt_Sifre.Text);
                GirisSayfasi Giris_sayfasi = new GirisSayfasi();
                Giris_sayfasi.sifre = txt_Sifre.Text;
                Giris_sayfasi.kullanici = txt_KullaniciAdi.Text;
                Giris_sayfasi.Show();
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Şifre ve Şifre tekrarı uyuşmuyor lütfen kontrol ediniz !!");
            }

        }
    }
    }

