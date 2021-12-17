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
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuyenobil.Text = dataGridView1.CurrentRow.Cells["uyenobil"].Value.ToString();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
        DataSet daset = new DataSet();

        private void txtıd_TextChanged(object sender, EventArgs e)
        {
           /* baglanti.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select* from uyeler where uyeid like '" + txtuyenobil.Text + "'", baglanti);
                NpgsqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    txtadi.Text = read["uyead"].ToString();
                    txtsoyad.Text = read["uyesoyad"].ToString();
                    cmbcinsiyet.Text = read["uyecinsiyet"].ToString();
                    txttel.Text = read["telno"].ToString();
                    txtposta.Text = read["eposta"].ToString();
                    txtadresid.Text = read["adresid"].ToString();
                    txtokudugukitap.Text = read["okudugukitapsayisi"].ToString();


                }
            }


            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            baglanti.Close();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* baglanti.Open();
            try
            {
                // DataSet daset = new DataSet();
                daset.Tables["uyeler"].Clear();


                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from uyeler where uyeid like '%" + txtidara.Text + "%'", baglanti);

                adtr.Fill(daset, "uyeler");
                dataGridView1.DataSource = daset.Tables["uyeler"];
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            baglanti.Close();*/
        }

         

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//sil
        {

            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek mi istiyorsunuz?","Sil" ,MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dialog==DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from uyeler where uyeno=@uyeno", baglanti);
                cmd.Parameters.AddWithValue("@uyeno", dataGridView1.CurrentRow.Cells["uyeno"].Value.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");

               // DataSet daset = new DataSet();

                daset.Tables["uyeler"].Clear();//temizle

                uyelistele();//uye listele

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";//item.clear
                    }
                }
            }
           
        }

        private void uyelistele()
        {

            baglanti.Open();
            try
            {
                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from uyeler", baglanti);
                adtr.Fill(daset, "uyeler");
                dataGridView1.DataSource = daset.Tables["uyeler"];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            // daset.Tables["uyeler"].Clear();
            baglanti.Close();

        }
        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnekle_Click(object sender, EventArgs e)//guncelle
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update uyeler set uyead=@uyead,uyesoyad=@uyesoyad,uyecinsiyet=@uyecinsiyet,telno=@telno,eposta=@eposta,adresid=@adresid,okudugukitapsayisi=@okudugukitapsayisi where uyeno=@uyeno", baglanti);
            cmd.Parameters.AddWithValue("@uyeno", txtuyenobil.Text);//uye id degismeyecek 
            cmd.Parameters.AddWithValue("@uyead", txtadi.Text);
            cmd.Parameters.AddWithValue("@uyesoyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@uyecinsiyet", cmbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@telno", txttel.Text);
            cmd.Parameters.AddWithValue("@eposta", txtposta.Text);
            cmd.Parameters.AddWithValue("@adresid", int.Parse(txtadresid.Text));
            cmd.Parameters.AddWithValue("@okudugukitapsayisi", int.Parse(txtokudugukitap.Text));

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
            //DataSet daset = new DataSet();
            daset.Tables["uyeler"].Clear();

            uyelistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtadresid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtuyeno_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            try
            {
                // DataSet daset = new DataSet();
                daset.Tables["uyeler"].Clear();


                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from uyeler where uyeno like '%" + txtuyeno.Text + "%'", baglanti);

                adtr.Fill(daset, "uyeler");
                dataGridView1.DataSource = daset.Tables["uyeler"];
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            baglanti.Close();
        }

        private void txtuyenobil_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select* from uyeler where uyeno like '" + txtuyenobil.Text + "'", baglanti);
                NpgsqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    txtadi.Text = read["uyead"].ToString();
                    txtsoyad.Text = read["uyesoyad"].ToString();
                    cmbcinsiyet.Text = read["uyecinsiyet"].ToString();
                    txttel.Text = read["telno"].ToString();
                    txtposta.Text = read["eposta"].ToString();
                    txtadresid.Text = read["adresid"].ToString();
                    txtokudugukitap.Text = read["okudugukitapsayisi"].ToString();


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
