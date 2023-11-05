namespace KaloriTakip_WFAUI
{
    partial class KategoriEkleSil
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
            btnKategoriEkle = new Button();
            cmbKategoriSilmeKategoriler = new ComboBox();
            btnKategoriSilme = new Button();
            txtKategoriIsmi = new TextBox();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.DarkOliveGreen;
            btnKategoriEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKategoriEkle.ForeColor = Color.White;
            btnKategoriEkle.Location = new Point(201, 142);
            btnKategoriEkle.Margin = new Padding(3, 4, 3, 4);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(228, 48);
            btnKategoriEkle.TabIndex = 28;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // cmbKategoriSilmeKategoriler
            // 
            cmbKategoriSilmeKategoriler.FormattingEnabled = true;
            cmbKategoriSilmeKategoriler.Location = new Point(201, 288);
            cmbKategoriSilmeKategoriler.Margin = new Padding(3, 4, 3, 4);
            cmbKategoriSilmeKategoriler.Name = "cmbKategoriSilmeKategoriler";
            cmbKategoriSilmeKategoriler.Size = new Size(228, 28);
            cmbKategoriSilmeKategoriler.TabIndex = 27;
            // 
            // btnKategoriSilme
            // 
            btnKategoriSilme.BackColor = Color.DarkOliveGreen;
            btnKategoriSilme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKategoriSilme.ForeColor = Color.White;
            btnKategoriSilme.Location = new Point(201, 351);
            btnKategoriSilme.Margin = new Padding(3, 4, 3, 4);
            btnKategoriSilme.Name = "btnKategoriSilme";
            btnKategoriSilme.Size = new Size(228, 47);
            btnKategoriSilme.TabIndex = 26;
            btnKategoriSilme.Text = "Kategori Silme";
            btnKategoriSilme.UseCompatibleTextRendering = true;
            btnKategoriSilme.UseVisualStyleBackColor = false;
            btnKategoriSilme.Click += btnKategoriSilme_Click;
            // 
            // txtKategoriIsmi
            // 
            txtKategoriIsmi.BackColor = Color.White;
            txtKategoriIsmi.Location = new Point(202, 89);
            txtKategoriIsmi.Margin = new Padding(3, 4, 3, 4);
            txtKategoriIsmi.Name = "txtKategoriIsmi";
            txtKategoriIsmi.Size = new Size(227, 27);
            txtKategoriIsmi.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkOliveGreen;
            label12.Location = new Point(79, 293);
            label12.Name = "label12";
            label12.Size = new Size(106, 23);
            label12.TabIndex = 23;
            label12.Text = "Kategoriler:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkOliveGreen;
            label9.Location = new Point(49, 90);
            label9.Name = "label9";
            label9.Size = new Size(147, 23);
            label9.TabIndex = 24;
            label9.Text = "Kategori Ekleme:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkOliveGreen;
            label11.Location = new Point(211, 218);
            label11.Name = "label11";
            label11.Size = new Size(207, 32);
            label11.TabIndex = 21;
            label11.Text = "KATEGORİ SİLME";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkOliveGreen;
            label10.Location = new Point(202, 24);
            label10.Name = "label10";
            label10.Size = new Size(228, 32);
            label10.TabIndex = 22;
            label10.Text = "KATEGORİ EKLEME";
            // 
            // KategoriEkleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(599, 449);
            Controls.Add(btnKategoriEkle);
            Controls.Add(cmbKategoriSilmeKategoriler);
            Controls.Add(btnKategoriSilme);
            Controls.Add(txtKategoriIsmi);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KategoriEkleSil";
            Text = "KategoriEkleSil";
            Load += KategoriEkleSil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKategoriEkle;
        private ComboBox cmbKategoriSilmeKategoriler;
        private Button btnKategoriSilme;
        private TextBox txtKategoriIsmi;
        private Label label12;
        private Label label9;
        private Label label11;
        private Label label10;
    }
}