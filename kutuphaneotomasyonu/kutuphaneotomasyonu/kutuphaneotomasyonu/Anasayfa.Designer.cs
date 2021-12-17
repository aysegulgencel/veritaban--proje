
namespace kutuphaneotomasyonu
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnuyekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnemanetiade = new System.Windows.Forms.Button();
            this.btnemanetverme = new System.Windows.Forms.Button();
            this.btnemanetlisteleme = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnkitaplistele = new System.Windows.Forms.Button();
            this.btnkitapekleme = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnuyekle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(86, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(325, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Üye Listeleme İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnuyekle
            // 
            this.btnuyekle.Location = new System.Drawing.Point(7, 34);
            this.btnuyekle.Name = "btnuyekle";
            this.btnuyekle.Size = new System.Drawing.Size(324, 58);
            this.btnuyekle.TabIndex = 4;
            this.btnuyekle.Text = "Üye Ekleme İşlemleri";
            this.btnuyekle.UseVisualStyleBackColor = true;
            this.btnuyekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnemanetiade);
            this.groupBox2.Controls.Add(this.btnemanetverme);
            this.groupBox2.Controls.Add(this.btnemanetlisteleme);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(86, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emanet İşlemleri";
            // 
            // btnemanetiade
            // 
            this.btnemanetiade.Location = new System.Drawing.Point(19, 191);
            this.btnemanetiade.Name = "btnemanetiade";
            this.btnemanetiade.Size = new System.Drawing.Size(312, 58);
            this.btnemanetiade.TabIndex = 4;
            this.btnemanetiade.Text = "Emanet Kitap İade İşlemleri";
            this.btnemanetiade.UseVisualStyleBackColor = true;
            this.btnemanetiade.Click += new System.EventHandler(this.btnemanetiade_Click);
            // 
            // btnemanetverme
            // 
            this.btnemanetverme.Location = new System.Drawing.Point(19, 53);
            this.btnemanetverme.Name = "btnemanetverme";
            this.btnemanetverme.Size = new System.Drawing.Size(312, 66);
            this.btnemanetverme.TabIndex = 6;
            this.btnemanetverme.Text = "Emanet Kitap Verme İşlemleri";
            this.btnemanetverme.UseVisualStyleBackColor = true;
            this.btnemanetverme.Click += new System.EventHandler(this.btnemanetverme_Click);
            // 
            // btnemanetlisteleme
            // 
            this.btnemanetlisteleme.Location = new System.Drawing.Point(19, 125);
            this.btnemanetlisteleme.Name = "btnemanetlisteleme";
            this.btnemanetlisteleme.Size = new System.Drawing.Size(312, 60);
            this.btnemanetlisteleme.TabIndex = 7;
            this.btnemanetlisteleme.Text = "Emanet Kitap Listeleme İşlemleri";
            this.btnemanetlisteleme.UseVisualStyleBackColor = true;
            this.btnemanetlisteleme.Click += new System.EventHandler(this.btnemanetlisteleme_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnkitaplistele);
            this.groupBox4.Controls.Add(this.btnkitapekleme);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(515, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 181);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap İşlemleri";
            // 
            // btnkitaplistele
            // 
            this.btnkitaplistele.Location = new System.Drawing.Point(0, 110);
            this.btnkitaplistele.Name = "btnkitaplistele";
            this.btnkitaplistele.Size = new System.Drawing.Size(260, 61);
            this.btnkitaplistele.TabIndex = 4;
            this.btnkitaplistele.Text = "Kitap Listeleme İşlemleri";
            this.btnkitaplistele.UseVisualStyleBackColor = true;
            this.btnkitaplistele.Click += new System.EventHandler(this.btnkitaplistele_Click);
            // 
            // btnkitapekleme
            // 
            this.btnkitapekleme.Location = new System.Drawing.Point(0, 37);
            this.btnkitapekleme.Name = "btnkitapekleme";
            this.btnkitapekleme.Size = new System.Drawing.Size(260, 55);
            this.btnkitapekleme.TabIndex = 5;
            this.btnkitapekleme.Text = "Kitap Ekleme İşlemleri";
            this.btnkitapekleme.UseVisualStyleBackColor = true;
            this.btnkitapekleme.Click += new System.EventHandler(this.btnkitapekleme_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(664, 477);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(111, 66);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 583);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anasayfa";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnuyekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnemanetiade;
        private System.Windows.Forms.Button btnemanetverme;
        private System.Windows.Forms.Button btnemanetlisteleme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnkitaplistele;
        private System.Windows.Forms.Button btnkitapekleme;
        private System.Windows.Forms.Button btncikis;
    }
}

