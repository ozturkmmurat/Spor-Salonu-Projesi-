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
    public partial class AdminCalismaSaatleri : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
       
        string idtut;
        protected void Page_Load(object sender, EventArgs e)
        {
            CalismaSaatiListele();
            VeritabaniBosmuDolumi();


            //if (Cs_Baslangic.Text =="" || Cs_Bitis.Text =="" || HaftaSonu_Cs_BaslangicSaat.Text =="" || HaftaSonu_Cs_BitisSaat.Text =="" || HaftaSonu_Pz_BaslangicSaat.Text=="" || HaftaSonu_Pz_BitisSaat.Text == "")
            //{
            //    CalismaSaatiOlustur.Visible = true;
            //    CalismaSaatiGuncelle.Visible = false;

            //}
            //else if (Cs_Baslangic.Text != "" || Cs_Bitis.Text != "" || HaftaSonu_Cs_BaslangicSaat.Text != "" || HaftaSonu_Cs_BitisSaat.Text != "" || HaftaSonu_Pz_BaslangicSaat.Text != "" || HaftaSonu_Pz_BitisSaat.Text != "")
            //{
            //    CalismaSaatiGuncelle.Visible = true;
            //    CalismaSaatiOlustur.Visible = false;

            //}
            //if (Cs_Baslangic.Text != "" || Cs_Bitis.Text != "" || HaftaSonu_Cs_BaslangicSaat.Text != "" || HaftaSonu_Cs_BitisSaat.Text != "" || HaftaSonu_Pz_BaslangicSaat.Text != "" || HaftaSonu_Pz_BitisSaat.Text != "")
            //{
            //    CalismaSaatiOlustur.Visible = true;
            //}
            //else
            //{
            //    CalismaSaatiOlustur.Visible = false;
            //}
        }
       public void VeritabaniBosmuDolumi()
        {
            SqlConnection baglan = this.veri.baglan();
            SqlCommand VeritabanıBosmuDolumu = new SqlCommand("select COUNT(id) from Calisma_Saatleri", baglan);
            int veritabanıKontrol = Convert.ToInt32(VeritabanıBosmuDolumu.ExecuteScalar());
            baglan.Close();
            if(veritabanıKontrol == 0)
            {
                CalismaSaatiGuncelle.Visible = false;
                CalismaSaatiOlustur.Visible = true;
            }
            else
            {
                CalismaSaatiOlustur.Visible= false;
                CalismaSaatiGuncelle.Visible = true;
            }
        }
        public void CalismaSaatiListele()
        {
            DataRow dtveri = veri.GetDataRow("Select id,Cs_Haftaici_Saat,HaftaSonu_Cs_Saat,HaftaSonu_Pz_Saat From Calisma_Saatleri  ");
            try
            {
                idtut = dtveri["id"].ToString();
                if (!IsPostBack)
                {
                    Cs_Baslangic.Text = dtveri["Cs_Haftaici_Saat"].ToString();
                    Cs_Bitis.Text = dtveri["HaftaSonu_Cs_Saat"].ToString();
                    HaftaSonu_Cs_BaslangicSaat.Text = dtveri["HaftaSonu_Pz_Saat"].ToString();
   

                }

            }
            catch
            {

            }
        }
        public void haftaSonuAcıkKapalıCumartesi()
        {
           

                if (haftaSonu_Cmt_List.SelectedValue == "Açık")
                {
                    HaftaSonu_Cs_BaslangicSaat.Visible = true;
                    HaftaSonu_Cs_BitisSaat.Visible = true;
                }
                else if (haftaSonu_Cmt_List.SelectedValue == "Kapalı")
                {
                    HaftaSonu_Cs_BaslangicSaat.Visible = false;
                    HaftaSonu_Cs_BitisSaat.Visible = false;
                }
            
               
            
        }
        public void haftaSonuAcıkKapalıPazaR()
        {
            
                if (HaftaSonu_Pzr_List.SelectedValue == "Açık")
                {
                    HaftaSonu_Pz_BaslangicSaat.Visible = true;
                    HaftaSonu_Pz_BitisSaat.Visible = true;
                }
                else if (HaftaSonu_Pzr_List.SelectedValue == "Kapalı")
                {
                    HaftaSonu_Pz_BaslangicSaat.Visible = false;
                    HaftaSonu_Pz_BitisSaat.Visible = false;
                }
            
        }


        protected void DropDownList_CalismaSaati_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CalismaSaatiOlustur_ServerClick(object sender, EventArgs e)
        {
        if (Cs_Baslangic.Text == "" || Cs_Bitis.Text == "")
        {
            Msg.Show("Lütfen hafta içi çalışma saati giriniz");
        }
        else
        {
            if (haftaSonu_Cmt_List.SelectedValue == "Açık" && HaftaSonu_Pzr_List.SelectedValue == "Açık")
            {
                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Calisma_Saatleri(Cs_Haftaici_Saat,HaftaSonu_Cs_Saat,HaftaSonu_Pz_Saat) VALUES (@Cs_Haftaici_Saat,@HaftaSonu_Cs_Saat,@HaftaSonu_Pz_Saat)", baglan);
                sqlsorgu.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", HaftaSonu_Cs_BaslangicSaat.Text + " - " + HaftaSonu_Cs_BitisSaat.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Cs_BaslangicSaat.Text + " - " + HaftaSonu_Cs_BitisSaat.Text);

                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;AdminCalismaSaatleri.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İşleminiz Başarıyla Gerçekleşti");
            }
            else if (haftaSonu_Cmt_List.SelectedValue == "Kapalı" && HaftaSonu_Pzr_List.SelectedValue == "Açık")
            {

                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Calisma_Saatleri(Cs_Haftaici_Saat,HaftaSonu_Cs_Saat,HaftaSonu_Pz_Saat) VALUES (@Cs_Haftaici_Saat,@HaftaSonu_Cs_Saat,@HaftaSonu_Pz_Saat)", baglan);

                sqlsorgu.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", haftaSonu_Cmt_List.SelectedValue);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pz_BaslangicSaat.Text + " - " + HaftaSonu_Pz_BitisSaat.Text);

                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;AdminCalismaSaatleri.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İşleminiz Başarıyla Gerçekleşti");
            }
            else if (haftaSonu_Cmt_List.SelectedValue == "Açık" && HaftaSonu_Pzr_List.SelectedValue == "Kapalı")
            {
                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Calisma_Saatleri(Cs_Haftaici_Saat,HaftaSonu_Cs_Saat,HaftaSonu_Pz_Saat) VALUES (@Cs_Haftaici_Saat,@HaftaSonu_Cs_Saat,@HaftaSonu_Pz_Saat)", baglan);

                sqlsorgu.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", HaftaSonu_Cs_BaslangicSaat.Text + " - " + HaftaSonu_Cs_BitisSaat.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pzr_List.SelectedValue);

                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;AdminCalismaSaatleri.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İşleminiz Başarıyla Gerçekleşti");
            }
            else if (haftaSonu_Cmt_List.SelectedValue == "Kapalı" && HaftaSonu_Pzr_List.SelectedValue == "Kapalı")
            {
                SqlConnection baglan = this.veri.baglan();
                SqlCommand sqlsorgu = new SqlCommand("INSERT INTO  Calisma_Saatleri(Cs_Haftaici_Saat,HaftaSonu_Cs_Saat,HaftaSonu_Pz_Saat) VALUES (@Cs_Haftaici_Saat,@HaftaSonu_Cs_Saat,@HaftaSonu_Pz_Saat)", baglan);

                sqlsorgu.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", haftaSonu_Cmt_List.SelectedValue);
                sqlsorgu.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pzr_List.SelectedValue);

                sqlsorgu.ExecuteNonQuery();
                baglan.Close();
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;AdminCalismaSaatleri.aspx";
                this.Page.Controls.Add(meta);
                Msg.Show("İşleminiz Başarıyla Gerçekleşti");
            }


        }


        }

        protected void HaftaSonu_Pzr_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            haftaSonuAcıkKapalıPazaR();
        }

        protected void haftaSonu_Cmt_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            haftaSonuAcıkKapalıCumartesi();
        }

        protected void CalismaSaatiGuncelle_ServerClick(object sender, EventArgs e)
        {
            SqlConnection baglan = this.veri.baglan();

            if (Cs_Baslangic.Text == "" || Cs_Bitis.Text == "")
            {
                Msg.Show("Lütfen hafta içi çalışma saati giriniz");
            }
            else
            {
                if (haftaSonu_Cmt_List.SelectedValue == "Açık" && HaftaSonu_Pzr_List.SelectedValue == "Açık")
                {
                    SqlCommand GüncelleKomut = new SqlCommand("UPDATE Calisma_Saatleri SET Cs_Haftaici_Saat = @Cs_Haftaici_Saat, HaftaSonu_Cs_Saat = @HaftaSonu_Cs_Saat, HaftaSonu_Pz_Saat = @HaftaSonu_Pz_Saat where id = '" + Convert.ToInt64(idtut) + "'", baglan);
                    GüncelleKomut.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", HaftaSonu_Cs_BaslangicSaat.Text + " - " + HaftaSonu_Cs_BitisSaat.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pz_BaslangicSaat.Text + " - " + HaftaSonu_Pz_BitisSaat.Text);

                    GüncelleKomut.ExecuteNonQuery();
                    baglan.Close();
                    HtmlMeta meta = new HtmlMeta();
                    meta.HttpEquiv = "Refresh";
                    meta.Content = "2;AdminCalismaSaatleri.aspx";
                    this.Page.Controls.Add(meta);
                    Msg.Show("İşleminiz Başarıyla Gerçekleşti");
                }
                else if (haftaSonu_Cmt_List.SelectedValue == "Kapalı" && HaftaSonu_Pzr_List.SelectedValue == "Açık")
                {
                    SqlCommand GüncelleKomut = new SqlCommand("UPDATE Calisma_Saatleri SET Cs_Haftaici_Saat = @Cs_Haftaici_Saat, HaftaSonu_Cs_Saat = @HaftaSonu_Cs_Saat, HaftaSonu_Pz_Saat = @HaftaSonu_Pz_Saat where id = '" + Convert.ToInt64(idtut) + "'", baglan);

                    GüncelleKomut.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", haftaSonu_Cmt_List.SelectedValue);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pz_BaslangicSaat.Text + " - " + HaftaSonu_Pz_BitisSaat.Text);

                    GüncelleKomut.ExecuteNonQuery();
                    baglan.Close();
                    HtmlMeta meta = new HtmlMeta();
                    meta.HttpEquiv = "Refresh";
                    meta.Content = "2;AdminCalismaSaatleri.aspx";
                    this.Page.Controls.Add(meta);
                    Msg.Show("İşleminiz Başarıyla Gerçekleşti");
                }
                else if (haftaSonu_Cmt_List.SelectedValue == "Açık" && HaftaSonu_Pzr_List.SelectedValue == "Kapalı")
                {
                    SqlCommand GüncelleKomut = new SqlCommand("UPDATE Calisma_Saatleri SET Cs_Haftaici_Saat = @Cs_Haftaici_Saat, HaftaSonu_Cs_Saat = @HaftaSonu_Cs_Saat, HaftaSonu_Pz_Saat = @HaftaSonu_Pz_Saat where id = '" + Convert.ToInt64(idtut) + "'", baglan);

                    GüncelleKomut.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", HaftaSonu_Cs_BaslangicSaat.Text + " - " + HaftaSonu_Cs_BitisSaat.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pzr_List.SelectedValue);


                    GüncelleKomut.ExecuteNonQuery();
                    baglan.Close();
                    HtmlMeta meta = new HtmlMeta();
                    meta.HttpEquiv = "Refresh";
                    meta.Content = "2;AdminCalismaSaatleri.aspx";
                    this.Page.Controls.Add(meta);
                    Msg.Show("İşleminiz Başarıyla Gerçekleşti");
                }
                else if (haftaSonu_Cmt_List.SelectedValue == "Kapalı" && HaftaSonu_Pzr_List.SelectedValue == "Kapalı")
                {
                    SqlCommand GüncelleKomut = new SqlCommand("UPDATE Calisma_Saatleri SET Cs_Haftaici_Saat = @Cs_Haftaici_Saat, HaftaSonu_Cs_Saat = @HaftaSonu_Cs_Saat, HaftaSonu_Pz_Saat = @HaftaSonu_Pz_Saat where id = '" + Convert.ToInt64(idtut) + "'", baglan);


                    GüncelleKomut.Parameters.AddWithValue("@Cs_Haftaici_Saat", Cs_Baslangic.Text + " - " + Cs_Bitis.Text);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Cs_Saat", HaftaSonu_Pzr_List.SelectedValue);
                    GüncelleKomut.Parameters.AddWithValue("@HaftaSonu_Pz_Saat", HaftaSonu_Pzr_List.SelectedValue);

                    GüncelleKomut.ExecuteNonQuery();
                    baglan.Close();
                    HtmlMeta meta = new HtmlMeta();
                    meta.HttpEquiv = "Refresh";
                    meta.Content = "2;AdminCalismaSaatleri.aspx";
                    this.Page.Controls.Add(meta);
                    Msg.Show("İşleminiz Başarıyla Gerçekleşti");
                }
            }
        }
    }
}