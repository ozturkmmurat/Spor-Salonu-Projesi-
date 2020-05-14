using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeSite
{
    public partial class AdminMasterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Yön_CalismaprojeTableAdapter üyeListele = new DataSet1TableAdapters.Yön_CalismaprojeTableAdapter();
            üyeListeİd.DataSource = üyeListele.YonCalismaListe();
            üyeListeİd.DataBind();
        }
       
    }
}