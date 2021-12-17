
namespace kutuphaneotomasyonu
{
    partial class UyeEkleme
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
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadresid = new System.Windows.Forms.TextBox();
            this.txtposta = new System.Windows.Forms.TextBox();
            this.lbluyead = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.lblposta = new System.Windows.Forms.Label();
            this.lbladresıd = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.lblokudugukitap = new System.Windows.Forms.Label();
            this.txtokudugukitap = new System.Windows.Forms.TextBox();
            this.lbluyeno = new System.Windows.Forms.Label();
            this.txtuyeno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtadi
            // 
            this.txtadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadi.Location = new System.Drawing.Point(290, 143);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(121, 27);
            this.txtadi.TabIndex = 0;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(290, 183);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 27);
            this.txtsoyad.TabIndex = 1;
            this.txtsoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(290, 285);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(121, 27);
            this.txttel.TabIndex = 2;
            // 
            // txtadresid
            // 
            this.txtadresid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadresid.Location = new System.Drawing.Point(290, 379);
            this.txtadresid.Name = "txtadresid";
            this.txtadresid.Size = new System.Drawing.Size(121, 27);
            this.txtadresid.TabIndex = 8;
            // 
            // txtposta
            // 
            this.txtposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtposta.Location = new System.Drawing.Point(290, 335);
            this.txtposta.Name = "txtposta";
            this.txtposta.Size = new System.Drawing.Size(121, 27);
            this.txtposta.TabIndex = 6;
            // 
            // lbluyead
            // 
            this.lbluyead.AutoSize = true;
            this.lbluyead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyead.Location = new System.Drawing.Point(165, 148);
            this.lbluyead.Name = "lbluyead";
            this.lbluyead.Size = new System.Drawing.Size(67, 20);
            this.lbluyead.TabIndex = 9;
            this.lbluyead.Text = "Üye Adı";
            this.lbluyead.Click += new System.EventHandler(this.lbluyead_Click);
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(165, 186);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(89, 20);
            this.lblsoyad.TabIndex = 10;
            this.lblsoyad.Text = "Üye Soyad";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Location = new System.Drawing.Point(165, 285);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(90, 20);
            this.lbltel.TabIndex = 11;
            this.lbltel.Text = "Telefon No";
            this.lbltel.Click += new System.EventHandler(this.lbltel_Click);
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(165, 239);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(69, 20);
            this.lblcinsiyet.TabIndex = 12;
            this.lblcinsiyet.Text = "Cinsiyet";
            this.lblcinsiyet.Click += new System.EventHandler(this.lblcinsiyet_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(290, 232);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbcinsiyet.TabIndex = 13;
            // 
            // lblposta
            // 
            this.lblposta.AutoSize = true;
            this.lblposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblposta.Location = new System.Drawing.Point(165, 335);
            this.lblposta.Name = "lblposta";
            this.lblposta.Size = new System.Drawing.Size(63, 20);
            this.lblposta.TabIndex = 14;
            this.lblposta.Text = "EPosta";
            this.lblposta.Click += new System.EventHandler(this.lblposta_Click);
            // 
            // lbladresıd
            // 
            this.lbladresıd.AutoSize = true;
            this.lbladresıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladresıd.Location = new System.Drawing.Point(165, 384);
            this.lbladresıd.Name = "lbladresıd";
            this.lbladresıd.Size = new System.Drawing.Size(71, 20);
            this.lbladresıd.TabIndex = 15;
            this.lbladresıd.Text = "Adres Id";
            this.lbladresıd.Click += new System.EventHandler(this.lbladresıd_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(132, 482);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 39);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(360, 482);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 39);
            this.btniptal.TabIndex = 19;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // lblokudugukitap
            // 
            this.lblokudugukitap.AutoSize = true;
            this.lblokudugukitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblokudugukitap.Location = new System.Drawing.Point(99, 425);
            this.lblokudugukitap.Name = "lblokudugukitap";
            this.lblokudugukitap.Size = new System.Drawing.Size(168, 20);
            this.lblokudugukitap.TabIndex = 21;
            this.lblokudugukitap.Text = "Okuduğu Kitap Sayısı";
            // 
            // txtokudugukitap
            // 
            this.txtokudugukitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtokudugukitap.Location = new System.Drawing.Point(290, 422);
            this.txtokudugukitap.Name = "txtokudugukitap";
            this.txtokudugukitap.Size = new System.Drawing.Size(121, 27);
            this.txtokudugukitap.TabIndex = 20;
            this.txtokudugukitap.Text = "0";
            this.txtokudugukitap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbluyeno
            // 
            this.lbluyeno.AutoSize = true;
            this.lbluyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyeno.Location = new System.Drawing.Point(165, 100);
            this.lbluyeno.Name = "lbluyeno";
            this.lbluyeno.Size = new System.Drawing.Size(64, 20);
            this.lbluyeno.TabIndex = 25;
            this.lbluyeno.Text = "Üye No";
            // 
            // txtuyeno
            // 
            this.txtuyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuyeno.Location = new System.Drawing.Point(290, 95);
            this.txtuyeno.Name = "txtuyeno";
            this.txtuyeno.Size = new System.Drawing.Size(121, 27);
            this.txtuyeno.TabIndex = 24;
            // 
            // UyeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 576);
            this.Controls.Add(this.lbluyeno);
            this.Controls.Add(this.txtuyeno);
            this.Controls.Add(this.lblokudugukitap);
            this.Controls.Add(this.txtokudugukitap);
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
            this.Name = "UyeEkleme";
            this.Text = "Üye Ekleme Sayfası";
            this.Load += new System.EventHandler(this.UyeEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadresid;
        private System.Windows.Forms.TextBox txtposta;
        private System.Windows.Forms.Label lbluyead;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label lblposta;
        private System.Windows.Forms.Label lbladresıd;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label lblokudugukitap;
        private System.Windows.Forms.TextBox txtokudugukitap;
        private System.Windows.Forms.Label lbluyeno;
        private System.Windows.Forms.TextBox txtuyeno;
    }
}