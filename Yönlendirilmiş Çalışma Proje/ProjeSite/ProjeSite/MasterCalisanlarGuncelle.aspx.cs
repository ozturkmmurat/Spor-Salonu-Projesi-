using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Web.UI.HtmlControls;

namespace ProjeSite
{
    public partial class MasterCalisanlar : System.Web.UI.Page
    {

        baglanti veri = new baglanti();

      

        int deneme = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
           


           
            Txt_Calisan_DogumTarih.Attributes.Add("autocomplete", "off");
            lbl_CalisanidGetir.Text = Request.QueryString["id"];
            try
            {
                if (!Page.IsPostBack)
                {
                    if (deneme == 0)
                    {
                        SqlConnection baglan = this.veri.baglan();
                        SqlDataAdapter da = new SqlDataAdapter("Select Resim From Calisan_tbl ", baglan);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                         

                        DataRow dtveri = veri.GetDataRow("select Calisan_TcNo,Calisan_Ad,Calisan_Soyad,Calisan_Tel,Calisan_Adres,E_mail,Calisan_Hakkinda,Resim,Calisan_DogumTarh,Calisan_Brans from Calisan_tbl where id like '" + lbl_CalisanidGetir.Text.ToString() + "'");
                        string Tc = dtveri["Calisan_TcNo"].ToString();
                        Calisan_Tc.Value = Tc.ToString();
                        string kullaniciadi = dtveri["Calisan_Ad"].ToString();
                        CalisanAdi.Value = kullaniciadi.ToString();
                        string KullaniciSoyadi = dtveri["Calisan_Soyad"].ToString();
                        CalisanSoyadi.Value = KullaniciSoyadi.ToString();
                        string TelNo = dtveri["Calisan_Tel"].ToString();
                        Calisan_Tel.Value = TelNo.ToString();
                        string Adres = dtveri["Calisan_Adres"].ToString();
                        Calisan_Adres.Value = Adres.ToString();
                        string KullaniciEmail = dtveri["E_mail"].ToString();
                        email_Calisan.Value = KullaniciEmail.ToString();
                        string KullaniciHakkinda = dtveri["Calisan_Hakkinda"].ToString();
                        hakkinda_Calisan.Value = KullaniciHakkinda.ToString();
                        string Fotograf = "CalisanFoto/" + dtveri["Resim"].ToString();
                        FotoCalisan.Src = Fotograf.ToString();
                        string calisanDgTarih = dtveri["Calisan_DogumTarh"].ToString();
                        Txt_Calisan_DogumTarih.Text = calisanDgTarih.ToString();
                        List_Brans.SelectedValue = dtveri["Calisan_Brans"].ToString();
                         

                    }
                }
                
            }
            catch
            {
                Msg.Show("Error 404!");
            }                
            
          
         


        }

                
        //   void doldur()
        //{
        //    if (lbl_CalisanidGetir.Text != "")
        //    {
        //        DataRow dtveri = veri.GetDataRow("select * from Calisan_tbl where id like '" + lbl_CalisanidGetir.Text.ToString() + "'");
        //        string Tc = dtveri["Calisan_TcNo"].ToString();
        //        Calisan_Tc.Value = Tc.ToString();
        //        string kullaniciadi = dtveri["Calisan_Ad"].ToString();
        //        CalisanAdi.Value = kullaniciadi.ToString();
        //        string KullaniciSoyadi = dtveri["Calisan_Soyad"].ToString();
        //        CalisanSoyadi.Value = KullaniciSoyadi.ToString();
        //        string TelNo = dtveri["Calisan_Tel"].ToString();
        //        Calisan_Tel.Value = TelNo.ToString();
        //        string Adres = dtveri["Calisan_Adres"].ToString();
        //        Calisan_Adres.Value = Adres.ToString();
        //        string KullaniciEmail = dtveri["E_mail"].ToString();
        //        email_Calisan.Value = KullaniciEmail.ToString();
        //        string KullaniciHakkinda = dtveri["Calisan_Hakkinda"].ToString();
        //        hakkinda_Calisan.Value = KullaniciHakkinda.ToString();
        //    }
        //}
          

        protected void fotografYukle_Click(object sender, EventArgs e)
        {
         

        }

