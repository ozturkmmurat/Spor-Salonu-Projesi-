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
    public partial class Giris_Sayfası : System.Web.UI.Page
    {
        baglanti veri = new baglanti();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (txt_Tc.Text == "" || Txt_Sifre.Text == "")
            {
               
            }
            else
            {


                SqlConnection baglan = this.veri.baglan();
               
                SqlCommand sorgu = new SqlCommand("SELECT * FROM Yön_Calismaproje WHERE Tc=@Tc AND Uye_Sifre=@Uye_Sifre", baglan);

                sorgu.Parameters.Add("@Tc", SqlDbType.VarChar).Value = txt_Tc.Text;
                sorgu.Parameters.Add("@Uye_Sifre", SqlDbType.VarChar).Value = Txt_Sifre.Text;

              

                SqlDataReader oku = sorgu.ExecuteReader();
                
                
                // Eğer bir kayıt varsa
                if (oku.Read())
                {
                    // Okunan verileri Session(Oturum) değişkenlerinde saklayalım
                    Session["id"] = oku["id"].ToString();
                    Session["Ad"] = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                 
                    // Giriş sayfasına yönlendir
                    Response.Redirect("KullanıcıOlcumTablosu.aspx");
                }
                else // Kayıt yoksa
                {
                   

                }
                oku.Close(); // Reader nesnesini kapat
                baglan.Close();
            }
        }
    }
}