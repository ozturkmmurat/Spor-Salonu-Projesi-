using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YönCalismaProje
{
    public partial class Olcumİstatistik : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        public Olcumİstatistik()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Program_Baslangic,Kilo,Su_Orani,Kas_Orani,Yag_Orani from Program_Bilgileri", Baglanti);
            SqlDataReader VerileriOku = komut.ExecuteReader();

            while (VerileriOku.Read())
            {
                chart_Olcumistatistik.Series["Kilo"].Points.AddXY(VerileriOku[1].ToString(),VerileriOku[0]);
                chart_Olcumistatistik.Series["Su_Orani"].Points.AddXY(VerileriOku[2].ToString(), VerileriOku[0]);
                chart_Olcumistatistik.Series["Kas_Orani"].Points.AddXY(VerileriOku[3].ToString(), VerileriOku[0]);
                chart_Olcumistatistik.Series["Yag_Orani"].Points.AddXY(VerileriOku[4].ToString(), VerileriOku[0]);

            }

            Baglanti.Close();
        }
    }
}
