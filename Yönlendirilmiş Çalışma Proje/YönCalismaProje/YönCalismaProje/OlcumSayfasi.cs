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
    public partial class OlcumSayfasi : Form
    {
        public OlcumSayfasi()
        {
            InitializeComponent();
        }

        private void OlcumSayfasi_Load(object sender, EventArgs e)
        {
            Tablolustur();
        }
        void Tablolustur()
        {

            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select * from Yön_CalismaProje ORDER BY id DESC", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Uyeler.DataSource = sqlVerialma;
            Baglanti.Close();
        }

        private void dataGrid_Uyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OlcumOlustur OlcumOlusturmaSayfasi = new OlcumOlustur();

            OlcumOlustur.idtut = dataGrid_Uyeler.CurrentRow.Cells[0].Value.ToString();
            OlcumOlusturmaSayfasi.lbl_Blgad.Text = dataGrid_Uyeler.CurrentRow.Cells[2].Value.ToString();
            OlcumOlusturmaSayfasi.lbl_Blgsoyad.Text = dataGrid_Uyeler.CurrentRow.Cells[3].Value.ToString();

            OlcumOlusturmaSayfasi.Show();
        }
    }
}
