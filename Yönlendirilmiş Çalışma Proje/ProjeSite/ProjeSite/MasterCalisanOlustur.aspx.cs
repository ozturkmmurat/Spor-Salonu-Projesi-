using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProjeSite.Sayfalar
{
    public partial class MasterCalisanOlustur : System.Web.UI.Page
    {

        baglanti veri = new baglanti();

        //SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");



        protected void Page_Load(object sender, EventArgs e)
        {




            Txt_Calisan_DogumTarih.Attributes.Add("autocomplete", "off");          
            





            //Baglanti.Open();
            //SqlCommand sqlVericekme = new SqlCommand($"SELECT  Calisan_Ad,Calisan_Soyad,E_mail,Calisan_Hakkinda,Resim,@Calisan_Ad,@Calisan_Soyad,@E_mail,@Calisan_Hakkinda,@Resim from Calisan_tbl where Calisan_tbl.id like '{lbl_CalisanidGetir.Text}%'", Baglanti);
            //sqlVericekme.ExecuteNonQuery();
            //Baglanti.Close();
            //sqlVericekme.Parameters.AddWithValue("@Calisan_Ad", CalisanAdi.Value);

            //CalisanAdi.Value = sqlVericekme.ToString();


            //= CalisanİdGöster;
        }

        protected void fotografYukle_Click(object sender, EventArgs e)
        {


        }


        //string uzanti = "";
        //string resimadi = "";
        protected void CalisanOlustur_Click(object sender, EventArgs e)
        {
            string isim = Guid.NewGuid().ToString();
            if (FileUpload1.HasFile)//Kullanıcı fileupload ile bir dosya seçmiş ise işlemleri gerçekleştir.
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg") //Sadece jpeg dosyalarını yüklenmesine izin veriyoruz.
                {
                    if (FileUpload1.PostedFile.ContentLength < 1024000) //Maksimum 1MB'lık dosyaların yüklenmesine izin veriyoruz.
                    {

                        //Benzersiz bir isim oluşturduk.İsimlendirme için farklı yöntemlerde kullanabilirsiniz.
                        FileUpload1.SaveAs(Server.MapPath("~/CalisanFoto/") + isim + ".jpg");
                        //Sunucuda ki resimler klasörünün içerisine seçilen resmi oluşturduğumuz benzersiz isim ile kaydediyoruz.


                    }
                    else
                        Msg.Show("Dosya boyutu maximum 1MB olmalıdır.");

                }
                else
                    Msg.Show("Sadece jpeg uzantılı dosyalar yüklenebilir.");

            }
            else
                Msg.Show("Lütfen bir dosya seçiniz");
        
    


            if (Calisan_Tc.Value == "" || CalisanAdi.Value == "" || CalisanSoyadi.Value == "" || Calisan_Tel.Value == "" || Txt_Calisan_DogumTarih.Text == "" || Calisan_Adres.Value == "" || email_Calisan.Value == "" || hakkinda_Calisan.Value == "" || isim=="" || List_Brans.SelectedValue =="" || isim.ToString() =="")
            {
                Msg.Show("Lütfen Çalışan Bilgileri Eksiksiz Giriniz !");
            }
            else if (List_Brans.Text== "Lütfen Listeden Branş Seçiniz")
            {
                Msg.Show("Lütfen Branş Seçiniz");
            }
           
            else if (Calisan_Tc.Value.Length < 11)
            {
                Msg.Show("Tc Kimlik bilgisini eksik girdiniz.");
            }
            else if (Calisan_Tel.Value.Length < 11)
            {
                Msg.Show("Telefon Numarasını eksik girdiniz.");
            }
           
            else if (Txt_Calisan_DogumTarih.Text.Length < 10)
            {
                Msg.Show("Doğum tarihini yanlış şekilde girdiniz lütfen Doğum tarihinizi bu örnekteki gibi giriniz (01.01.1999) ");
            }
            else
            {
                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Calisan_tbl(Calisan_TcNo,Calisan_Ad,Calisan_Soyad,Calisan_Tel,Calisan_DogumTarh,Calisan_Adres,E_mail,Calisan_Hakkinda,Resim,Calisan_Brans) VALUES (@Calisan_TcNo,@Calisan_Ad,@Calisan_Soyad,@Calisan_Tel,@Calisan_DogumTarh,@Calisan_Adres,@E_mail,@Calisan_Hakkinda,@Resim,@Calisan_Brans)", baglan);
                sqlsorgu.Parameters.AddWithValue("@Calisan_TcNo", Calisan_Tc.Value);
                sqlsorgu.Parameters.AddWithValue("@Calisan_Ad", CalisanAdi.Value);
                sqlsorgu.Parameters.AddWithValue("@Calisan_Soyad", CalisanSoyadi.Value);
                sqlsorgu.Parameters.AddWithValue("@Calisan_Tel", Calisan_Tel.Value);
                sqlsorgu.Parameters.AddWithValue("@Calisan_DogumTarh", Txt_Calisan_DogumTarih.Text);
                sqlsorgu.Parameters.AddWithValue("@Calisan_Adres", Calisan_Adres.Value);
                sqlsorgu.Parameters.AddWithValue("@E_mail", email_Calisan.Value);
                sqlsorgu.Parameters.AddWithValue("@Calisan_Hakkinda", hakkinda_Calisan.Value.ToString());
                sqlsorgu.Parameters.AddWithValue("@Resim", isim + ".jpg");
                sqlsorgu.Parameters.AddWithValue("@Calisan_Brans",List_Brans.SelectedValue);

                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                Calisan_Tc.Value = "";
                CalisanAdi.Value = "";
                CalisanSoyadi.Value = "";
                Calisan_Tel.Value = "";
                Txt_Calisan_DogumTarih.Text = "";
                Calisan_Adres.Value = "";
                email_Calisan.Value = "";
                hakkinda_Calisan.Value = "";
                List_Brans.SelectedValue = "";

                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;CalisanlarTablo.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("Çalışan Oluşturuldu 3 saniye sonra Çalışanlar tablosuna yönlendirileceksiniz");



            }
        

        }
    }
}




