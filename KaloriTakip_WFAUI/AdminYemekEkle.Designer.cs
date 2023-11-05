namespace KaloriTakip_WFAUI
{
    partial class AdminYemekEkle
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
            label5 = new Label();
            txtIsim = new TextBox();
            label2 = new Label();
            nmrKalori = new NumericUpDown();
            label3 = new Label();
            cmbKategoriler = new ComboBox();
            label4 = new Label();
            pbYeniYemekResmi = new PictureBox();
            btnYeniYemekResimSec = new Button();
            btnYeniYemekEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniYemekResmi).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(250, 9);
            label5.Name = "label5";
            label5.Size = new Size(253, 32);
            label5.TabIndex = 15;
            label5.Text = "YENI YEMEK EKLEME";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(278, 65);
            txtIsim.Margin = new Padding(3, 4, 3, 4);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(225, 27);
            txtIsim.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(167, 65);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 17;
            label2.Text = "Yemek Ismi:";
            // 
            // nmrKalori
            // 
            nmrKalori.Location = new Point(278, 115);
            nmrKalori.Margin = new Padding(3, 4, 3, 4);
            nmrKalori.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrKalori.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrKalori.Name = "nmrKalori";
            nmrKalori.Size = new Size(225, 27);
            nmrKalori.TabIndex = 18;
            nmrKalori.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(210, 119);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 19;
            label3.Text = "Kalori:";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(278, 167);
            cmbKategoriler.Margin = new Padding(3, 4, 3, 4);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(225, 28);
            cmbKategoriler.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(167, 168);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 21;
            label4.Text = "Kategoriler:";
            // 
            // pbYeniYemekResmi
            // 
            pbYeniYemekResmi.Location = new Point(224, 222);
            pbYeniYemekResmi.Margin = new Padding(3, 4, 3, 4);
            pbYeniYemekResmi.Name = "pbYeniYemekResmi";
            pbYeniYemekResmi.Size = new Size(279, 121);
            pbYeniYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYeniYemekResmi.TabIndex = 22;
            pbYeniYemekResmi.TabStop = false;
            // 
            // btnYeniYemekResimSec
            // 
            btnYeniYemekResimSec.BackColor = Color.DarkOliveGreen;
            btnYeniYemekResimSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniYemekResimSec.ForeColor = Color.White;
            btnYeniYemekResimSec.Location = new Point(336, 351);
            btnYeniYemekResimSec.Margin = new Padding(3, 4, 3, 4);
            btnYeniYemekResimSec.Name = "btnYeniYemekResimSec";
            btnYeniYemekResimSec.Size = new Size(86, 31);
            btnYeniYemekResimSec.TabIndex = 23;
            btnYeniYemekResimSec.Text = "Seç";
            btnYeniYemekResimSec.UseVisualStyleBackColor = false;
            btnYeniYemekResimSec.Click += btnYeniYemekResimSec_Click;
            // 
            // btnYeniYemekEkle
            // 
            btnYeniYemekEkle.BackColor = Color.DarkOliveGreen;
            btnYeniYemekEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniYemekEkle.ForeColor = Color.White;
            btnYeniYemekEkle.Location = new Point(307, 390);
            btnYeniYemekEkle.Margin = new Padding(3, 4, 3, 4);
            btnYeniYemekEkle.Name = "btnYeniYemekEkle";
            btnYeniYemekEkle.Size = new Size(153, 44);
            btnYeniYemekEkle.TabIndex = 24;
            btnYeniYemekEkle.Text = "Yeni Yemek Ekle";
            btnYeniYemekEkle.UseVisualStyleBackColor = false;
            btnYeniYemekEkle.Click += btnYeniYemekEkle_Click;
            // 
            // AdminYemekEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 451);
            Controls.Add(btnYeniYemekEkle);
            Controls.Add(btnYeniYemekResimSec);
            Controls.Add(pbYeniYemekResmi);
            Controls.Add(label4);
            Controls.Add(cmbKategoriler);
            Controls.Add(label3);
            Controls.Add(nmrKalori);
            Controls.Add(label2);
            Controls.Add(txtIsim);
            Controls.Add(label5);
            ForeColor = Color.FromArgb(34, 33, 74);
            Name = "AdminYemekEkle";
            Text = "AdminYemekEkle";
            Load += AdminYemekEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nmrKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYeniYemekResmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtIsim;
        private Label label2;
        private NumericUpDown nmrKalori;
        private Label label3;
        private ComboBox cmbKategoriler;
        private Label label4;
        private PictureBox pbYeniYemekResmi;
        private Button btnYeniYemekResimSec;
        private Button btnYeniYemekEkle;
    }
}