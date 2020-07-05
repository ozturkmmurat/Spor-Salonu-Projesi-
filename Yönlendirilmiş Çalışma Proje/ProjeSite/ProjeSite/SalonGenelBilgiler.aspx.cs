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
    public partial class SalonGenelBilgiler : System.Web.UI.Page
    {
        string DropdownlistOzellikler;
        string DropDownlistAktiviteler;
        string idtut;


        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {

            DataRow dtveri = veri.GetDataRow("Select id,Hakkimizda  From Genel_Bilgiler_Tbl  ");
            try
            {
                idtut = dtveri["id"].ToString();
                if (!IsPostBack)
                {
                    string HakkimizdaTut = dtveri["Hakkimizda"].ToString();
                    txt_Hakkimizda.Text = HakkimizdaTut.ToString();
                }
            }
            catch
            {

            }
          
            
           
            if (txt_Hakkimizda.Text != "")
            {
                Hakkımızda.Visible = false;
            }
            else
            {
                Hakkımızda.Visible = true;
            }
          

            //Listele();
            //OzellikleriListeleme();
            //lbl_Ozellikler.Text = Request.QueryString["lblOzelliklerid"];
            //lblDeneme.Text = Request.QueryString["idAktiviteler"];

            //if (!Page.IsPostBack)
            //{
            //    if (lblDeneme.Text!="")
            //    {

            //        DataRow deneme = veri.GetDataRow("select SporSalonu_Aktiviteler  from Aktiviteler_Tbl where id like '" + lblDeneme.Text.ToString() + "'");
            //        string AktivitelerListesi = deneme["SporSalonu_Aktiviteler"].ToString();
            //        DropDownList_Aktiviteler.Text = AktivitelerListesi.ToString();
            //        txt_Hakkimizda.Value = "";
            //        Response.Redirect("SalonGenelBilgiler.aspx");
            //    }


            //}

            //if (!Page.IsPostBack)
            //{
            //    if (lbl_Ozellikler.Text != "")
            //    {
            //        DataRow deneme = veri.GetDataRow("select SporSalon_Ozellikler  from Ozellikler_tbl where id like '" + lbl_Ozellikler.Text.ToString() + "'");
            //        string OzelliklerListelesi = deneme["SporSalon_Ozellikler"].ToString();
            //        Ozellikler_DropdownList.Text =OzelliklerListelesi.ToString();
            //    }
            //}

        }
        //public void Listele()
        //{
        //    SqlConnection baglan = this.veri.baglan();
        //    SqlDataAdapter Listele = new SqlDataAdapter("Select *  From Aktiviteler_Tbl ", baglan);
        //    DataSet Ds = new DataSet();
        //    Listele.Fill(Ds);
        //    Datalist_Aktivite.DataSource = Ds;
        //    Datalist_Aktivite.DataBind();
        //}
        //public void OzellikleriListeleme()
        //{
        //    SqlConnection baglan = this.veri.baglan();
        //    SqlDataAdapter ListeleOzellikler_Tbl = new SqlDataAdapter("Select * From Ozellikler_tbl ", baglan);
        //    DataSet Ds = new DataSet();
        //    ListeleOzellikler_Tbl.Fill(Ds);
        //    Ozellikler_Repater.DataSource = Ds;
        //    Ozellikler_Repater.DataBind();
        //}
        public void hakkimizdaGetir()
        {
          
            

        }
        protected void Hakkımızda_ServerClick(object sender, EventArgs e)
        {
            SqlConnection baglan = this.veri.baglan();
            if (txt_Hakkimizda.Text == "")
            {
                Msg.Show("Lütfen gerekli bilgileri giriniz");
            }
            else
            {

                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Genel_Bilgiler_tbl (Hakkimizda) VALUES (@Hakkimizda)", baglan);
                sqlsorgu.Parameters.AddWithValue("@Hakkimizda", txt_Hakkimizda.Text);
                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                txt_Hakkimizda.Text = "";
                Response.Redirect("SalonGenelBilgiler.aspx");
                
            }
        }

        protected void AktivitelerButton_ServerClick(object sender, EventArgs e)
        {

        }

        //protected void CheckBox_Aktivite_Secilenler(object sender, EventArgs e)
        //{
        //    DropDownList_Aktiviteler.AutoPostBack = false;

        //}

        //protected void Aktiviteler_Olustur_ServerClick(object sender, EventArgs e)
        //{
        //    SqlConnection baglan = this.veri.baglan();

        //    SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Aktiviteler_Tbl (SporSalonu_Aktiviteler) VALUES (@Hakkimizda)", baglan);
        //    sqlsorgu.Parameters.AddWithValue("@Hakkimizda", DropDownList_Aktiviteler.SelectedValue);
        //    sqlsorgu.ExecuteNonQuery();
        //    baglan.Close();
        //}

        //protected void Aktiviteler_Güncelle_ServerClick(object sender, EventArgs e)
        //{
        //    SqlConnection baglan = this.veri.baglan();
        //    if (lblDeneme.Text != "")
        //    {

        //        //UpdatePanelAktiviteGüncelle.Update();
        //        SqlCommand Guncelle = new SqlCommand("Update  Aktiviteler_tbl  set  SporSalonu_Aktiviteler = '" + DropDownList_Aktiviteler.Text + "' where id ='" + lblDeneme.Text + "'", baglan);

        //            Guncelle.ExecuteNonQuery();
        //            baglan.Close();
        //            HtmlMeta meta = new HtmlMeta();
        //            meta.HttpEquiv = "Refresh";
        //            meta.Content = "3;SalonGenelBilgiler.aspx";
        //            this.Page.Controls.Add(meta);
        //            Msg.Show("İD = " + lblDeneme.Text.ToString() + " Çalışanın bilgileri güncellendi 3 saniye sonra tablo sayfasına yönlendirileceksiniz.");
          
                   
        //        }
        //        else
        //        {
        //            Msg.Show("lbl boş");
        //        }
            
        //}

        //protected void Datalist_Aktivite_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{

        //    if (e.CommandName == "Sil")
        //    {


        //        SqlConnection baglan = veri.baglan();
        //        SqlCommand sqlsorgu = new SqlCommand("DELETE  FROM Aktiviteler_tbl where id=" + e.CommandArgument + "", baglan);

        //        sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
        //        sqlsorgu.ExecuteNonQuery();
        //        baglan.Close();
        //        Page.Response.Redirect(Page.Request.Url.ToString(), false);
        //    }

            
        //    if (e.CommandName == "Düzenleme")
        //    {

        //        SqlConnection baglan = veri.baglan();
        //        SqlCommand sqlkomut = new SqlCommand("select  SporSalonu_Aktiviteler from Aktiviteler_tbl where id="+e.CommandArgument.ToString()+ "", baglan);
        //        sqlkomut.Parameters.AddWithValue("@id", e.CommandArgument.ToString());
        //        sqlkomut.ExecuteNonQuery();
        //        baglan.Close();


        //        lblDeneme.Text = e.CommandArgument.ToString();

        //        DropDownlistAktiviteler ="1";

        //        Response.Redirect("SalonGenelBilgiler.aspx?idAktiviteler=" + lblDeneme.Text);




               
        //    }
        //}

        protected void Ozellikler_DropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        //protected void Btn_Ozellik_Olustur_ServerClick(object sender, EventArgs e)
        //{
        //    SqlConnection baglan = this.veri.baglan();

        //    SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Ozellikler_tbl (SporSalon_Ozellikler) VALUES (@SporSalon_Ozellikler)", baglan);
        //    sqlsorgu.Parameters.AddWithValue("@SporSalon_Ozellikler", Ozellikler_DropdownList.SelectedValue);
        //    sqlsorgu.ExecuteNonQuery();
        //    baglan.Close();
        //}

        //protected void Btn_Ozellik_Güncelle_ServerClick(object sender, EventArgs e)
        //{
        
        //    SqlConnection baglan = this.veri.baglan();
        //    if (lbl_Ozellikler.Text != "")
        //    {

        //        SqlCommand Guncelle = new SqlCommand("Update  Ozellikler_tbl  set  SporSalon_Ozellikler = '" + Ozellikler_DropdownList.Text + "' where id ='" + lbl_Ozellikler.Text + "'", baglan);

        //        Guncelle.ExecuteNonQuery();
        //        baglan.Close();
        //        HtmlMeta meta = new HtmlMeta();
        //        meta.HttpEquiv = "Refresh";
        //        meta.Content = "3;SalonGenelBilgiler.aspx";
        //        this.Page.Controls.Add(meta);
        //        Msg.Show("İD = " + lbl_Ozellikler.Text.ToString() + " Çalışanın bilgileri güncellendi 3 saniye sonra tablo sayfasına yönlendirileceksiniz.");
             
        //    }
        //    else
        //    {
        //        Msg.Show("lbl boş");
        //    }
        
        //}

        //protected void Ozellikler_Repater_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    if (e.CommandName == "SilOzellikler")
        //    {


        //        SqlConnection baglan = veri.baglan();
        //        SqlCommand sqlsorgu = new SqlCommand("DELETE  FROM Ozellikler_tbl where id=" + e.CommandArgument + "", baglan);

        //        sqlsorgu.Parameters.AddWithValue("@id", e.CommandArgument);
        //        sqlsorgu.ExecuteNonQuery();
        //        baglan.Close();
        //        Page.Response.Redirect(Page.Request.Url.ToString(), false);
        //    }
        //    if(e.CommandName == "DüzenlemeOzellikler")
        //    {
        //        SqlConnection baglan = veri.baglan();
        //        SqlCommand sqlkomut = new SqlCommand("select  SporSalon_Ozellikler from Ozellikler_tbl where id=" + e.CommandArgument.ToString() + "", baglan);
        //        sqlkomut.Parameters.AddWithValue("@id", e.CommandArgument.ToString());
        //        sqlkomut.ExecuteNonQuery();
        //        baglan.Close();

           
        //        lbl_Ozellikler.Text = e.CommandArgument.ToString();

              
        //        DropdownlistOzellikler = "1";
        //        Response.Redirect("SalonGenelBilgiler.aspx?lblOzelliklerid=" + lbl_Ozellikler.Text);
               
        //    }
            
          
        //}

        protected void HakkımızdaGüncelle_ServerClick(object sender, EventArgs e)
        {
          

            SqlConnection baglan = this.veri.baglan();
        
            SqlCommand GüncelleKomut = new SqlCommand("update Genel_Bilgiler_tbl set  Hakkimizda='" + txt_Hakkimizda.Text + "' where id=" +Convert.ToInt64(idtut)+  "",baglan);
            GüncelleKomut.ExecuteNonQuery();
            baglan.Close();
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "2;CalisanlarTablo.aspx";
            this.Page.Controls.Add(meta);
            Msg.Show("İşleminiz Başarıyla Gerçekleşti");



        }
    }
}
