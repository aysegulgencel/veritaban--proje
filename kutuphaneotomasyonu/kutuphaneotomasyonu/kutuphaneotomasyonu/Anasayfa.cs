using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=kutuphane_otomasyonu; user ID=postgres; password=16281628aG");

        private void btnkitapekleme_Click(object sender, EventArgs e)
        {
            KitapEkleme kitapekle = new KitapEkleme();
            kitapekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            UyeEkleme uyeekle = new UyeEkleme();
            uyeekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListeleme uyeliste = new UyeListeleme();
            uyeliste.ShowDialog();
        }

        private void btnemanetverme_Click(object sender, EventArgs e)
        {
            EmanetVerme emanetkitapverme = new EmanetVerme();
            emanetkitapverme.ShowDialog();
        }

        private void btnkitaplistele_Click(object sender, EventArgs e)
        {
            KitapListeleme kitapListeleme = new KitapListeleme();
            kitapListeleme.ShowDialog();
        }

        private void btnemanetlisteleme_Click(object sender, EventArgs e)
        {
            EmanetKitapListele emanetKitapListele = new EmanetKitapListele();
            emanetKitapListele.ShowDialog();
        }

        private void btnemanetiade_Click(object sender, EventArgs e)
        {
            EmanetKitapIade emanetKitapIade = new EmanetKitapIade();
            emanetKitapIade.ShowDialog();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
