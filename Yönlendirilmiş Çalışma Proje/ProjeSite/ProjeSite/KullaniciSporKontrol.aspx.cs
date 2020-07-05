using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeSite
{
    public partial class KullaniciSporKontrol : System.Web.UI.Page
    {

        int deneme;
        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            


            string idtut= Request.QueryString["id"];
            try
            {
                if (!Page.IsPostBack)
                {
                    if (deneme == 0)
                    {
                        SqlConnection baglan = this.veri.baglan();
                        SqlDataAdapter da = new SqlDataAdapter("Select Resim From Calisan_tbl ", baglan);
                        DataTable dt = new DataTable();
                        da.Fill(dt);



                        DataRow dtveri = veri.GetDataRow("Select Spor_Gun,Yapilacak_Hareketler,Program_Bitis from Spor_Programı_tbl where id='" + idtut.ToString() + "'");
                        string Tc = dtveri["Calisan_TcNo"].ToString();
                        //Calisan_Tc.Value = Tc.ToString();




                    }
                }

            }
            catch
            {
                Msg.Show("Error 404!");
            }
            string SporProgramı = "Yüzme,Voleybol,Futbol,Kitap Okuma";
            string[] SporProgramıParcala = SporProgramı.Split(',');
        }
    }
}