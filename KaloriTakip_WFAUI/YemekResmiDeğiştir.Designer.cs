namespace KaloriTakip_WFAUI
{
    partial class YemekResmiDeğiştir
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
            label6 = new Label();
            label1 = new Label();
            cmbYemekler = new ComboBox();
            pictureBox1 = new PictureBox();
            btnEkle = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(147, 54);
            label6.Name = "label6";
            label6.Size = new Size(324, 32);
            label6.TabIndex = 18;
            label6.Text = "YEMEK RESMİ DEĞİŞTİRME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(128, 116);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 17;
            label1.Text = "Yemekler:";
            // 
            // cmbYemekler
            // 
            cmbYemekler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekler.ForeColor = SystemColors.ControlText;
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(223, 111);
            cmbYemekler.Margin = new Padding(3, 4, 3, 4);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(227, 28);
            cmbYemekler.TabIndex = 16;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(201, 153);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkOliveGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(304, 401);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(185, 63);
            btnEkle.TabIndex = 19;
            btnEkle.Text = "Resim Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkOliveGreen;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(103, 401);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(170, 63);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet/Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // YemekResmiDeğiştir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(701, 487);
            Controls.Add(btnKaydet);
            Controls.Add(btnEkle);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(cmbYemekler);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YemekResmiDeğiştir";
            Text = "YemekResmiDeğiştir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private ComboBox cmbYemekler;
        private PictureBox pictureBox1;
        private Button btnEkle;
        private Button btnKaydet;
    }
}