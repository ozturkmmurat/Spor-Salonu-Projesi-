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
    public partial class SporSalonPencere : System.Web.UI.Page
    {
        baglanti veri = new baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = this.veri.baglan();
            //DataSet1TableAdapters.Calisan_tbl1TableAdapter üyeListele = new DataSet1TableAdapters.Calisan_tbl1TableAdapter();
            //DataList.DataSource = üyeListele.CalisanListelemeMetod();
            //DataList.DataBind();


            SqlDataAdapter da = new SqlDataAdapter("Select Calisan_Ad,Calisan_Soyad,Resim,Calisan_Hakkinda,E_mail From Calisan_tbl ", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataList.DataSource = dt;
            DataList.DataBind();
        }
    }
}