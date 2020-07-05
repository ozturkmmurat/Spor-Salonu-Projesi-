using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

namespace ProjeSite
{
    public partial class SporBolumuGuncelle : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        int deneme = 0;

        string idtut;
        protected void Page_Load(object sender, EventArgs e)
        {
             idtut = Request.QueryString["id"];



            try
            {
                if (!Page.IsPostBack)
                {
                    if (deneme == 0)
                    {
                        SqlConnection baglan = this.veri.baglan();
                        SqlDataAdapter da = new SqlDataAdapter("Select SporBolumu,Resim From SporBolumu_tbl ", baglan);
                        DataTable dt = new DataTable();
                        da.Fill(dt);



                        DataRow dtveri = veri.GetDataRow("select SporBolumu,Resim from SporBolumu_Tbl where id like '" + idtut.ToString() + "'");
                        string MevcutListe = dtveri["SporBolumu"].ToString();
                        SporBolumListesi.Text = MevcutListe.ToString();

                        string Fotograf = "SporSalonuBolum/" + dtveri["Resim"].ToString();
                        FotoCalisan.Src = Fotograf.ToString();


                    }
                }

            }
            catch
            {
                Msg.Show("Error 404!");
            }

        }
        protected void btnSporBolumuGuncelle_ServerClick(object sender, EventArgs e)
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
                Msg.Show("Lütfen bir doya seçiniz");


            SqlConnection baglan = this.veri.baglan();
            if (SporBolumListesi.Text == ""  || isim.ToString() =="" )
            {
                Msg.Show("Lütfen bilgilerini güncellemek istediğiniz kişinin bilgilerini eksiksiz giriniz !!!");
            }
            else
            {
                SqlCommand GüncelleKomut = new SqlCommand("update SporBolumu_tbl set  SporBolumu = '" + SporBolumListesi.Text  +  "' ,Resim='" + isim + ".jpg" + "' where id = '" + idtut.ToString() + "'", baglan);

                GüncelleKomut.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;AktiviteGuncelle.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İD = " + idtut.ToString() + " Çalışanın bilgileri güncellendi 3 saniye sonra tablo sayfasına yönlendirileceksiniz.");

                deneme = 1;
            }
        }
    }

}
