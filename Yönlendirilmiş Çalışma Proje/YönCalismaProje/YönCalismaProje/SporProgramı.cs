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
    public partial class SporProgramı : Form
    {
        public SporProgramı()
        {
            InitializeComponent();
        }
        void Tablolustur()
        {

            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select  id,Tc,Ad,Soyad,Yas,Dogum_Tarihi,Uyelik_Suresibaslangic,Uyelik_Suresibitis,Uyelik_Kalansüre,Cinsiyet,E_mail,Adres,Telefon_No  from Yön_CalismaProje ORDER BY id DESC", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGrid_Uyeler.DataSource = sqlVerialma;
            Baglanti.Close();
        }

        private void SporProgramı_Load(object sender, EventArgs e)
        {
            Tablolustur();
        }

        private void dataGrid_Uyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SporProgramıOlustur SporProgramıOlusturmaSayfası = new SporProgramıOlustur();

            SporProgramıOlustur.idtut = dataGrid_Uyeler.CurrentRow.Cells[0].Value.ToString();
            SporProgramıOlusturmaSayfası.lbl_blgAd.Text = dataGrid_Uyeler.CurrentRow.Cells[2].Value.ToString();
            SporProgramıOlusturmaSayfası.lbl_BlgSoyad.Text = dataGrid_Uyeler.CurrentRow.Cells[3].Value.ToString();

            SporProgramıOlusturmaSayfası.Show();
        }

        private void btn_MenuyeDon_Click(object sender, EventArgs e)
        {
            Menu MenuSayfasi = new Menu();
            MenuSayfasi.Show();
            this.Hide();
        }
    }
}
