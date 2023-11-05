namespace KaloriTakip_WFAUI
{
    partial class AdminSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfasi));
            pictureBox1 = new PictureBox();
            btnEkle = new Button();
            btnKaydet = new Button();
            cmbYemekler = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtIsim = new TextBox();
            nmrKalori = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            cmbKategoriler = new ComboBox();
            btnYeniYemekEkle = new Button();
            pbYeniYemekResmi = new PictureBox();
            btnYeniYemekResimSec = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbYemeklerYemekSilme = new ComboBox();
            label8 = new Label();
            btnSil = new Button();
            label9 = new Label();
            label10 = new Label();
            txtKategoriIsmi = new TextBox();
            btnKategoriSilme = new Button();
            label11 = new Label();
            cmbKategoriSilmeKategoriler = new ComboBox();
            label12 = new Label();
            btnKategoriEkle = new Button();
            panel1 = new Panel();
            btnCikis = new FontAwesome.Sharp.IconButton();
            Raporlar = new FontAwesome.Sharp.IconButton();
            KategoriEkleSil = new FontAwesome.Sharp.IconButton();
            YemekSil = new FontAwesome.Sharp.IconButton();
            YemekResim = new FontAwesome.Sharp.IconButton();
            YemekEkleme = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            button1 = new Button();
            panelDesktop = new Panel();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniYemekResmi).BeginInit();
            panel1.SuspendLayout();
            panellogo.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(582, 112);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveBorder;
            btnEkle.Location = new Point(681, 361);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 53);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Resim Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveBorder;
            btnKaydet.Location = new Point(681, 499);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(170, 63);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet/Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // cmbYemekler
            // 
            cmbYemekler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(483, 55);
            cmbYemekler.Margin = new Padding(3, 4, 3, 4);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(227, 28);
            cmbYemekler.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 59);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Yemekler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 227);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Yemek Ismi:";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(366, 220);
            txtIsim.Margin = new Padding(3, 4, 3, 4);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(191, 27);
            txtIsim.TabIndex = 6;
            // 
            // nmrKalori
            // 
            nmrKalori.Location = new Point(366, 276);
            nmrKalori.Margin = new Padding(3, 4, 3, 4);
            nmrKalori.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrKalori.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrKalori.Name = "nmrKalori";
            nmrKalori.Size = new Size(192, 27);
            nmrKalori.TabIndex = 7;
            nmrKalori.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 283);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "Kalori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 347);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Kategoriler";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(395, 339);
            cmbKategoriler.Margin = new Padding(3, 4, 3, 4);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(191, 28);
            cmbKategoriler.TabIndex = 10;
            // 
            // btnYeniYemekEkle
            // 
            btnYeniYemekEkle.BackColor = SystemColors.ActiveBorder;
            btnYeniYemekEkle.Location = new Point(483, 588);
            btnYeniYemekEkle.Margin = new Padding(3, 4, 3, 4);
            btnYeniYemekEkle.Name = "btnYeniYemekEkle";
            btnYeniYemekEkle.Size = new Size(153, 44);
            btnYeniYemekEkle.TabIndex = 11;
            btnYeniYemekEkle.Text = "YeniYemekEkle";
            btnYeniYemekEkle.UseVisualStyleBackColor = false;
            // 
            // pbYeniYemekResmi
            // 
            pbYeniYemekResmi.Location = new Point(347, 384);
            pbYeniYemekResmi.Margin = new Padding(3, 4, 3, 4);
            pbYeniYemekResmi.Name = "pbYeniYemekResmi";
            pbYeniYemekResmi.Size = new Size(279, 121);
            pbYeniYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYeniYemekResmi.TabIndex = 12;
            pbYeniYemekResmi.TabStop = false;
            // 
            // btnYeniYemekResimSec
            // 
            btnYeniYemekResimSec.BackColor = SystemColors.ActiveBorder;
            btnYeniYemekResimSec.Location = new Point(501, 531);
            btnYeniYemekResimSec.Margin = new Padding(3, 4, 3, 4);
            btnYeniYemekResimSec.Name = "btnYeniYemekResimSec";
            btnYeniYemekResimSec.Size = new Size(86, 31);
            btnYeniYemekResimSec.TabIndex = 13;
            btnYeniYemekResimSec.Text = "Seç";
            btnYeniYemekResimSec.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(323, 172);
            label5.Name = "label5";
            label5.Size = new Size(253, 32);
            label5.TabIndex = 14;
            label5.Text = "YENI YEMEK EKLEME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(466, 12);
            label6.Name = "label6";
            label6.Size = new Size(324, 32);
            label6.TabIndex = 14;
            label6.Text = "YEMEK RESMİ DEĞİŞTİRME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(921, 45);
            label7.Name = "label7";
            label7.Size = new Size(170, 32);
            label7.TabIndex = 14;
            label7.Text = "YEMEK SİLME";
            // 
            // cmbYemeklerYemekSilme
            // 
            cmbYemeklerYemekSilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemeklerYemekSilme.FormattingEnabled = true;
            cmbYemeklerYemekSilme.Location = new Point(915, 85);
            cmbYemeklerYemekSilme.Margin = new Padding(3, 4, 3, 4);
            cmbYemeklerYemekSilme.Name = "cmbYemeklerYemekSilme";
            cmbYemeklerYemekSilme.Size = new Size(227, 28);
            cmbYemeklerYemekSilme.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(846, 89);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 4;
            label8.Text = "Yemekler";
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveBorder;
            btnSil.Location = new Point(915, 139);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(227, 52);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(806, 361);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 16;
            label9.Text = "Kategori Ekleme:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(910, 299);
            label10.Name = "label10";
            label10.Size = new Size(228, 32);
            label10.TabIndex = 14;
            label10.Text = "KATEGORİ EKLEME";
            // 
            // txtKategoriIsmi
            // 
            txtKategoriIsmi.Location = new Point(921, 357);
            txtKategoriIsmi.Margin = new Padding(3, 4, 3, 4);
            txtKategoriIsmi.Name = "txtKategoriIsmi";
            txtKategoriIsmi.Size = new Size(227, 27);
            txtKategoriIsmi.TabIndex = 17;
            // 
            // btnKategoriSilme
            // 
            btnKategoriSilme.BackColor = SystemColors.ActiveBorder;
            btnKategoriSilme.Location = new Point(957, 639);
            btnKategoriSilme.Margin = new Padding(3, 4, 3, 4);
            btnKategoriSilme.Name = "btnKategoriSilme";
            btnKategoriSilme.Size = new Size(139, 47);
            btnKategoriSilme.TabIndex = 18;
            btnKategoriSilme.Text = "Kategori Silme";
            btnKategoriSilme.UseCompatibleTextRendering = true;
            btnKategoriSilme.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(910, 531);
            label11.Name = "label11";
            label11.Size = new Size(207, 32);
            label11.TabIndex = 14;
            label11.Text = "KATEGORİ SİLME";
            // 
            // cmbKategoriSilmeKategoriler
            // 
            cmbKategoriSilmeKategoriler.FormattingEnabled = true;
            cmbKategoriSilmeKategoriler.Location = new Point(921, 588);
            cmbKategoriSilmeKategoriler.Margin = new Padding(3, 4, 3, 4);
            cmbKategoriSilmeKategoriler.Name = "cmbKategoriSilmeKategoriler";
            cmbKategoriSilmeKategoriler.Size = new Size(227, 28);
            cmbKategoriSilmeKategoriler.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(806, 592);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 16;
            label12.Text = "Kategoriler:";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(927, 415);
            btnKategoriEkle.Margin = new Padding(3, 4, 3, 4);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(213, 48);
            btnKategoriEkle.TabIndex = 20;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnCikis);
            panel1.Controls.Add(Raporlar);
            panel1.Controls.Add(KategoriEkleSil);
            panel1.Controls.Add(YemekSil);
            panel1.Controls.Add(YemekResim);
            panel1.Controls.Add(YemekEkleme);
            panel1.Controls.Add(panellogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 743);
            panel1.TabIndex = 21;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.DarkOliveGreen;
            btnCikis.Dock = DockStyle.Top;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCikis.IconColor = Color.White;
            btnCikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCikis.IconSize = 38;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(0, 540);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(219, 80);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // Raporlar
            // 
            Raporlar.BackColor = Color.DarkOliveGreen;
            Raporlar.Dock = DockStyle.Top;
            Raporlar.FlatAppearance.BorderSize = 0;
            Raporlar.FlatStyle = FlatStyle.Flat;
            Raporlar.ForeColor = Color.White;
            Raporlar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            Raporlar.IconColor = Color.White;
            Raporlar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Raporlar.IconSize = 38;
            Raporlar.ImageAlign = ContentAlignment.MiddleLeft;
            Raporlar.Location = new Point(0, 460);
            Raporlar.Name = "Raporlar";
            Raporlar.Size = new Size(219, 80);
            Raporlar.TabIndex = 5;
            Raporlar.Text = "Raporlar";
            Raporlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Raporlar.UseVisualStyleBackColor = false;
            Raporlar.Click += Raporlar_Click;
            // 
            // KategoriEkleSil
            // 
            KategoriEkleSil.BackColor = Color.DarkOliveGreen;
            KategoriEkleSil.Dock = DockStyle.Top;
            KategoriEkleSil.FlatAppearance.BorderSize = 0;
            KategoriEkleSil.FlatStyle = FlatStyle.Flat;
            KategoriEkleSil.ForeColor = Color.White;
            KategoriEkleSil.IconChar = FontAwesome.Sharp.IconChar.List;
            KategoriEkleSil.IconColor = Color.White;
            KategoriEkleSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            KategoriEkleSil.IconSize = 38;
            KategoriEkleSil.ImageAlign = ContentAlignment.MiddleLeft;
            KategoriEkleSil.Location = new Point(0, 380);
            KategoriEkleSil.Name = "KategoriEkleSil";
            KategoriEkleSil.Size = new Size(219, 80);
            KategoriEkleSil.TabIndex = 4;
            KategoriEkleSil.Text = "Kategori Ekle Sil";
            KategoriEkleSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            KategoriEkleSil.UseVisualStyleBackColor = false;
            KategoriEkleSil.Click += KategoriEkleSil_Click;
            // 
            // YemekSil
            // 
            YemekSil.BackColor = Color.DarkOliveGreen;
            YemekSil.Dock = DockStyle.Top;
            YemekSil.FlatAppearance.BorderSize = 0;
            YemekSil.FlatStyle = FlatStyle.Flat;
            YemekSil.ForeColor = Color.White;
            YemekSil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            YemekSil.IconColor = Color.White;
            YemekSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            YemekSil.IconSize = 38;
            YemekSil.ImageAlign = ContentAlignment.MiddleLeft;
            YemekSil.Location = new Point(0, 300);
            YemekSil.Name = "YemekSil";
            YemekSil.Size = new Size(219, 80);
            YemekSil.TabIndex = 3;
            YemekSil.Text = "Yemek Silme";
            YemekSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            YemekSil.UseVisualStyleBackColor = false;
            YemekSil.Click += YemekSil_Click;
            // 
            // YemekResim
            // 
            YemekResim.BackColor = Color.DarkOliveGreen;
            YemekResim.Dock = DockStyle.Top;
            YemekResim.FlatAppearance.BorderSize = 0;
            YemekResim.FlatStyle = FlatStyle.Flat;
            YemekResim.ForeColor = Color.White;
            YemekResim.IconChar = FontAwesome.Sharp.IconChar.Images;
            YemekResim.IconColor = Color.White;
            YemekResim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            YemekResim.IconSize = 38;
            YemekResim.ImageAlign = ContentAlignment.MiddleLeft;
            YemekResim.Location = new Point(0, 220);
            YemekResim.Name = "YemekResim";
            YemekResim.Size = new Size(219, 80);
            YemekResim.TabIndex = 2;
            YemekResim.Text = "Yemek Resmi Değiştirme";
            YemekResim.TextImageRelation = TextImageRelation.ImageBeforeText;
            YemekResim.UseVisualStyleBackColor = false;
            YemekResim.Click += YemekResim_Click;
            // 
            // YemekEkleme
            // 
            YemekEkleme.BackColor = Color.DarkOliveGreen;
            YemekEkleme.Dock = DockStyle.Top;
            YemekEkleme.FlatAppearance.BorderSize = 0;
            YemekEkleme.FlatStyle = FlatStyle.Flat;
            YemekEkleme.ForeColor = Color.White;
            YemekEkleme.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            YemekEkleme.IconColor = Color.White;
            YemekEkleme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            YemekEkleme.IconSize = 38;
            YemekEkleme.ImageAlign = ContentAlignment.MiddleLeft;
            YemekEkleme.Location = new Point(0, 140);
            YemekEkleme.Name = "YemekEkleme";
            YemekEkleme.Size = new Size(219, 80);
            YemekEkleme.TabIndex = 1;
            YemekEkleme.Text = "Yemek Ekle";
            YemekEkleme.TextImageRelation = TextImageRelation.ImageBeforeText;
            YemekEkleme.UseVisualStyleBackColor = false;
            YemekEkleme.Click += YemekEkleme_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(button1);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(219, 140);
            panellogo.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(219, 140);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.PaleGreen;
            panelDesktop.Controls.Add(label13);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 0);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(943, 743);
            panelDesktop.TabIndex = 22;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkOliveGreen;
            label13.Location = new Point(116, 45);
            label13.Name = "label13";
            label13.Size = new Size(744, 322);
            label13.TabIndex = 0;
            label13.Text = resources.GetString("label13.Text");
            // 
            // AdminSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 743);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(btnKategoriEkle);
            Controls.Add(cmbKategoriSilmeKategoriler);
            Controls.Add(btnKategoriSilme);
            Controls.Add(txtKategoriIsmi);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(btnSil);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnYeniYemekResimSec);
            Controls.Add(pbYeniYemekResmi);
            Controls.Add(btnYeniYemekEkle);
            Controls.Add(cmbKategoriler);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nmrKalori);
            Controls.Add(txtIsim);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(cmbYemeklerYemekSilme);
            Controls.Add(cmbYemekler);
            Controls.Add(btnKaydet);
            Controls.Add(btnEkle);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminSayfasi";
            Text = "AdminSayfasi";
            Load += AdminSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniYemekResmi).EndInit();
            panel1.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEkle;
        private Button btnKaydet;
        private ComboBox cmbYemekler;
        private Label label1;
        private Label label2;
        private TextBox txtIsim;
        private NumericUpDown nmrKalori;
        private Label label3;
        private Label label4;
        private ComboBox cmbKategoriler;
        private Button btnYeniYemekEkle;
        private PictureBox pbYeniYemekResmi;
        private Button btnYeniYemekResimSec;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbYemeklerYemekSilme;
        private Label label8;
        private Button btnSil;
        private Label label9;
        private Label label10;
        private TextBox txtKategoriIsmi;
        private Button btnKategoriSilme;
        private Label label11;
        private ComboBox cmbKategoriSilmeKategoriler;
        private Label label12;
        private Button btnKategoriEkle;
        private Panel panel1;
        private Panel panellogo;
        private FontAwesome.Sharp.IconButton YemekEkleme;
        private FontAwesome.Sharp.IconButton KategoriEkleSil;
        private FontAwesome.Sharp.IconButton YemekSil;
        private FontAwesome.Sharp.IconButton YemekResim;
        private FontAwesome.Sharp.IconButton Raporlar;
        private Panel panelDesktop;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnCikis;
        private Label label13;
    }
}