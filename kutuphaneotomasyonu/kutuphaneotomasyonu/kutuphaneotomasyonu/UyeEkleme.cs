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
using System.Data.SqlClient;

namespace kutuphaneotomasyonu
{
    public partial class UyeEkleme : Form
    {
        public UyeEkleme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
      
        private void lbluyead_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkleme_Load(object sender, EventArgs e)
        {

        }

        private void lblcinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltel_Click(object sender, EventArgs e)
        {

        }

        private void lblposta_Click(object sender, EventArgs e)
        {

        }

        private void lbladresıd_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                
                NpgsqlCommand cmd = new NpgsqlCommand("insert into uyeler (uyeno,uyead,uyesoyad ,uyecinsiyet,adresid,telno,eposta,okudugukitapsayisi) values (@uyeno,@uyead,@uyesoyad ,@uyecinsiyet,@adresid,@telno,@eposta,@okudugukitapsayisi)", baglanti);
                cmd.Connection = baglanti;

                // cmd.Parameters.AddWithValue("@uyeid",int.Parse(txtuyeid.Text));
                cmd.Parameters.AddWithValue("@uyeno", int.Parse(txtuyeno.Text));
                cmd.Parameters.AddWithValue("@uyead", txtadi.Text);
                cmd.Parameters.AddWithValue("@uyesoyad", txtsoyad.Text);
                cmd.Parameters.AddWithValue("@uyecinsiyet", cmbcinsiyet.Text);
                cmd.Parameters.AddWithValue("@telno", txttel.Text);
                cmd.Parameters.AddWithValue("@eposta", txtposta.Text);
                cmd.Parameters.AddWithValue("@adresid", int.Parse(txtadresid.Text)); 
                cmd.Parameters.AddWithValue("@okudugukitapsayisi", int.Parse(txtokudugukitap.Text));
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("ÜYE EKLEME İŞLEMİ TAMAMLANDI.");

                foreach (Control item in Controls)
                {
                    if(item is TextBox)
                    {
                        if(item!=txtokudugukitap)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            baglanti.Close();


        }
    }
}
