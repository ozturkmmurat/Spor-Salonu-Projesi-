using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace ProjeSite
{
    public partial class MasterCalisanlar : System.Web.UI.Page
    {

        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void fotografYukle_Click(object sender, EventArgs e)
        {


        }



        protected void CalisanOlustur_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)//Kullanıcı fileupload ile bir dosya seçmiş ise işlemleri gerçekleştir.
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg") //Sadece jpeg dosyalarını yüklenmesine izin veriyoruz.
                {
                    if (FileUpload1.PostedFile.ContentLength < 2024000) //Maksimum 1MB'lık dosyaların yüklenmesine izin veriyoruz.
                    {
                        string isim = Guid.NewGuid().ToString();
                        //Benzersiz bir isim oluşturduk.İsimlendirme için farklı yöntemlerde kullanabilirsiniz.
                        FileUpload1.SaveAs(Server.MapPath("/image/CalisanFoto/") + isim + ".jpeg");
                        //Sunucuda ki resimler klasörünün içerisine seçilen resmi oluşturduğumuz benzersiz isim ile kaydediyoruz.
                        lblMesaj.Text = "Dosya yüklendi. Alınan dosyanın detayları:<br>" +
                            "Dosya Türü:" + FileUpload1.PostedFile.ContentType + "<br>" +
                            "Dosya Boyutu:" + FileUpload1.PostedFile.ContentLength;
                        //Detaylı bir bilgi mesajı verdik.  
                        //Baglanti.Open();
                        //SqlCommand Komut = new SqlCommand("update  Calisan_tbl set Resim=@Resim ", Baglanti);
                        /*Komut.Parameters.AddWithValue("@Resim", "/image/CalisanFoto"+FileUpload1.FileName)*/;
                        //Baglanti.Close();
                    }
                    else
                        lblMesaj.Text = "Dsya boyutu maximum 2MB olmalıdır.";
                }
                else
                    lblMesaj.Text = "Sadece jpeg uzantılı dosyalar yüklenebilir.";
            }
            else
                lblMesaj.Text = "Lütfen bir dosya seçiniz.";


            if (CalisanAdi.Value == "" || email_Calisan.Value == "" || hakkinda_Calisan.Value == "" || CalisanSoyadi.Value == "")
            {
                Msg.Show("Lütfen Çalışan Bilgileri Eksiksiz Giriniz !");
            }
            else
            {
                Baglanti.Open();

                SqlCommand Komut = new SqlCommand("INSERT INTO  Calisan_tbl(Calisan_Ad,Calisan_Soyad,E_mail,Calisan_Hakkinda,Resim) VALUES (@Calisan_Ad,@Calisan_Soyad,@E_mail,@Calisan_Hakkinda,@Resim)", Baglanti);
                Komut.Parameters.AddWithValue("@Calisan_Ad", CalisanAdi.Value);
                Komut.Parameters.AddWithValue("@Calisan_Soyad", CalisanSoyadi.Value);
                Komut.Parameters.AddWithValue("@E_mail", email_Calisan.Value);
                Komut.Parameters.AddWithValue("@Calisan_Hakkinda", hakkinda_Calisan.Value);
                Komut.Parameters.AddWithValue("@Resim", "/image/CalisanFoto" + FileUpload1.FileName);
                Msg.Show("Kayıt Başarıyla Oluşturuldu.");
                Komut.ExecuteNonQuery();
                Baglanti.Close();
            }

        }

    }
    }

        
        

    

  
    



    
    

