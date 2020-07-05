using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProjeSite
{
    public partial class SporSalonPencere1 : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CalisanBilgileriTablosu();
                HakkımızdaGenelBilgilerTablosu();
                KampanyaGetir();
                SporBolumuGetir();
                CalismaSaatiGetir();
            }
            catch
            {

            }
           
        }

        void CalismaSaatiGetir()
        {
            SqlConnection baglan = this.veri.baglan();
            DataRow dtveri = veri.GetDataRow("select * from Calisma_Saatleri");

            HaftaiciSaati.InnerText = dtveri["Cs_Haftaici_Saat"].ToString();
            CumartesiSaati.InnerText = dtveri["HaftaSonu_Cs_Saat"].ToString();
            PazargünüSaati.InnerText = dtveri["HaftaSonu_Pz_Saat"].ToString();
        }

        void CalisanBilgileriTablosu()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter da = new SqlDataAdapter("Select Calisan_Ad,Calisan_Soyad,Resim,Calisan_Hakkinda,E_mail,Calisan_Brans From Calisan_tbl ", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            RepaterList.DataSource = dt;
            RepaterList.DataBind();
           
        }
        void HakkımızdaGenelBilgilerTablosu()
        {
            SqlConnection baglan = this.veri.baglan();
            DataRow dtveri = veri.GetDataRow("select Hakkimizda from  Genel_Bilgiler_tbl");
          

            HakkımızdaP.InnerText = dtveri["Hakkimizda"].ToString();
       

        }
        void KampanyaGetir()
        {
            SqlConnection baglan = this.veri.baglan();
            DataRow dtveri = veri.GetDataRow("select KampanyaBilgisi,KampanyaAdı from Kampanyalar_tbl where Kampanya_Aktif_Pasif=1");

            kampanyaAdı.InnerText = dtveri["KampanyaAdı"].ToString();
            kampanyaBilgisi.InnerText = dtveri["KampanyaBilgisi"].ToString();
           
            
            
        }
        void SporBolumuGetir()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter da = new SqlDataAdapter("Select SporBolumu,Resim From SporBolumu_tbl ", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SporBolumuRepater.DataSource = dt;
            SporBolumuRepater.DataBind();
        }

    }
}