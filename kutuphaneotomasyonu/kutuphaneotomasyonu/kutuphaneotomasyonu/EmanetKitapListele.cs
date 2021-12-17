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
    public partial class EmanetKitapListele : Form
    {
        public EmanetKitapListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
        DataSet daset = new DataSet();

        private void EmanetKitapListele_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }
        private void EmanetListele()
        {
          //  baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            daset.Tables["emanetkitaplar"].Clear();
            if(comboBox1.SelectedIndex==0)
            {
                EmanetListele();
            }
            else if(comboBox1.SelectedIndex==1)
            {
               
                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar where'"+DateTime.Now.ToShortDateString() +"'>iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
                NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from emanetkitaplar where'" + DateTime.Now.ToShortDateString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                
            }
            baglanti.Close();
        }
    }
}
