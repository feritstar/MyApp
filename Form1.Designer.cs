﻿
namespace MyApp
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
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOgrenciFotoPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOgrenciSoyAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetByJoin = new System.Windows.Forms.Button();
            this.btnOrtalamaHesapla = new System.Windows.Forms.Button();
            this.textBoxDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSınav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSınav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSınav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnProsedur = new System.Windows.Forms.Button();
            this.radioBtnIsmeGoreSirala = new System.Windows.Forms.RadioButton();
            this.radioBtnIsmeGoreTersSirala = new System.Windows.Forms.RadioButton();
            this.radioBtnIlk3KaydiGöster = new System.Windows.Forms.RadioButton();
            this.radioBtnGetByID = new System.Windows.Forms.RadioButton();
            this.textBoxGeByID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonGetByFirstChar = new System.Windows.Forms.RadioButton();
            this.textBoxGetByFirstChar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonGetByLastChar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1104, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciListele.Location = new System.Drawing.Point(18, 351);
            this.btnOgrenciListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(194, 47);
            this.btnOgrenciListele.TabIndex = 1;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(18, 411);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(194, 47);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(18, 531);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(194, 47);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(18, 471);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 47);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(18, 591);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(194, 47);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOgrenciFotoPath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxOgrenciSoyAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxOgrenciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOgrenciId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(238, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Bilgisi";
            // 
            // textBoxOgrenciFotoPath
            // 
            this.textBoxOgrenciFotoPath.Location = new System.Drawing.Point(124, 165);
            this.textBoxOgrenciFotoPath.Name = "textBoxOgrenciFotoPath";
            this.textBoxOgrenciFotoPath.Size = new System.Drawing.Size(100, 26);
            this.textBoxOgrenciFotoPath.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Foto Path:";
            // 
            // textBoxOgrenciSoyAd
            // 
            this.textBoxOgrenciSoyAd.Location = new System.Drawing.Point(124, 121);
            this.textBoxOgrenciSoyAd.Name = "textBoxOgrenciSoyAd";
            this.textBoxOgrenciSoyAd.Size = new System.Drawing.Size(100, 26);
            this.textBoxOgrenciSoyAd.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "SOYAD:";
            // 
            // textBoxOgrenciAdi
            // 
            this.textBoxOgrenciAdi.Location = new System.Drawing.Point(124, 81);
            this.textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            this.textBoxOgrenciAdi.Size = new System.Drawing.Size(100, 26);
            this.textBoxOgrenciAdi.TabIndex = 17;
            this.textBoxOgrenciAdi.TextChanged += new System.EventHandler(this.textBoxOgrenciAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "AD:";
            // 
            // textBoxOgrenciId
            // 
            this.textBoxOgrenciId.Location = new System.Drawing.Point(124, 37);
            this.textBoxOgrenciId.Name = "textBoxOgrenciId";
            this.textBoxOgrenciId.Size = new System.Drawing.Size(100, 26);
            this.textBoxOgrenciId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDersAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDersId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(238, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 135);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Bilgisi";
            // 
            // textBoxDersAdi
            // 
            this.textBoxDersAdi.Location = new System.Drawing.Point(124, 81);
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(100, 26);
            this.textBoxDersAdi.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ders Adi:";
            // 
            // textBoxDersId
            // 
            this.textBoxDersId.Location = new System.Drawing.Point(124, 37);
            this.textBoxDersId.Name = "textBoxDersId";
            this.textBoxDersId.Size = new System.Drawing.Size(100, 26);
            this.textBoxDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ders ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetByJoin);
            this.groupBox3.Controls.Add(this.btnOrtalamaHesapla);
            this.groupBox3.Controls.Add(this.textBoxDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxOrtalama);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSınav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxSınav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxSınav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(520, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 352);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Bilgisi";
            // 
            // btnGetByJoin
            // 
            this.btnGetByJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetByJoin.Location = new System.Drawing.Point(30, 298);
            this.btnGetByJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetByJoin.Name = "btnGetByJoin";
            this.btnGetByJoin.Size = new System.Drawing.Size(194, 47);
            this.btnGetByJoin.TabIndex = 26;
            this.btnGetByJoin.Text = "Join ile Getir";
            this.btnGetByJoin.UseVisualStyleBackColor = true;
            this.btnGetByJoin.Click += new System.EventHandler(this.btnGetByJoin_Click);
            // 
            // btnOrtalamaHesapla
            // 
            this.btnOrtalamaHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalamaHesapla.Location = new System.Drawing.Point(30, 237);
            this.btnOrtalamaHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrtalamaHesapla.Name = "btnOrtalamaHesapla";
            this.btnOrtalamaHesapla.Size = new System.Drawing.Size(194, 47);
            this.btnOrtalamaHesapla.TabIndex = 25;
            this.btnOrtalamaHesapla.Text = "Ortalama Hesapla";
            this.btnOrtalamaHesapla.UseVisualStyleBackColor = true;
            // 
            // textBoxDurum
            // 
            this.textBoxDurum.Location = new System.Drawing.Point(124, 197);
            this.textBoxDurum.Name = "textBoxDurum";
            this.textBoxDurum.Size = new System.Drawing.Size(100, 26);
            this.textBoxDurum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "DURUM:";
            // 
            // textBoxOrtalama
            // 
            this.textBoxOrtalama.Location = new System.Drawing.Point(124, 157);
            this.textBoxOrtalama.Name = "textBoxOrtalama";
            this.textBoxOrtalama.Size = new System.Drawing.Size(100, 26);
            this.textBoxOrtalama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "ORTALAMA:";
            // 
            // textBoxSınav3
            // 
            this.textBoxSınav3.Location = new System.Drawing.Point(124, 117);
            this.textBoxSınav3.Name = "textBoxSınav3";
            this.textBoxSınav3.Size = new System.Drawing.Size(100, 26);
            this.textBoxSınav3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "SINAV 3:";
            // 
            // textBoxSınav2
            // 
            this.textBoxSınav2.Location = new System.Drawing.Point(124, 77);
            this.textBoxSınav2.Name = "textBoxSınav2";
            this.textBoxSınav2.Size = new System.Drawing.Size(100, 26);
            this.textBoxSınav2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "SINAV 2:";
            // 
            // textBoxSınav1
            // 
            this.textBoxSınav1.Location = new System.Drawing.Point(124, 37);
            this.textBoxSınav1.Name = "textBoxSınav1";
            this.textBoxSınav1.Size = new System.Drawing.Size(100, 26);
            this.textBoxSınav1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "SINAV 1:";
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersListesi.Location = new System.Drawing.Point(18, 651);
            this.btnDersListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(194, 47);
            this.btnDersListesi.TabIndex = 23;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotListesi.Location = new System.Drawing.Point(18, 711);
            this.btnNotListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(194, 47);
            this.btnNotListesi.TabIndex = 24;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(238, 711);
            this.btnDersEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(194, 47);
            this.btnDersEkle.TabIndex = 25;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnProsedur
            // 
            this.btnProsedur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProsedur.Location = new System.Drawing.Point(18, 768);
            this.btnProsedur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProsedur.Name = "btnProsedur";
            this.btnProsedur.Size = new System.Drawing.Size(194, 47);
            this.btnProsedur.TabIndex = 26;
            this.btnProsedur.Text = "Prosedür";
            this.btnProsedur.UseVisualStyleBackColor = true;
            this.btnProsedur.Click += new System.EventHandler(this.btnProsedur_Click);
            // 
            // radioBtnIsmeGoreSirala
            // 
            this.radioBtnIsmeGoreSirala.AutoSize = true;
            this.radioBtnIsmeGoreSirala.Location = new System.Drawing.Point(803, 380);
            this.radioBtnIsmeGoreSirala.Name = "radioBtnIsmeGoreSirala";
            this.radioBtnIsmeGoreSirala.Size = new System.Drawing.Size(200, 24);
            this.radioBtnIsmeGoreSirala.TabIndex = 27;
            this.radioBtnIsmeGoreSirala.TabStop = true;
            this.radioBtnIsmeGoreSirala.Text = "İsme Göre Sırala (A-->Z)";
            this.radioBtnIsmeGoreSirala.UseVisualStyleBackColor = true;
            this.radioBtnIsmeGoreSirala.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnIsmeGoreTersSirala
            // 
            this.radioBtnIsmeGoreTersSirala.AutoSize = true;
            this.radioBtnIsmeGoreTersSirala.Location = new System.Drawing.Point(803, 410);
            this.radioBtnIsmeGoreTersSirala.Name = "radioBtnIsmeGoreTersSirala";
            this.radioBtnIsmeGoreTersSirala.Size = new System.Drawing.Size(200, 24);
            this.radioBtnIsmeGoreTersSirala.TabIndex = 28;
            this.radioBtnIsmeGoreTersSirala.TabStop = true;
            this.radioBtnIsmeGoreTersSirala.Text = "İsme Göre Sırala (Z-->A)";
            this.radioBtnIsmeGoreTersSirala.UseVisualStyleBackColor = true;
            this.radioBtnIsmeGoreTersSirala.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnIlk3KaydiGöster
            // 
            this.radioBtnIlk3KaydiGöster.AutoSize = true;
            this.radioBtnIlk3KaydiGöster.Location = new System.Drawing.Point(803, 440);
            this.radioBtnIlk3KaydiGöster.Name = "radioBtnIlk3KaydiGöster";
            this.radioBtnIlk3KaydiGöster.Size = new System.Drawing.Size(151, 24);
            this.radioBtnIlk3KaydiGöster.TabIndex = 29;
            this.radioBtnIlk3KaydiGöster.TabStop = true;
            this.radioBtnIlk3KaydiGöster.Text = "İlk 3 Kaydı Göster";
            this.radioBtnIlk3KaydiGöster.UseVisualStyleBackColor = true;
            this.radioBtnIlk3KaydiGöster.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioBtnGetByID
            // 
            this.radioBtnGetByID.AutoSize = true;
            this.radioBtnGetByID.Location = new System.Drawing.Point(803, 470);
            this.radioBtnGetByID.Name = "radioBtnGetByID";
            this.radioBtnGetByID.Size = new System.Drawing.Size(174, 24);
            this.radioBtnGetByID.TabIndex = 30;
            this.radioBtnGetByID.TabStop = true;
            this.radioBtnGetByID.Text = "ID\'ye Göre Veri Getir";
            this.radioBtnGetByID.UseVisualStyleBackColor = true;
            this.radioBtnGetByID.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxGeByID
            // 
            this.textBoxGeByID.Location = new System.Drawing.Point(1071, 466);
            this.textBoxGeByID.Name = "textBoxGeByID";
            this.textBoxGeByID.Size = new System.Drawing.Size(51, 26);
            this.textBoxGeByID.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1038, 469);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "ID:";
            // 
            // radioButtonGetByFirstChar
            // 
            this.radioButtonGetByFirstChar.AutoSize = true;
            this.radioButtonGetByFirstChar.Location = new System.Drawing.Point(803, 500);
            this.radioButtonGetByFirstChar.Name = "radioButtonGetByFirstChar";
            this.radioButtonGetByFirstChar.Size = new System.Drawing.Size(198, 24);
            this.radioButtonGetByFirstChar.TabIndex = 31;
            this.radioButtonGetByFirstChar.TabStop = true;
            this.radioButtonGetByFirstChar.Text = "İlk Harfe Göre Veri Getir";
            this.radioButtonGetByFirstChar.UseVisualStyleBackColor = true;
            this.radioButtonGetByFirstChar.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxGetByFirstChar
            // 
            this.textBoxGetByFirstChar.Location = new System.Drawing.Point(1071, 498);
            this.textBoxGetByFirstChar.MaxLength = 1;
            this.textBoxGetByFirstChar.Name = "textBoxGetByFirstChar";
            this.textBoxGetByFirstChar.Size = new System.Drawing.Size(51, 26);
            this.textBoxGetByFirstChar.TabIndex = 33;
            this.textBoxGetByFirstChar.TextChanged += new System.EventHandler(this.textBoxGetByFirstChar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1010, 501);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "HARF:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // radioButtonGetByLastChar
            // 
            this.radioButtonGetByLastChar.AutoSize = true;
            this.radioButtonGetByLastChar.Location = new System.Drawing.Point(803, 530);
            this.radioButtonGetByLastChar.Name = "radioButtonGetByLastChar";
            this.radioButtonGetByLastChar.Size = new System.Drawing.Size(211, 24);
            this.radioButtonGetByLastChar.TabIndex = 34;
            this.radioButtonGetByLastChar.TabStop = true;
            this.radioButtonGetByLastChar.Text = "Son Harfe Göre Veri Getir";
            this.radioButtonGetByLastChar.UseVisualStyleBackColor = true;
            this.radioButtonGetByLastChar.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 826);
            this.Controls.Add(this.radioButtonGetByLastChar);
            this.Controls.Add(this.textBoxGetByFirstChar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButtonGetByFirstChar);
            this.Controls.Add(this.textBoxGeByID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioBtnGetByID);
            this.Controls.Add(this.radioBtnIlk3KaydiGöster);
            this.Controls.Add(this.radioBtnIsmeGoreTersSirala);
            this.Controls.Add(this.radioBtnIsmeGoreSirala);
            this.Controls.Add(this.btnProsedur);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOgrenciFotoPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOgrenciSoyAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOgrenciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSınav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSınav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSınav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnOrtalamaHesapla;
        private System.Windows.Forms.Button btnGetByJoin;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnProsedur;
        private System.Windows.Forms.RadioButton radioBtnIsmeGoreSirala;
        private System.Windows.Forms.RadioButton radioBtnIsmeGoreTersSirala;
        private System.Windows.Forms.RadioButton radioBtnIlk3KaydiGöster;
        private System.Windows.Forms.RadioButton radioBtnGetByID;
        private System.Windows.Forms.TextBox textBoxGeByID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonGetByFirstChar;
        private System.Windows.Forms.TextBox textBoxGetByFirstChar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonGetByLastChar;
    }
}

