namespace KaloriTakip_WFAUI
{
    partial class SifremiUnuttum
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
            txtKullaniciAdi = new TextBox();
            btnSifirlamaKodu = new Button();
            label1 = new Label();
            txtOnayKodu = new TextBox();
            btnOnayla = new Button();
            label2 = new Label();
            label3 = new Label();
            txtYeniSifre = new TextBox();
            label4 = new Label();
            txtYeniSifreOnay = new TextBox();
            btnYeniSifreKaydet = new Button();
            lblZorluk = new Label();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(155, 29);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(211, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // btnSifirlamaKodu
            // 
            btnSifirlamaKodu.BackColor = Color.DarkOliveGreen;
            btnSifirlamaKodu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifirlamaKodu.ForeColor = Color.White;
            btnSifirlamaKodu.Location = new Point(155, 68);
            btnSifirlamaKodu.Margin = new Padding(3, 4, 3, 4);
            btnSifirlamaKodu.Name = "btnSifirlamaKodu";
            btnSifirlamaKodu.Size = new Size(211, 65);
            btnSifirlamaKodu.TabIndex = 1;
            btnSifirlamaKodu.Text = "Sıfırlama Kodu Gönder";
            btnSifirlamaKodu.UseVisualStyleBackColor = false;
            btnSifirlamaKodu.Click += btnSifirlamaKodu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtOnayKodu
            // 
            txtOnayKodu.Location = new Point(155, 172);
            txtOnayKodu.Margin = new Padding(3, 4, 3, 4);
            txtOnayKodu.Name = "txtOnayKodu";
            txtOnayKodu.Size = new Size(211, 27);
            txtOnayKodu.TabIndex = 3;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.DarkOliveGreen;
            btnOnayla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(155, 210);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(211, 57);
            btnOnayla.TabIndex = 4;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(14, 175);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 2;
            label2.Text = "Sıfırlama Kodu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGreen;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(14, 348);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(155, 345);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(211, 27);
            txtYeniSifre.TabIndex = 3;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleGreen;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(14, 431);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 2;
            label4.Text = "Yeni Şifre Onay:";
            // 
            // txtYeniSifreOnay
            // 
            txtYeniSifreOnay.Location = new Point(155, 428);
            txtYeniSifreOnay.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifreOnay.Name = "txtYeniSifreOnay";
            txtYeniSifreOnay.Size = new Size(211, 27);
            txtYeniSifreOnay.TabIndex = 3;
            // 
            // btnYeniSifreKaydet
            // 
            btnYeniSifreKaydet.BackColor = Color.DarkOliveGreen;
            btnYeniSifreKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniSifreKaydet.ForeColor = Color.White;
            btnYeniSifreKaydet.Location = new Point(155, 466);
            btnYeniSifreKaydet.Margin = new Padding(3, 4, 3, 4);
            btnYeniSifreKaydet.Name = "btnYeniSifreKaydet";
            btnYeniSifreKaydet.Size = new Size(211, 57);
            btnYeniSifreKaydet.TabIndex = 5;
            btnYeniSifreKaydet.Text = "Yeni Şifreyi Kaydet";
            btnYeniSifreKaydet.UseVisualStyleBackColor = false;
            btnYeniSifreKaydet.Click += btnYeniSifreKaydet_Click;
            // 
            // lblZorluk
            // 
            lblZorluk.Location = new Point(155, 380);
            lblZorluk.Name = "lblZorluk";
            lblZorluk.Size = new Size(211, 31);
            lblZorluk.TabIndex = 6;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(478, 568);
            Controls.Add(lblZorluk);
            Controls.Add(btnYeniSifreKaydet);
            Controls.Add(btnOnayla);
            Controls.Add(txtYeniSifreOnay);
            Controls.Add(label4);
            Controls.Add(txtYeniSifre);
            Controls.Add(label3);
            Controls.Add(txtOnayKodu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSifirlamaKodu);
            Controls.Add(txtKullaniciAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SifremiUnuttum";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SifremiUnuttum";
            Load += SifremiUnuttum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private Button btnSifirlamaKodu;
        private Label label1;
        private TextBox txtOnayKodu;
        private Button btnOnayla;
        private Label label2;
        private Label label3;
        private TextBox txtYeniSifre;
        private Label label4;
        private TextBox txtYeniSifreOnay;
        private Button btnYeniSifreKaydet;
        private Label lblZorluk;
    }
}