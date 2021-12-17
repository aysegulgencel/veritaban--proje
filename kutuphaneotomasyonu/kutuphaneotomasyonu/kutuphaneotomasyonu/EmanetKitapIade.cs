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
    public partial class EmanetKitapIade : Form
    {
        public EmanetKitapIade()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
        DataSet daset = new DataSet();

        private void EmanetListele()
        {
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void EmanetKitapIade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnteslimal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select* from emanetkitaplar where isbn=@isbn and uyeno=@uyeno",baglanti);
            cmd.Parameters.AddWithValue("@uyeno", dataGridView1.CurrentRow.Cells["uyeno"].Value.ToString());
            cmd.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["isbn"].Value.ToString());
            cmd.ExecuteNonQuery();


            NpgsqlCommand cmd2 = new NpgsqlCommand("update kitap set stok=stok+'"+dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "'where isbn=@isbn", baglanti);
            cmd2.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["isbn"].Value.ToString());
            cmd2 .ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kitaplar iade edildi.");       
            daset.Tables["emanetkitaplar"].Clear();
            EmanetListele();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();

            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar where uyeno like '%" + txtuyeno.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();

            if (txtuyeno.Text == "")
            {
                daset.Tables["emanetkitaplar"].Clear();
                EmanetListele();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar where isbn like '%" + txtisbn.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            baglanti.Close();

            if (txtisbn.Text == "")
            {
                daset.Tables["emanetkitaplar"].Clear();
                EmanetListele();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
