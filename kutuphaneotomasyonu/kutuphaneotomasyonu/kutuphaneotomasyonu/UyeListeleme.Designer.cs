
namespace kutuphaneotomasyonu
{
    partial class UyeListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.lbladresıd = new System.Windows.Forms.Label();
            this.lblposta = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbluyead = new System.Windows.Forms.Label();
            this.txtadresid = new System.Windows.Forms.TextBox();
            this.txtposta = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblokudugukitap = new System.Windows.Forms.Label();
            this.txtokudugukitap = new System.Windows.Forms.TextBox();
            this.lbluyeno = new System.Windows.Forms.Label();
            this.txtuyeno = new System.Windows.Forms.TextBox();
            this.lbluyenobil = new System.Windows.Forms.Label();
            this.txtuyenobil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(221, 483);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(95, 39);
            this.btniptal.TabIndex = 35;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(75, 484);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(124, 39);
            this.btnekle.TabIndex = 34;
            this.btnekle.Text = "Güncelle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lbladresıd
            // 
            this.lbladresıd.AutoSize = true;
            this.lbladresıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladresıd.Location = new System.Drawing.Point(70, 329);
            this.lbladresıd.Name = "lbladresıd";
            this.lbladresıd.Size = new System.Drawing.Size(71, 20);
            this.lbladresıd.TabIndex = 32;
            this.lbladresıd.Text = "Adres Id";
            // 
            // lblposta
            // 
            this.lblposta.AutoSize = true;
            this.lblposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblposta.Location = new System.Drawing.Point(70, 280);
            this.lblposta.Name = "lblposta";
            this.lblposta.Size = new System.Drawing.Size(63, 20);
            this.lblposta.TabIndex = 31;
            this.lblposta.Text = "EPosta";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(195, 177);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbcinsiyet.TabIndex = 30;
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(70, 184);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(69, 20);
            this.lblcinsiyet.TabIndex = 29;
            this.lblcinsiyet.Text = "Cinsiyet";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Location = new System.Drawing.Point(70, 230);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(90, 20);
            this.lbltel.TabIndex = 28;
            this.lbltel.Text = "Telefon No";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(70, 131);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(89, 20);
            this.lblsoyad.TabIndex = 27;
            this.lblsoyad.Text = "Üye Soyad";
            // 
            // lbluyead
            // 
            this.lbluyead.AutoSize = true;
            this.lbluyead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyead.Location = new System.Drawing.Point(70, 93);
            this.lbluyead.Name = "lbluyead";
            this.lbluyead.Size = new System.Drawing.Size(67, 20);
            this.lbluyead.TabIndex = 26;
            this.lbluyead.Text = "Üye Adı";
            // 
            // txtadresid
            // 
            this.txtadresid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadresid.Location = new System.Drawing.Point(195, 324);
            this.txtadresid.Name = "txtadresid";
            this.txtadresid.Size = new System.Drawing.Size(121, 27);
            this.txtadresid.TabIndex = 25;
            this.txtadresid.TextChanged += new System.EventHandler(this.txtadresid_TextChanged);
            // 
            // txtposta
            // 
            this.txtposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtposta.Location = new System.Drawing.Point(195, 280);
            this.txtposta.Name = "txtposta";
            this.txtposta.Size = new System.Drawing.Size(121, 27);
            this.txtposta.TabIndex = 24;
            this.txtposta.TextChanged += new System.EventHandler(this.txtposta_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(195, 230);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(121, 27);
            this.txttel.TabIndex = 22;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(195, 128);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 27);
            this.txtsoyad.TabIndex = 21;
            // 
            // txtadi
            // 
            this.txtadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadi.Location = new System.Drawing.Point(195, 88);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(121, 27);
            this.txtadi.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1211, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblokudugukitap
            // 
            this.lblokudugukitap.AutoSize = true;
            this.lblokudugukitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblokudugukitap.Location = new System.Drawing.Point(12, 375);
            this.lblokudugukitap.Name = "lblokudugukitap";
            this.lblokudugukitap.Size = new System.Drawing.Size(168, 20);
            this.lblokudugukitap.TabIndex = 40;
            this.lblokudugukitap.Text = "Okuduğu Kitap Sayisi";
            this.lblokudugukitap.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtokudugukitap
            // 
            this.txtokudugukitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtokudugukitap.Location = new System.Drawing.Point(195, 372);
            this.txtokudugukitap.Name = "txtokudugukitap";
            this.txtokudugukitap.Size = new System.Drawing.Size(121, 27);
            this.txtokudugukitap.TabIndex = 39;
            this.txtokudugukitap.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbluyeno
            // 
            this.lbluyeno.AutoSize = true;
            this.lbluyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyeno.Location = new System.Drawing.Point(624, 48);
            this.lbluyeno.Name = "lbluyeno";
            this.lbluyeno.Size = new System.Drawing.Size(113, 25);
            this.lbluyeno.TabIndex = 42;
            this.lbluyeno.Text = "Uye No Ara";
            this.lbluyeno.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtuyeno
            // 
            this.txtuyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuyeno.Location = new System.Drawing.Point(774, 48);
            this.txtuyeno.Name = "txtuyeno";
            this.txtuyeno.Size = new System.Drawing.Size(135, 27);
            this.txtuyeno.TabIndex = 41;
            this.txtuyeno.TextChanged += new System.EventHandler(this.txtuyeno_TextChanged);
            // 
            // lbluyenobil
            // 
            this.lbluyenobil.AutoSize = true;
            this.lbluyenobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyenobil.Location = new System.Drawing.Point(77, 51);
            this.lbluyenobil.Name = "lbluyenobil";
            this.lbluyenobil.Size = new System.Drawing.Size(64, 20);
            this.lbluyenobil.TabIndex = 44;
            this.lbluyenobil.Text = "Üye No";
            // 
            // txtuyenobil
            // 
            this.txtuyenobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuyenobil.Location = new System.Drawing.Point(195, 44);
            this.txtuyenobil.Name = "txtuyenobil";
            this.txtuyenobil.Size = new System.Drawing.Size(121, 27);
            this.txtuyenobil.TabIndex = 43;
            this.txtuyenobil.TextChanged += new System.EventHandler(this.txtuyenobil_TextChanged);
            // 
            // UyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 673);
            this.Controls.Add(this.lbluyenobil);
            this.Controls.Add(this.txtuyenobil);
            this.Controls.Add(this.lbluyeno);
            this.Controls.Add(this.txtuyeno);
            this.Controls.Add(this.lblokudugukitap);
            this.Controls.Add(this.txtokudugukitap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lbladresıd);
            this.Controls.Add(this.lblposta);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lbluyead);
            this.Controls.Add(this.txtadresid);
            this.Controls.Add(this.txtposta);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListeleme";
            this.Text = "UyeListeleme";
            this.Load += new System.EventHandler(this.UyeListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label lbladresıd;
        private System.Windows.Forms.Label lblposta;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbluyead;
        private System.Windows.Forms.TextBox txtadresid;
        private System.Windows.Forms.TextBox txtposta;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblokudugukitap;
        private System.Windows.Forms.TextBox txtokudugukitap;
        private System.Windows.Forms.Label lbluyeno;
        private System.Windows.Forms.TextBox txtuyeno;
        private System.Windows.Forms.Label lbluyenobil;
        private System.Windows.Forms.TextBox txtuyenobil;
    }
}