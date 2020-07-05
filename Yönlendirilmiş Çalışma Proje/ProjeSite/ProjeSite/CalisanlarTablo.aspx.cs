using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ProjeSite
{
    public partial class CalisanlarTablo : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //DataSet1TableAdapters.Calisan_tbl1TableAdapter üyeListele = new DataSet1TableAdapters.Calisan_tbl1TableAdapter();
            //CalisanlarTabloİd.DataSource = üyeListele.CalisanListelemeMetod();
            //CalisanlarTabloİd.DataBind();
            
            Listele();
        
            
           

        


        }
      public void Listele()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlDataAdapter Listele = new SqlDataAdapter("Select * from Calisan_tbl", baglan);
            DataSet Ds = new DataSet();
            Listele.Fill(Ds);
            CalisanlarTabloİd.DataSource = Ds;
            CalisanlarTabloİd.DataBind();
        }
        


        protected void CalisanSilme(object source, RepeaterCommandEventArgs e)
        {

           
        }


        protected void CalisanlarTabloİd_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            


            if (e.CommandName == "Sil")
            {

                
                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("DELETE  FROM Calisan_tbl where id=" + e.CommandArgument + "", baglan);
         
                sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                Page.Response.Redirect(Page.Request.Url.ToString(), false);
            }
            
            if (e.CommandName == "Düzenleme")
            {
               
                SqlConnection baglan = veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("Select * from Calisan_tbl where id=" + e.CommandArgument + "", baglan);
                DataSet1TableAdapters.Calisan_tbl1TableAdapter üyeListele = new DataSet1TableAdapters.Calisan_tbl1TableAdapter();
                CalisanlarTabloİd.DataSource = üyeListele.CalisanListelemeMetod();
                CalisanlarTabloİd.DataBind();



                sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
                sqlsorgu.ExecuteNonQuery();
                Calisanİd.Text = e.CommandArgument.ToString();                           
                Response.Redirect("MasterCalisanlarGuncelle.aspx?id=" + Calisanİd.Text);
      

                baglan.Close();



                //DataRow drVeri = MasterCalisanlar.GetDate(string.Format("select id,Calisan_Ad,Calisan_Soyad,E_mail,Calisan_Hakkinda,Resim from  Calisan_tbl where id={0}", e.CommandArgument.ToString()));


            }

        }
       
        
        //protected void Button1_Click(object sender, EventArgs e)
        //{


        //    int SilinecekKayitNo = System.Convert.ToInt32(Request.QueryString["id"]);
        //    veri.baglan();
            
        //    SqlCommand Komut2 = new SqlCommand("DELETE  FROM Yön_Calismaproje where id =@id");
        //    Komut2.Parameters.AddWithValue("@id",SilinecekKayitNo);
        //    Komut2.ExecuteNonQuery();
       

            
        //}
    }
    }
