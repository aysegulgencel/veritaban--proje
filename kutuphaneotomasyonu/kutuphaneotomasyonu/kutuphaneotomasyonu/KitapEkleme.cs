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
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                
                NpgsqlCommand cmd = new NpgsqlCommand("insert into kitap(isbn,kitapadi,basim,sayfasayisi,stok,dolapyeri,turid,yazarid,yayineviid,kitapsayisi) values (@isbn,@kitapadi,@basim,@sayfasayisi,@stok,@dolapyeri,@turid,@yazarid,@yayineviid,@kitapsayisi)", baglanti);
                cmd.Connection = baglanti;

               // cmd.Parameters.AddWithValue("@kitapid", int.Parse(txtkitapid.Text));
                cmd.Parameters.AddWithValue("@isbn", int.Parse(txtisbn.Text));
                cmd.Parameters.AddWithValue("@kitapadi", txtkadi.Text);
                cmd.Parameters.AddWithValue("@basim", txtbasim.Text);
                cmd.Parameters.AddWithValue("@sayfasayisi", int.Parse(txtsayfa.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtstok.Text));
                cmd.Parameters.AddWithValue("@dolapyeri", txtdolapyeri.Text);
                cmd.Parameters.AddWithValue("@turid", int.Parse(txtturid.Text));
                cmd.Parameters.AddWithValue("@yazarid", int.Parse(txtyazarid.Text));
                cmd.Parameters.AddWithValue("@yayineviid", int.Parse(txtyayinevid.Text));
                cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtkitapsayisi.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("KİTAP EKLEME İŞLEMİ YAPILDI.");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapEkleme_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
