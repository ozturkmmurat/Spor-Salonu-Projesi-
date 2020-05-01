using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönCalismaProje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeSilmeBolumu UyeSilmeSayfası = new UyeSilmeBolumu();
                        UyeSilmeSayfası.Show();
                       this.Hide();
        }

        private void btn_Uyeolustur_Click(object sender, EventArgs e)
        {
            ÜyeKayit UyeKayıtSayfasi = new ÜyeKayit();
            UyeKayıtSayfasi.Show();
            this.Hide();
        }

        private void btn_BeslenmeOlustur_Click(object sender, EventArgs e)
        {
            BeslenmeProgramı BeslenmeSayfası = new BeslenmeProgramı();
            BeslenmeSayfası.Show();
            this.Hide();
        }

        private void btn_SporProgramıOlustur_Click(object sender, EventArgs e)
        {
            SporProgramı SporProgramıSayfası = new SporProgramı();
            SporProgramıSayfası.Show();
            this.Hide();
        }

        private void btn_OlcumBilgisiOlustur_Click(object sender, EventArgs e)
        {
            OlcumSayfasi OlcumSayfasi = new OlcumSayfasi();
            OlcumSayfasi.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