        protected void deneme_Click(object sender, EventArgs e)
        {
            
            //SqlConnection baglan = this.veri.baglan();
            //SqlCommand GüncelleKomut = new SqlCommand("update Calisan_tbl set  Calisan_TcNo = '" + Calisan_Tc.Value + "' ,Calisan_Ad ='" + CalisanAdi.Value + "' ,Calisan_Soyad='" + CalisanSoyadi.Value + "',Calisan_Tel='" + Calisan_Tel.Value +
            //      "',Calisan_DogumTarh='" + Txt_Calisan_DogumTarih.Text + "', E_mail='" + email_Calisan.Value + "' ,Calisan_Hakkinda='" + hakkinda_Calisan.Value + "' ,Calisan_Adres='" + Calisan_Adres.Value + "' where id = '" + lbl_CalisanidGetir.Text + "'", baglan);

            //GüncelleKomut.ExecuteNonQuery();
            //baglan.Close();
            
        }

        protected void CalisanDüzenle_Click(object sender, EventArgs e)
        {
            //Session["Image"] = FileUpload1.PostedFile;
            //Stream fs = FileUpload1.PostedFile.InputStream;
            //BinaryReader br = new BinaryReader(fs);
            //byte[] bytes = br.ReadBytes((Int32)fs.Length);
            //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            //FotoCalisan.Src = "data:image/png;base64," + base64String;
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
                Msg.Show("Lütfen bir doya seçiniz");


            //lblMesaj.Text = "b";

            SqlConnection baglan = this.veri.baglan();
            if (Calisan_Tc.Value == "" || CalisanAdi.Value == "" || CalisanSoyadi.Value == "" || Calisan_Tel.Value == "" || Txt_Calisan_DogumTarih.Text == "" || Calisan_Adres.Value == "" || email_Calisan.Value == "" || hakkinda_Calisan.Value == "" || List_Brans.SelectedValue=="" || isim.ToString() =="" || List_Brans.SelectedValue == "")
            {
                Msg.Show("Lütfen bilgilerini güncellemek istediğiniz kişinin bilgilerini eksiksiz giriniz !!!");
            }
            else if (List_Brans.Text == "Lütfen Listeden Branş Seçiniz")
            {
                Msg.Show("Lütfen Branş Seçiniz");
            }
            else if (Calisan_Tc.Value.Length < 11)
            {
                Msg.Show("Tc Kimlik bilgisini eksik girdiniz.");
            }
            else if(Calisan_Tel.Value.Length < 11)
            {
                Msg.Show("Telefon Numarasını eksik girdiniz.");
            }
            else if (lbl_CalisanidGetir.Text == "")
            {
                Msg.Show("Çalışanın İd bilgisi bulunamıyor.");
            }
            else if(Txt_Calisan_DogumTarih.Text.Length < 10)
            {
                Msg.Show("Doğum tarihini yanlış şekilde girdiniz lütfen Doğum tarihinizi bu örnekteki gibi giriniz (01.01.1999) ");
            }
           
            else
            {
                SqlCommand GüncelleKomut = new SqlCommand("update Calisan_tbl set  Calisan_TcNo = '"+ Calisan_Tc.Value + "' ,Calisan_Ad ='" + CalisanAdi.Value + "' ,Calisan_Soyad='" + CalisanSoyadi.Value + "',Calisan_Tel='" + Calisan_Tel.Value +
                  "',Calisan_DogumTarh='" + Txt_Calisan_DogumTarih.Text + "', E_mail='" + email_Calisan.Value + "' ,Calisan_Hakkinda='" + hakkinda_Calisan.Value + "' ,Calisan_Adres='" +Calisan_Adres.Value+ "' ,Resim='"+isim + ".jpg"+ "',Calisan_Brans='"+List_Brans.SelectedValue + "'  where id = '" + lbl_CalisanidGetir.Text + "'", baglan);

                GüncelleKomut.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;CalisanlarTablo.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İD = "+ lbl_CalisanidGetir.Text +" Çalışanın bilgileri güncellendi 3 saniye sonra tablo sayfasına yönlendirileceksiniz."  );

              
                

            }




        }

        }
    }

        
        

    

  
    



    
    

