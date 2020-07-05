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
    public partial class MasterSporBolumuTablosu : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        String idtut;
        protected void Page_Load(object sender, EventArgs e)
        {
            Listele();

        }
        public void Listele()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter Listeleme = new SqlDataAdapter("Select * from SporBolumu_tbl", baglan);
            DataSet Ds = new DataSet();
            Listeleme.Fill(Ds);
            SporBolumuTablosu.DataSource = Ds;
            SporBolumuTablosu.DataBind();
        }

        protected void SporBolumuTablosu_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {


                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("DELETE  FROM SporBolumu_tbl where id=" + e.CommandArgument + "", baglan);

                sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                Page.Response.Redirect(Page.Request.Url.ToString(), false);
            }

            if (e.CommandName == "Düzenleme")
            {

                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("Select id from SporBolumu_tbl where id=" + e.CommandArgument + "", baglan);
                DataSet1TableAdapters.SporBolumu_tblTableAdapter ListeGetir = new DataSet1TableAdapters.SporBolumu_tblTableAdapter();
                SporBolumuTablosu.DataSource = ListeGetir.SporBolumuTablosu();
                SporBolumuTablosu.DataBind();



                sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
                sqlsorgu.ExecuteNonQuery();
                idtut = e.CommandArgument.ToString();
                Response.Redirect("AktiviteGuncelle.aspx?id=" + idtut.ToString());


                baglan.Close();



                //    //DataRow drVeri = MasterCalisanlar.GetDate(string.Format("select id,Calisan_Ad,Calisan_Soyad,E_mail,Calisan_Hakkinda,Resim from  Calisan_tbl where id={0}", e.CommandArgument.ToString()));


                //}

            }

           
        }
    }
}