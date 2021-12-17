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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
        DataSet daset = new DataSet();

        private void kitaplistele()
        {   
            
            baglanti.Open();
            try
            {
                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from kitap", baglanti);

                adtr.Fill(daset, "kitap");
                dataGridView1.DataSource = daset.Tables["kitap"];
              //  daset.Tables["kitap"].Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            baglanti.Close();


        }

        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void button2_Click(object sender, EventArgs e)//sil
        {

            DialogResult dialog;
            dialog = MessageBox.Show("Bu kitabı silmek mi istiyorsunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from kitap where isbn=@isbn", baglanti);
                cmd.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["isbn"].Value.ToString());

            

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");

                DataSet daset = new DataSet();
                //daset.Tables["kitap"].Clear();

                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)//güncelleme
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update kitap set kitapadi=@kitapadi,basim=@basim,sayfasayisi=@sayfasayisi,turid=@turid,yazarid=@yazarid,yayineviid=@yayineviid,stok=@stok,dolapyeri=@dolapyeri  where isbn=@isbn", baglanti);
            
          
            cmd.Parameters.AddWithValue("@isbn", txtisbn.Text);
            cmd.Parameters.AddWithValue("@kitapadi", txtkadi.Text);
            cmd.Parameters.AddWithValue("@basim", txtbasim.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", int.Parse(txtsayfa.Text));
            cmd.Parameters.AddWithValue("@turid",int.Parse(txtturid.Text));
            cmd.Parameters.AddWithValue("@yazarid",int.Parse(txtyazarid.Text));
            cmd.Parameters.AddWithValue("@yayineviid", int.Parse(txtyayinevid.Text));
            cmd.Parameters.AddWithValue("@stok", int.Parse(txtstok.Text));
            cmd.Parameters.AddWithValue("@dolapyeri", txtdolapyeri.Text);
            
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
     
           // daset.Tables["kitap"].Clear();

            kitaplistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

       private void txtbxkitapİd_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {     
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtisbnara_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select* from kitap where isbn like '" + txtisbn.Text + "'", baglanti);
            NpgsqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                
                txtisbn.Text = read["isbn"].ToString();
                txtkadi.Text = read["kitapadi"].ToString();
                txtbasim.Text = read["basim"].ToString();
                txtsayfa.Text = read["sayfasayisi"].ToString();
                txtturid.Text = read["turid"].ToString();
                txtyazarid.Text = read["yazarid"].ToString();
                txtyayinevid.Text = read["yayineviid"].ToString();
                txtstok.Text = read["stok"].ToString();
                txtdolapyeri.Text = read["dolapyeri"].ToString();

            }

            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();


            daset.Tables["kitap"].Clear();


            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from kitap where isbn like '%" + txtkitapnoara.Text + "%'", baglanti);

            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();

        }
    }
}
