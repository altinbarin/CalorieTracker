namespace KaloriTakip_WFAUI
{
    partial class BilgilerimiGuncelle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            nmrKilo = new NumericUpDown();
            nmrBoy = new NumericUpDown();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrBoy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(98, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(98, 89);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(98, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 0;
            label3.Text = "Kilo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(98, 182);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 0;
            label4.Text = "Boy:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(170, 39);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(170, 85);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(177, 27);
            txtSoyad.TabIndex = 1;
            // 
            // nmrKilo
            // 
            nmrKilo.Location = new Point(170, 132);
            nmrKilo.Margin = new Padding(3, 4, 3, 4);
            nmrKilo.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nmrKilo.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nmrKilo.Name = "nmrKilo";
            nmrKilo.Size = new Size(177, 27);
            nmrKilo.TabIndex = 2;
            nmrKilo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nmrBoy
            // 
            nmrBoy.Location = new Point(170, 179);
            nmrBoy.Margin = new Padding(3, 4, 3, 4);
            nmrBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nmrBoy.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nmrBoy.Name = "nmrBoy";
            nmrBoy.Size = new Size(177, 27);
            nmrBoy.TabIndex = 2;
            nmrBoy.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkOliveGreen;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(203, 237);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(86, 31);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += Guncelle;
            // 
            // BilgilerimiGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(477, 319);
            Controls.Add(btnGuncelle);
            Controls.Add(nmrBoy);
            Controls.Add(nmrKilo);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkOliveGreen;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BilgilerimiGuncelle";
            Text = "BilgilerimiGuncelle";
            Load += BilgilerimiGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)nmrKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrBoy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private NumericUpDown nmrKilo;
        private NumericUpDown nmrBoy;
        private Button btnGuncelle;
    }
}