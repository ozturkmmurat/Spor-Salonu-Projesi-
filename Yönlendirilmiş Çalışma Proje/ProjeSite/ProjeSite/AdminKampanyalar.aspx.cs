using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProjeSite
{
    public partial class AdminKampanyalar : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        string idtut = null;
        string Kampanyaidtut = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Kampanyalar_Listele();
            Aktif_Kampanya_Listele();
            idtut = Request.QueryString["Kampanyaid"];
            Kampanyaidtut = Request.QueryString["Kampanyaİdtut"];

            if (!Page.IsPostBack)
            {
                if (idtut != null)
                {



                    DataRow deneme = veri.GetDataRow("select KampanyaAdı,KampanyaBilgisi  from Kampanyalar_tbl where id like '" + idtut.ToString() + "'");
                    string KampanyaAdı = deneme["KampanyaAdı"].ToString();
                    txt_Kampanya_Adı.Value = KampanyaAdı.ToString();
                    string KampanyaBilgisi = deneme["KampanyaBilgisi"].ToString();
                    txt_kampanya_Bilgisi.Value = KampanyaBilgisi.ToString();
                    btn_Güncelle.Visible = true;


                }
            }
            if (!Page.IsPostBack)
            {
                if (Kampanyaidtut != null)
                {
                    DataRow KampanyaAktiflestir = veri.GetDataRow("select KampanyaAdı,KampanyaBilgisi from Kampanyalar_tbl where id like'" + Kampanyaidtut.ToString() + "'");
                    string KampanyaAdAktiflestir = KampanyaAktiflestir["KampanyaAdı"].ToString();
                    txt_Kampanya_Adı.Value = KampanyaAdAktiflestir.ToString();

                    string KampanyaBilgisiAktiflestir = KampanyaAktiflestir["KampanyaBilgisi"].ToString();
                    txt_kampanya_Bilgisi.Value = KampanyaBilgisiAktiflestir.ToString();

                    btn_Aktif_Pasif.Visible = true;
                }
            }

            
              
           




        }
        public void Kampanyalar_Listele()
        {

            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter Listele = new SqlDataAdapter("Select *  From Kampanyalar_tbl  where Kampanya_Aktif_Pasif =0 ", baglan);
            DataSet Ds = new DataSet();
            Listele.Fill(Ds);
            Kampanyalar_Repater.DataSource = Ds;
            Kampanyalar_Repater.DataBind();



        }
        public void Aktif_Kampanya_Listele()
        {
            try
            {
                if (txt_Kampanya_Adı.Value.ToString() == "" || txt_kampanya_Bilgisi.Value.ToString() == "")
                {


                    DataRow dtveri = veri.GetDataRow("select KampanyaAdı,KampanyaBilgisi from Kampanyalar_tbl where Kampanya_Aktif_Pasif in (1)");
                    txt_Kampanya_Adı.Value = dtveri["KampanyaAdı"].ToString();
                    txt_kampanya_Bilgisi.Value = dtveri["KampanyaBilgisi"].ToString();
                }
            }

            catch
            {

            }

        }
        protected void btn_KampanyaOlustur_ServerClick(object sender, EventArgs e)
        {
            int pasif = 0;
            SqlConnection baglan = this.veri.baglan();

            SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Kampanyalar_tbl (KampanyaAdı,KampanyaBilgisi,Kampanya_Aktif_Pasif) VALUES (@KampanyaAdı,@KampanyaBilgisi,@Kampanya_Aktif_Pasif)", baglan);

            sqlsorgu.Parameters.AddWithValue("@KampanyaAdı", txt_Kampanya_Adı.Value.ToString());
            sqlsorgu.Parameters.AddWithValue("@KampanyaBilgisi", txt_kampanya_Bilgisi.Value.ToString());
            sqlsorgu.Parameters.AddWithValue("@Kampanya_Aktif_Pasif", pasif.ToString());
            sqlsorgu.ExecuteNonQuery();

            baglan.Close();

            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "3;AdminKampanyalar.aspx";
            this.Page.Controls.Add(meta);
            Msg.Show("Kampanya oluşturuldu 3 saniye sonra sayfa yenilenecektir");
        }

        protected void Kampanyalar_Repater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "SilKampanya")
            {


                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("DELETE  FROM Kampanyalar_tbl where id=" + e.CommandArgument + "", baglan);

                sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument.ToString());
                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                Page.Response.Redirect(Page.Request.Url.ToString(), false);
            }
            if (e.CommandName == "DüzenleKampanya")
            {
                SqlConnection baglan = veri.baglan();
                SqlCommand sqlkomut = new SqlCommand("select  SporSalon_Ozellikler from Ozellikler_tbl where id=" + e.CommandArgument.ToString() + "", baglan);
                sqlkomut.Parameters.AddWithValue("@id", e.CommandArgument.ToString());
                sqlkomut.ExecuteNonQuery();
                baglan.Close();


                idtut = e.CommandArgument.ToString();

               
                Response.Redirect("AdminKampanyalar.aspx?Kampanyaid=" + idtut.ToString());
                
            }

            if (e.CommandName == "Aktif_Pasif")
            {
                SqlConnection baglan = veri.baglan();
                SqlCommand sqlkomut = new SqlCommand("update Kampanyalar_tbl set Kampanya_Aktif_Pasif = 0 where Kampanya_Aktif_Pasif = 1", baglan);
                sqlkomut.Parameters.AddWithValue("@id", e.CommandArgument.ToString());
                sqlkomut.ExecuteNonQuery();
                baglan.Close();

                Kampanyaidtut = e.CommandArgument.ToString();


                Response.Redirect("AdminKampanyalar.aspx?Kampanyaİdtut=" + Kampanyaidtut.ToString());

            }
        }

        protected void btn_Güncelle_ServerClick(object sender, EventArgs e)
        {
            SqlConnection baglan = this.veri.baglan();
            if (idtut != null)
            {

                //UpdatePanelAktiviteGüncelle.Update();
                SqlCommand Guncelle = new SqlCommand("update Kampanyalar_tbl set  KampanyaAdı = '" + txt_Kampanya_Adı.Value + "' ,KampanyaBilgisi ='" + txt_kampanya_Bilgisi.Value + "' where id ='" + idtut + "'", baglan);

                Guncelle.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;AdminKampanyalar.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İD = " + idtut.ToString() + " Kampanya bilgileri güncellendi 3 saniye sonra tablo sayfasına yönlendirileceksiniz.");
               
            }
        }

        protected void btn_Aktif_Pasif_ServerClick(object sender, EventArgs e)
        {
            SqlConnection baglan = this.veri.baglan();
            if (Kampanyaidtut != null)
            {
                SqlCommand Aktif_Yap = new SqlCommand("update Kampanyalar_tbl set Kampanya_Aktif_Pasif = 1 where id = '" + Kampanyaidtut + "'", baglan);
                Aktif_Yap.ExecuteNonQuery();
                baglan.Close();

                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;AdminKampanyalar.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İD = " + Kampanyaidtut.ToString() + " Kampanya aktif hale getirildi diğer kampanyalar pasif hale getirildi.");

            }

        }
    }
}


