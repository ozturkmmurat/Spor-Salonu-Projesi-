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
    public partial class KullanıcıSporTablosu : System.Web.UI.Page
    {

        baglanti veri = new baglanti();
        string idtut;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("Giris Sayfası.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz " + Session["ad"].ToString());

            }
            idtut = Session["id"].ToString();
            Listele();
        }
    
    public void Listele()
    {
        SqlConnection baglan = this.veri.baglan();
        SqlDataAdapter Listele = new SqlDataAdapter("Select Spor_Gun,Yapilacak_Hareketler,Program_Bitis from Spor_Programı_tbl where id='" + idtut.ToString() + "'", baglan);
        DataSet Ds = new DataSet();
        Listele.Fill(Ds);
        SporBolumuTablosu.DataSource = Ds;
        SporBolumuTablosu.DataBind();
    }

        protected void SporBolumuTablosu_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Getir")
            {

                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("Select id from SporBolumu_tbl where id=" + e.CommandArgument + "", baglan);
               



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
