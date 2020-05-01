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
    public partial class UyeSilmeBolumu : Form
    {
        public UyeSilmeBolumu()
        {
            InitializeComponent();
         
        }
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
        private void UyeSilmeBolumu_Load(object sender, EventArgs e)
        {
            Tablolustur();
        }
      
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void Tablolustur()
        {

            SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Yon_Calismaproje; Integrated Security = True");
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select * from Yön_CalismaProje ORDER BY id DESC", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGridUyeSilme.DataSource = sqlVerialma;
            Baglanti.Close();
        }
        void ListeyiYenileme(string ListeVeri)
        {
            SqlDataAdapter Veri_Cekme = new SqlDataAdapter(ListeVeri, Baglanti);
            DataSet ds = new DataSet();
            Veri_Cekme.Fill(ds);
            dataGridUyeSilme.DataSource = ds.Tables[0];
        }
        void SecerekSil(int Kullanici_İd)
        {
            string Sil = "DELETE FROM Yön_Calismaproje WHERE id=@id";
            ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");
            SqlCommand Komut = new SqlCommand(Sil, Baglanti);
            Komut.Parameters.AddWithValue("@id", Kullanici_İd);
            Baglanti.Open();
            Komut.ExecuteNonQuery();
            Baglanti.Close();
        }

     

      
        private void btn_MenuyeDon_Click(object sender, EventArgs e)
        {
            Menu MenuSayfasi = new Menu();
            MenuSayfasi.Show();
            this.Hide();
        }

        private void btn_TopluKayıtSil_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridUyeSilme.SelectedRows)  //Seçili Satırları Silme
            {
                int No = Convert.ToInt32(drow.Cells[0].Value);
                SecerekSil(No);
                MessageBox.Show("Kayıt Başarıyla Silindi");
                ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");

            }
        }

        private void btn_Sil_Click_1(object sender, EventArgs e)
        {

            if (txt_Kayıtsil.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz Kayıtın İd bilgisini giriniz.", "Uyarı");
            }

            else
            {
                Baglanti.Open();
                SqlCommand Komut2 = new SqlCommand("DELETE  FROM Yön_Calismaproje where id =@id", Baglanti);
                Komut2.Parameters.AddWithValue("@id", txt_Kayıtsil.Text);
                Komut2.ExecuteNonQuery();
                MessageBox.Show(txt_Kayıtsil.Text + " Kayıt başarıyla silindi");
                ListeyiYenileme("select * from Yön_CalismaProje ORDER BY id DESC");

                Baglanti.Close();

            }
        }
    }
}
