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
    public partial class KullanıcıOlcumTablosu : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        string idtut;
        protected void Page_Load(object sender, EventArgs e)

        {


            if (Session["ad"] == null)
            {
                Response.Redirect("Giris Sayfası.aspx");
            }
            else { 
            Response.Write("Hoşgeldiniz " + Session["ad"].ToString());
           
        }
            idtut = Session["id"].ToString();
            Listele();
        }
        public void Listele()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter Listele = new SqlDataAdapter("Select Kilo,Boy,Kas_Orani,Yag_Orani,Su_Orani,Program_Bitis from Program_Bilgileri where id='" + idtut.ToString() +"'", baglan);
            DataSet Ds = new DataSet();
            Listele.Fill(Ds);
            OlcumTablosu.DataSource = Ds;
            OlcumTablosu.DataBind();
        }

    }
}