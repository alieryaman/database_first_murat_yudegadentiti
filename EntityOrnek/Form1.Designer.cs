namespace EntityOrnek
{
    partial class Form1
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
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.TxtOgrenciId = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOgrenciFoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciad = new System.Windows.Forms.TextBox();
            this.OgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ortalama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DersAd = new System.Windows.Forms.TextBox();
            this.DersId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NotGuncelle = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.NotListesi = new System.Windows.Forms.Button();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.BtnProcedure = new System.Windows.Forms.Button();
            this.buttonjoinilegetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TxtOgrenciId.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(2, 171);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(75, 23);
            this.BtnListele.TabIndex = 1;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(2, 230);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(2, 301);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(2, 366);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(2, 415);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(75, 23);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtOgrenciId
            // 
            this.TxtOgrenciId.Controls.Add(this.label4);
            this.TxtOgrenciId.Controls.Add(this.TxtOgrenciFoto);
            this.TxtOgrenciId.Controls.Add(this.label3);
            this.TxtOgrenciId.Controls.Add(this.TxtOgrenciSoyad);
            this.TxtOgrenciId.Controls.Add(this.label2);
            this.TxtOgrenciId.Controls.Add(this.TxtOgrenciad);
            this.TxtOgrenciId.Controls.Add(this.OgrenciId);
            this.TxtOgrenciId.Controls.Add(this.label1);
            this.TxtOgrenciId.Location = new System.Drawing.Point(83, 172);
            this.TxtOgrenciId.Name = "TxtOgrenciId";
            this.TxtOgrenciId.Size = new System.Drawing.Size(346, 217);
            this.TxtOgrenciId.TabIndex = 14;
            this.TxtOgrenciId.TabStop = false;
            this.TxtOgrenciId.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // TxtOgrenciFoto
            // 
            this.TxtOgrenciFoto.Location = new System.Drawing.Point(172, 172);
            this.TxtOgrenciFoto.Name = "TxtOgrenciFoto";
            this.TxtOgrenciFoto.Size = new System.Drawing.Size(169, 22);
            this.TxtOgrenciFoto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "SOYAD:";
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(172, 121);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(169, 22);
            this.TxtOgrenciSoyad.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "AD:";
            // 
            // TxtOgrenciad
            // 
            this.TxtOgrenciad.Location = new System.Drawing.Point(172, 69);
            this.TxtOgrenciad.Name = "TxtOgrenciad";
            this.TxtOgrenciad.Size = new System.Drawing.Size(169, 22);
            this.TxtOgrenciad.TabIndex = 16;
            this.TxtOgrenciad.TextChanged += new System.EventHandler(this.TxtOgrenciad_TextChanged);
            // 
            // OgrenciId
            // 
            this.OgrenciId.Location = new System.Drawing.Point(172, 23);
            this.OgrenciId.Name = "OgrenciId";
            this.OgrenciId.Size = new System.Drawing.Size(169, 22);
            this.OgrenciId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Ortalama);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtSinav3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtSinav2);
            this.groupBox2.Controls.Add(this.TxtSinav1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(442, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 217);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ORTALAMA";
            // 
            // Ortalama
            // 
            this.Ortalama.Location = new System.Drawing.Point(172, 172);
            this.Ortalama.Name = "Ortalama";
            this.Ortalama.Size = new System.Drawing.Size(169, 22);
            this.Ortalama.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "SINAV3";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(172, 121);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(169, 22);
            this.TxtSinav3.TabIndex = 18;
            this.TxtSinav3.Text = "Btnd ders listesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "SINAV2";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(172, 69);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(169, 22);
            this.TxtSinav2.TabIndex = 16;
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(172, 23);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(169, 22);
            this.TxtSinav1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "SINAV1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DersAd);
            this.groupBox3.Controls.Add(this.DersId);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(196, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 170);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "AD:";
            // 
            // DersAd
            // 
            this.DersAd.Location = new System.Drawing.Point(48, 84);
            this.DersAd.Name = "DersAd";
            this.DersAd.Size = new System.Drawing.Size(169, 22);
            this.DersAd.TabIndex = 16;
            // 
            // DersId
            // 
            this.DersId.Location = new System.Drawing.Point(48, 38);
            this.DersId.Name = "DersId";
            this.DersId.Size = new System.Drawing.Size(169, 22);
            this.DersId.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "ID";
            // 
            // NotGuncelle
            // 
            this.NotGuncelle.Location = new System.Drawing.Point(545, 404);
            this.NotGuncelle.Name = "NotGuncelle";
            this.NotGuncelle.Size = new System.Drawing.Size(108, 23);
            this.NotGuncelle.TabIndex = 17;
            this.NotGuncelle.Text = "Güncelle Nutu";
            this.NotGuncelle.UseVisualStyleBackColor = true;
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(545, 473);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(108, 23);
            this.Hesapla.TabIndex = 18;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            // 
            // NotListesi
            // 
            this.NotListesi.Location = new System.Drawing.Point(16, 473);
            this.NotListesi.Name = "NotListesi";
            this.NotListesi.Size = new System.Drawing.Size(111, 23);
            this.NotListesi.TabIndex = 19;
            this.NotListesi.Text = "Not Listesi";
            this.NotListesi.UseVisualStyleBackColor = true;
            this.NotListesi.Click += new System.EventHandler(this.NotListesi_Click);
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Location = new System.Drawing.Point(2, 524);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(125, 23);
            this.BtnDersListesi.TabIndex = 20;
            this.BtnDersListesi.Text = "Btn ders listesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // BtnProcedure
            // 
            this.BtnProcedure.Location = new System.Drawing.Point(-7, 582);
            this.BtnProcedure.Name = "BtnProcedure";
            this.BtnProcedure.Size = new System.Drawing.Size(125, 23);
            this.BtnProcedure.TabIndex = 21;
            this.BtnProcedure.Text = "PRODECURE NOT LİSTESİ";
            this.BtnProcedure.UseVisualStyleBackColor = true;
            this.BtnProcedure.Click += new System.EventHandler(this.BtnProcedure_Click);
            // 
            // buttonjoinilegetir
            // 
            this.buttonjoinilegetir.Location = new System.Drawing.Point(545, 524);
            this.buttonjoinilegetir.Name = "buttonjoinilegetir";
            this.buttonjoinilegetir.Size = new System.Drawing.Size(108, 23);
            this.buttonjoinilegetir.TabIndex = 22;
            this.buttonjoinilegetir.Text = "Join İle Getir";
            this.buttonjoinilegetir.UseVisualStyleBackColor = true;
            this.buttonjoinilegetir.Click += new System.EventHandler(this.buttonjoinilegetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.buttonjoinilegetir);
            this.Controls.Add(this.BtnProcedure);
            this.Controls.Add(this.BtnDersListesi);
            this.Controls.Add(this.NotListesi);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.NotGuncelle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtOgrenciId);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TxtOgrenciId.ResumeLayout(false);
            this.TxtOgrenciId.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox TxtOgrenciId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOgrenciFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciad;
        private System.Windows.Forms.TextBox OgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ortalama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DersAd;
        private System.Windows.Forms.TextBox DersId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NotGuncelle;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Button NotListesi;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.Button BtnProcedure;
        private System.Windows.Forms.Button buttonjoinilegetir;
    }
}

