namespace KaloriTakip_WFAUI
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            lstBilgiler = new ListView();
            cmbOgun = new ComboBox();
            cmbYemek = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            btnEkle = new Button();
            btnArti = new Button();
            btnEksi = new Button();
            btnGuncelle = new Button();
            nmrPorsiyon = new NumericUpDown();
            label4 = new Label();
            btnGunlukRapor = new Button();
            pictureBox1 = new PictureBox();
            lstUrunler = new ListView();
            panel1 = new Panel();
            btnCikis = new FontAwesome.Sharp.IconButton();
            btnBilgilerimiGuncelle = new FontAwesome.Sharp.IconButton();
            btnKullaniciRaporlari = new FontAwesome.Sharp.IconButton();
            btnOgunGuncelle = new FontAwesome.Sharp.IconButton();
            btnOgunEkle1 = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            btnanasayfa = new Button();
            panelDesktop = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panellogo.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // lstBilgiler
            // 
            lstBilgiler.BackColor = Color.DarkOliveGreen;
            lstBilgiler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lstBilgiler.ForeColor = Color.White;
            lstBilgiler.Location = new Point(3, 4);
            lstBilgiler.Margin = new Padding(3, 4, 3, 4);
            lstBilgiler.Name = "lstBilgiler";
            lstBilgiler.Size = new Size(961, 96);
            lstBilgiler.TabIndex = 0;
            lstBilgiler.UseCompatibleStateImageBehavior = false;
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(440, 421);
            cmbOgun.Margin = new Padding(3, 4, 3, 4);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(205, 28);
            cmbOgun.TabIndex = 6;
            // 
            // cmbYemek
            // 
            cmbYemek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(401, 484);
            cmbYemek.Margin = new Padding(3, 4, 3, 4);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(205, 28);
            cmbYemek.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 421);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 8;
            label1.Text = "Öğün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 473);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Yemek";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(419, 523);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 531);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Tarih";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveBorder;
            btnEkle.Location = new Point(419, 624);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(187, 56);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnArti
            // 
            btnArti.BackColor = SystemColors.ActiveBorder;
            btnArti.Location = new Point(645, 472);
            btnArti.Margin = new Padding(3, 4, 3, 4);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(58, 36);
            btnArti.TabIndex = 13;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = false;
            // 
            // btnEksi
            // 
            btnEksi.BackColor = SystemColors.ActiveBorder;
            btnEksi.Location = new Point(687, 428);
            btnEksi.Margin = new Padding(3, 4, 3, 4);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(58, 36);
            btnEksi.TabIndex = 14;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(888, 385);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(145, 48);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // nmrPorsiyon
            // 
            nmrPorsiyon.DecimalPlaces = 1;
            nmrPorsiyon.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmrPorsiyon.Location = new Point(419, 561);
            nmrPorsiyon.Margin = new Padding(3, 4, 3, 4);
            nmrPorsiyon.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            nmrPorsiyon.Name = "nmrPorsiyon";
            nmrPorsiyon.Size = new Size(187, 27);
            nmrPorsiyon.TabIndex = 17;
            nmrPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 572);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Porsiyon";
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.Location = new Point(907, 465);
            btnGunlukRapor.Margin = new Padding(3, 4, 3, 4);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(86, 31);
            btnGunlukRapor.TabIndex = 18;
            btnGunlukRapor.Text = "Gunluk";
            btnGunlukRapor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(760, 144);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 217);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lstUrunler
            // 
            lstUrunler.Location = new Point(267, 163);
            lstUrunler.Margin = new Padding(3, 4, 3, 4);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(435, 216);
            lstUrunler.TabIndex = 20;
            lstUrunler.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnCikis);
            panel1.Controls.Add(btnBilgilerimiGuncelle);
            panel1.Controls.Add(btnKullaniciRaporlari);
            panel1.Controls.Add(btnOgunGuncelle);
            panel1.Controls.Add(btnOgunEkle1);
            panel1.Controls.Add(panellogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 755);
            panel1.TabIndex = 22;
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
            btnCikis.Location = new Point(0, 464);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(219, 84);
            btnCikis.TabIndex = 8;
            btnCikis.Text = "Çıkış";
            btnCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnBilgilerimiGuncelle
            // 
            btnBilgilerimiGuncelle.BackColor = Color.DarkOliveGreen;
            btnBilgilerimiGuncelle.Dock = DockStyle.Top;
            btnBilgilerimiGuncelle.FlatAppearance.BorderSize = 0;
            btnBilgilerimiGuncelle.FlatStyle = FlatStyle.Flat;
            btnBilgilerimiGuncelle.ForeColor = Color.White;
            btnBilgilerimiGuncelle.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnBilgilerimiGuncelle.IconColor = Color.White;
            btnBilgilerimiGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBilgilerimiGuncelle.IconSize = 38;
            btnBilgilerimiGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilgilerimiGuncelle.Location = new Point(0, 380);
            btnBilgilerimiGuncelle.Name = "btnBilgilerimiGuncelle";
            btnBilgilerimiGuncelle.Size = new Size(219, 84);
            btnBilgilerimiGuncelle.TabIndex = 7;
            btnBilgilerimiGuncelle.Text = "Bilgilerimi Güncelle";
            btnBilgilerimiGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBilgilerimiGuncelle.UseVisualStyleBackColor = false;
            btnBilgilerimiGuncelle.Click += btnBilgilerimiGuncelle_Click;
            // 
            // btnKullaniciRaporlari
            // 
            btnKullaniciRaporlari.BackColor = Color.DarkOliveGreen;
            btnKullaniciRaporlari.Dock = DockStyle.Top;
            btnKullaniciRaporlari.FlatAppearance.BorderSize = 0;
            btnKullaniciRaporlari.FlatStyle = FlatStyle.Flat;
            btnKullaniciRaporlari.ForeColor = Color.White;
            btnKullaniciRaporlari.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            btnKullaniciRaporlari.IconColor = Color.White;
            btnKullaniciRaporlari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKullaniciRaporlari.IconSize = 38;
            btnKullaniciRaporlari.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullaniciRaporlari.Location = new Point(0, 300);
            btnKullaniciRaporlari.Name = "btnKullaniciRaporlari";
            btnKullaniciRaporlari.Size = new Size(219, 80);
            btnKullaniciRaporlari.TabIndex = 5;
            btnKullaniciRaporlari.Text = "Raporlar";
            btnKullaniciRaporlari.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKullaniciRaporlari.UseVisualStyleBackColor = false;
            btnKullaniciRaporlari.Click += btnKullaniciRaporlari_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.DarkOliveGreen;
            btnOgunGuncelle.Dock = DockStyle.Top;
            btnOgunGuncelle.FlatAppearance.BorderSize = 0;
            btnOgunGuncelle.FlatStyle = FlatStyle.Flat;
            btnOgunGuncelle.ForeColor = Color.White;
            btnOgunGuncelle.IconChar = FontAwesome.Sharp.IconChar.Images;
            btnOgunGuncelle.IconColor = Color.White;
            btnOgunGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOgunGuncelle.IconSize = 38;
            btnOgunGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnOgunGuncelle.Location = new Point(0, 220);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(219, 80);
            btnOgunGuncelle.TabIndex = 2;
            btnOgunGuncelle.Text = "Öğünlerini Güncelle";
            btnOgunGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // btnOgunEkle1
            // 
            btnOgunEkle1.BackColor = Color.DarkOliveGreen;
            btnOgunEkle1.Dock = DockStyle.Top;
            btnOgunEkle1.FlatAppearance.BorderSize = 0;
            btnOgunEkle1.FlatStyle = FlatStyle.Flat;
            btnOgunEkle1.ForeColor = Color.White;
            btnOgunEkle1.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            btnOgunEkle1.IconColor = Color.White;
            btnOgunEkle1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOgunEkle1.IconSize = 38;
            btnOgunEkle1.ImageAlign = ContentAlignment.MiddleLeft;
            btnOgunEkle1.Location = new Point(0, 140);
            btnOgunEkle1.Name = "btnOgunEkle1";
            btnOgunEkle1.Size = new Size(219, 80);
            btnOgunEkle1.TabIndex = 1;
            btnOgunEkle1.Text = "Öğün Ekle";
            btnOgunEkle1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunEkle1.UseVisualStyleBackColor = false;
            btnOgunEkle1.Click += btnOgunEkle1_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(btnanasayfa);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(219, 140);
            panellogo.TabIndex = 0;
            // 
            // btnanasayfa
            // 
            btnanasayfa.BackgroundImage = (Image)resources.GetObject("btnanasayfa.BackgroundImage");
            btnanasayfa.BackgroundImageLayout = ImageLayout.Stretch;
            btnanasayfa.Location = new Point(0, 0);
            btnanasayfa.Name = "btnanasayfa";
            btnanasayfa.Size = new Size(219, 140);
            btnanasayfa.TabIndex = 1;
            btnanasayfa.UseVisualStyleBackColor = true;
            btnanasayfa.Click += btnanasayfa_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.PaleGreen;
            panelDesktop.Controls.Add(label5);
            panelDesktop.Controls.Add(lstBilgiler);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 0);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(967, 755);
            panelDesktop.TabIndex = 23;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(98, 140);
            label5.Name = "label5";
            label5.Size = new Size(793, 351);
            label5.TabIndex = 1;
            label5.Text = resources.GetString("label5.Text");
            // 
            // KullaniciGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 755);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(lstUrunler);
            Controls.Add(pictureBox1);
            Controls.Add(btnGunlukRapor);
            Controls.Add(nmrPorsiyon);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEksi);
            Controls.Add(btnArti);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbYemek);
            Controls.Add(cmbOgun);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciGirisi";
            Text = "KullaniciGirisi";
            Load += KullaniciGirisi_Load;
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstBilgiler;
        private ComboBox cmbOgun;
        private ComboBox cmbYemek;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button btnEkle;
        private Button btnArti;
        private Button btnEksi;
        private Button btnGuncelle;
        private NumericUpDown nmrPorsiyon;
        private Label label4;
        private Button btnGunlukRapor;
        private PictureBox pictureBox1;
        private ListView lstUrunler;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnKullaniciRaporlari;
        private FontAwesome.Sharp.IconButton btnOgunGuncelle;
        private FontAwesome.Sharp.IconButton btnOgunEkle1;
        private Panel panellogo;
        private Panel panelDesktop;
        private Button btnanasayfa;
        private FontAwesome.Sharp.IconButton btnCikis;
        private FontAwesome.Sharp.IconButton btnBilgilerimiGuncelle;
        private Label label5;
    }
}