using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace ProjeSite
{
    public partial class MasterSporBolumuAdmin : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSporBolumuOlustur_ServerClick(object sender, EventArgs e)
        {
            string isim = Guid.NewGuid().ToString();
            if (FileUpload1.HasFile)//Kullanıcı fileupload ile bir dosya seçmiş ise işlemleri gerçekleştir.
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg") //Sadece jpeg dosyalarını yüklenmesine izin veriyoruz.
                {
                    if (FileUpload1.PostedFile.ContentLength < 1024000) //Maksimum 1MB'lık dosyaların yüklenmesine izin veriyoruz.
                    {

                        //Benzersiz bir isim oluşturduk.İsimlendirme için farklı yöntemlerde kullanabilirsiniz.
                        FileUpload1.SaveAs(Server.MapPath("~/SporSalonuBolum/") + isim + ".jpg");
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


            if (SporBolumListesi.Text == "")
            {
                Msg.Show("Lütfen bir spor bölümü seçiniz.");
            }
            else
            {
                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  SporBolumu_tbl(SporBolumu,Resim) VALUES (@SporBolumu,@Resim)", baglan);
                sqlsorgu.Parameters.AddWithValue("@SporBolumu", SporBolumListesi.Text);            
                sqlsorgu.Parameters.AddWithValue("@Resim", isim + ".jpg");
                sqlsorgu.ExecuteNonQuery();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;MasterSporBolumuTablosu.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show(" İşlem Başarıyla Gerçekleştirildi");
               
            }


        }    
    }


}