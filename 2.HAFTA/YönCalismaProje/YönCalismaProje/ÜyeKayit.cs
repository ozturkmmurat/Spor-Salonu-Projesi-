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
    public partial class ÜyeKayit : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");


        public ÜyeKayit()
        {
            InitializeComponent();

        }

        private void ÜyeKayit_Load(object sender, EventArgs e)
        {
            Tablolustur();
        }
        void Tablolustur()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            Baglanti.Open();
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT * from Yön_Calismaproje", Baglanti);
            DataTable sqlVerialma = new DataTable();
            sqlVericekme.Fill(sqlVerialma);
            datagrid_ÜyeBilgileri.DataSource = sqlVerialma;
            Baglanti.Close();
        }





        private void btn_KayitiOlustur_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand Komut = new SqlCommand("INSERT INTO Yön_Calismaproje ( Tc , Ad, Soyad , Yas,Dogum_Tarihi ,Kilo , Boy ,Üyelik_Suresi) VALUES (@Tc , @Ad , @Soyad ,@Yas, @Dogum_Tarihi , @Kilo , @Boy , @Üyelik_Suresi)", Baglanti);
            Komut.Parameters.AddWithValue("@Tc", txt_Tc.Text);
            Komut.Parameters.AddWithValue("@Ad", txt_Ad.Text);
            Komut.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
            Komut.Parameters.AddWithValue("@Yas", txt_Yas.Text);
            Komut.Parameters.AddWithValue("@Dogum_Tarihi", dateTime_DogumTarihi.Value);
            Komut.Parameters.AddWithValue("@Kilo", txt_Kilo.Text);
            Komut.Parameters.AddWithValue("@Boy", txt_Boy.Text);
            Komut.Parameters.AddWithValue("@Üyelik_Suresi", txt_ÜyelikSüresi.Text);
            Komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void datagrid_ÜyeBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Tc.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[0].Value.ToString();
            txt_Ad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[1].Value.ToString();
            txt_Soyad.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[2].Value.ToString();
            txt_Yas.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[3].Value.ToString();
            dateTime_DogumTarihi.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[4].Value.ToString();
            txt_Kilo.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[5].Value.ToString();
            txt_Boy.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[6].Value.ToString();
            txt_ÜyelikSüresi.Text = datagrid_ÜyeBilgileri.CurrentRow.Cells[7].Value.ToString();

        }

        void ListeyiYenileme(string ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri,Baglanti);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            datagrid_ÜyeBilgileri.DataSource = ds.Tables[0];
        }
        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            ListeyiYenileme("select * from Yön_CalismaProje");

        }

        private void btn_KayıtSil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand Komut2 = new SqlCommand("DELETE  FROMM Yön_Calismaproje where id =@id", Baglanti);
            Komut2.Parameters.AddWithValue("@id", txt_Kayıtsil.Text);
            Komut2.ExecuteNonQuery();
            Baglanti.Close();

        }

        void TopluKayıtSilme(int id)
        {
            string TopluSilme = "delete from Yön_Calismaproje where id=@id";
            SqlCommand TopluSilmeKomutu = new SqlCommand(TopluSilme, Baglanti);
            TopluSilmeKomutu.Parameters.AddWithValue("id", @id);
            Baglanti.Open();
            TopluSilmeKomutu.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void btn_Toplukayıtsil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_ÜyeBilgileri.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                TopluKayıtSilme(id);
            }
            Tablolustur();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand KayıtAra = new SqlCommand("select * from Yön_CalismaProje where Tc like '%" + txt_KayıtAra.Text + "%'",Baglanti);
            SqlDataAdapter veri_KayıtAra = new SqlDataAdapter(KayıtAra);
            KayıtAra.ExecuteNonQuery();
            DataSet dss = new DataSet(); // Dataset ne işe yarıyor ?
            veri_KayıtAra.Fill(dss);
            datagrid_ÜyeBilgileri.DataSource = dss.Tables[0];
            Baglanti.Close();
        }

       
    }
}

