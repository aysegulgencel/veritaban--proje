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
    public partial class EmanetVerme : Form
    {
        public EmanetVerme()
        {
            InitializeComponent();
        }

       
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=kutuphane_otomasyonu;user ID=postgres; password=16281628aG");
        DataSet daset = new DataSet();
        private void lblkitapadi_Click(object sender, EventArgs e)
        {

        }

        private void lblısbn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sepetlistele()
        {
            
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select* from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("select kitapid from kitap where isbn=@isbn " , baglanti);
            cmd2.Parameters.AddWithValue("@isbn", txtisbn.Text.ToString());
            NpgsqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
            int kitapid= int.Parse(read["kitapid"].ToString());
                baglanti.Close();
                baglanti.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("insert into sepet(kitapid,isbn,kitapadi,basim,kitapsayisi,teslimtarihi,iadetarihi) values (@kitapid,@isbn,@kitapadi,@basim,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                cmd.Connection = baglanti;

                cmd.Parameters.AddWithValue("@kitapid", kitapid);
                cmd.Parameters.AddWithValue("@isbn", txtisbn.Text.ToString()); 
                cmd.Parameters.AddWithValue("@kitapadi", txtkitapadi.Text);
                cmd.Parameters.AddWithValue("@basim", Convert.ToDateTime(txtbasim.Text));
                cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtkitapsayisi.Text));
                cmd.Parameters.AddWithValue("@teslimtarihi", Convert.ToDateTime(dateteslimtarihi.Text));
                cmd.Parameters.AddWithValue("@iadetarihi", Convert.ToDateTime(dateiadetarihi.Text));
               
                cmd.ExecuteNonQuery();
            }
            /* baglanti.Close();

             NpgsqlCommand cmd = new NpgsqlCommand("insert into sepet(isbn,kitapadi,basim,kitapsayisi,teslimtarihi,iadetarihi) values (@isbn,@kitapadi,@basim,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
             cmd.Connection = baglanti;


             cmd.Parameters.AddWithValue("@isbn", int.Parse(txtisbn.Text));
             cmd.Parameters.AddWithValue("@kitapadi", txtkitapadi.Text);
             cmd.Parameters.AddWithValue("@basim", Convert.ToDateTime(txtbasim.Text));
             cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtkitapsayisi.Text));
             cmd.Parameters.AddWithValue("@teslimtarihi", Convert.ToDateTime(dateteslimtarihi.Text));
             cmd.Parameters.AddWithValue("@iadetarihi", Convert.ToDateTime(dateiadetarihi.Text));

             cmd.ExecuteNonQuery();*/
            baglanti.Close();
            DataSet daset = new DataSet();
           // daset.Tables["sepet"].Clear();
            sepetlistele();
            lblkitapsayisi.Text = "";
            kitapsayisi();
           
            MessageBox.Show("KİTAP(LAR) SEPETE EKLENDİ.","EKLEME İŞLEMİ TAMAMLANDI.");
            

            foreach(Control item in grBkitapbilgileri.Controls)
            {
                if(item is TextBox)
                {
                    if(item!=txtkitapsayisi)
                    {
                        item.Text = "";
                    }
                }
            }

        }
        private void kitapsayisi()
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select sum(kitapsayisi) from sepet",baglanti);
            lblkitapsayisi.Text= cmd.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void EmanetVerme_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }

        private void grBkitapbilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtkid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dialog==DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from sepet where isbn=@isbn", baglanti);
                cmd.Parameters.AddWithValue("@uyeno", dataGridView1.CurrentRow.Cells["isbn"].Value.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");

                daset.Tables["sepet"].Clear();
                sepetlistele();
                lblkitapsayisi.Text = "";
                kitapsayisi();
            }
            
        }

        private void btnteslimet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (lblkitapsayisi.Text != "")
            {
                if(lblkayitlikitap.Text=="" && int.Parse(lblkitapsayisi.Text)<=3 || lblkayitlikitap.Text!="" && (int.Parse(lblkayitlikitap.Text)+int.Parse(lblkitapsayisi.Text))<=3)
                {
                    if (txtuyenobil.Text!="" && txtuyeadi.Text!="" && txtuyesoyad.Text!="" && txttel.Text!="")
                    {


                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            NpgsqlCommand cmd = new NpgsqlCommand("insert into emanetkitaplar(uyeno,uyead,uyesoyad,telno,isbn,kitapadi,basim,kitapsayisi,teslimtarihi,iadetarihi) values(@uyenobil,@uyead,@uyesoyad,@telno,@isbn,@kitapadi,@basim,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);



                            cmd.Parameters.AddWithValue("@uyeno", int.Parse(txtuyenobil.Text));
                            cmd.Parameters.AddWithValue("@uyead", txtuyeadi.Text);
                            cmd.Parameters.AddWithValue("@uyesoyad", txtuyesoyad.Text);
                            cmd.Parameters.AddWithValue("@telno", txttel.Text);


                           // cmd.Parameters.AddWithValue("@kitapid", dataGridView1.Rows[i].Cells["kitapid"].Value.ToString());
                            cmd.Parameters.AddWithValue("@isbn", dataGridView1.Rows[i].Cells["isbn"].Value.ToString());
                            cmd.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@basim", dataGridView1.Rows[i].Cells["basim"].Value.ToString());
                            cmd.Parameters.AddWithValue("@kitapsayisi", dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());



                            cmd.ExecuteNonQuery();

                            NpgsqlCommand cmd2 = new NpgsqlCommand("update uyeler set okudugukitapsayisi=okudugukitapsayisi '" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where uyeno=' " + txtuyenobil.Text + "' ", baglanti);
                            cmd2.ExecuteNonQuery();

                            NpgsqlCommand cmd3 = new NpgsqlCommand("update kitap set stok=stok '" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where  isbn=' " + dataGridView1.Rows[i].Cells["isbn"].Value.ToString() + "' ", baglanti);
                            cmd3.ExecuteNonQuery();


                        }

                        NpgsqlCommand cmd4 = new NpgsqlCommand("delete from sepet", baglanti);
                        cmd4.ExecuteNonQuery();



                        MessageBox.Show("Kitap(lar) emanet edildi.");

                        DataSet daset = new DataSet();
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtuyenobil.Text = "";
                        lblkitapsayisi.Text = "";
                        kitapsayisi();
                        lblkayitlikitap.Text = "";

                    }


                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekir!!", "Uyarı");
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3 den fazla olamaz.", "Uyarı");
                }

            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklemelidir.","Uyarı");
            }
            baglanti.Close();

        }

        private void lblkitapsayisi_Click(object sender, EventArgs e)
        {

        }

        private void txtuyenobil_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select* from uyeler where uyeno like '" + txtuyenobil.Text + "'", baglanti);
            NpgsqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                // txtuyeid.Text = read["uyeid"].ToString();
                txtuyeadi.Text = read["uyead"].ToString();
                txtuyesoyad.Text = read["uyesoyad"].ToString();
                txttel.Text = read["telno"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("select sum(kitapsayisi) from emanetkitaplar", baglanti);
            lblkayitlikitap.Text = cmd2.ExecuteScalar().ToString();

            baglanti.Close();


            if (txtuyenobil.Text == "")
            {
                foreach (Control item in grBkitapbilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayisi)
                        {
                            item.Text = "";
                        }

                    }

                }
            }
        }

        private void txtkitapno_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select* from kitap where isbn like'" + txtisbn.Text + "'", baglanti);
            NpgsqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
               // txtisbn.Text = read["isbn"].ToString();
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtbasim.Text = read["basim"].ToString();
                txtkitapsayisi.Text = read["kitapsayisi"].ToString();

            }
            baglanti.Close();

            if (txtisbn.Text == "")
            {
                foreach (Control item in grBkitapbilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
    }
}
