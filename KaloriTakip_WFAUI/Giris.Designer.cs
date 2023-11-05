namespace KaloriTakip_WFAUI
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            txtKullaniciAdi = new TextBox();
            txtParola = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGirisYap = new Button();
            label3 = new Label();
            btnKaydol = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnExit = new Button();
            label7 = new Label();
            btnSifremiUnuttum = new Button();
            pictureBox2 = new PictureBox();
            cmbHatirla = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(127, 118);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(212, 23);
            txtKullaniciAdi.TabIndex = 0;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(127, 158);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(212, 23);
            txtParola.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(65, 118);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 2;
            label1.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(65, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 3;
            label2.Text = "Parola:";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.DarkOliveGreen;
            btnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(126, 197);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(212, 32);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(126, 403);
            label3.Name = "label3";
            label3.Size = new Size(178, 19);
            label3.TabIndex = 5;
            label3.Text = "Hala bir hesabın yok mu?";
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.DarkOliveGreen;
            btnKaydol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = Color.White;
            btnKaydol.Location = new Point(126, 423);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(212, 32);
            btnKaydol.TabIndex = 6;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(127, 61);
            label4.Name = "label4";
            label4.Size = new Size(220, 29);
            label4.TabIndex = 7;
            label4.Text = "GİRİŞ EKRANI";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(370, 62);
            label5.Name = "label5";
            label5.Size = new Size(419, 40);
            label5.TabIndex = 8;
            label5.Text = "Hoş Geldiniz! FÖHM Dünyasına Adım Atın";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(388, 103);
            label6.Name = "label6";
            label6.Size = new Size(355, 159);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PaleGreen;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.DarkOliveGreen;
            btnExit.Location = new Point(957, 9);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 11;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOliveGreen;
            label7.Location = new Point(127, 298);
            label7.Name = "label7";
            label7.Size = new Size(192, 19);
            label7.TabIndex = 12;
            label7.Text = "Şifreni hatırlamıyor musun?";
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.BackColor = Color.DarkOliveGreen;
            btnSifremiUnuttum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifremiUnuttum.ForeColor = Color.White;
            btnSifremiUnuttum.Location = new Point(127, 319);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(211, 38);
            btnSifremiUnuttum.TabIndex = 13;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = false;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(625, 286);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // cmbHatirla
            // 
            cmbHatirla.AutoSize = true;
            cmbHatirla.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbHatirla.ForeColor = Color.DarkOliveGreen;
            cmbHatirla.Location = new Point(127, 244);
            cmbHatirla.Margin = new Padding(3, 2, 3, 2);
            cmbHatirla.Name = "cmbHatirla";
            cmbHatirla.Size = new Size(126, 23);
            cmbHatirla.TabIndex = 15;
            cmbHatirla.Text = "Şifremi Hatırla";
            cmbHatirla.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1011, 500);
            Controls.Add(cmbHatirla);
            Controls.Add(pictureBox2);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnKaydol);
            Controls.Add(label3);
            Controls.Add(btnGirisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtParola);
            Controls.Add(txtKullaniciAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris";
            Text = "KullaniciEkrani";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtParola;
        private Label label1;
        private Label label2;
        private Button btnGirisYap;
        private Label label3;
        private Button btnKaydol;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnExit;
        private Label label7;
        private Button btnSifremiUnuttum;
        private PictureBox pictureBox2;
        private CheckBox cmbHatirla;
    }
}