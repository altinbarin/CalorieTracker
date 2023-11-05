namespace KaloriTakip_WFAUI
{
    partial class OgunEkle
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
            lstUrunler = new ListView();
            nmrPorsiyon = new NumericUpDown();
            btnEksi = new Button();
            btnArti = new Button();
            btnEkle = new Button();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            cmbYemek = new ComboBox();
            cmbOgun = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstUrunler
            // 
            lstUrunler.Location = new Point(153, 83);
            lstUrunler.Margin = new Padding(3, 4, 3, 4);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(435, 216);
            lstUrunler.TabIndex = 32;
            lstUrunler.UseCompatibleStateImageBehavior = false;
            // 
            // nmrPorsiyon
            // 
            nmrPorsiyon.DecimalPlaces = 1;
            nmrPorsiyon.ForeColor = Color.Black;
            nmrPorsiyon.Location = new Point(273, 455);
            nmrPorsiyon.Margin = new Padding(3, 4, 3, 4);
            nmrPorsiyon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrPorsiyon.Name = "nmrPorsiyon";
            nmrPorsiyon.Size = new Size(209, 27);
            nmrPorsiyon.TabIndex = 31;
            nmrPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEksi
            // 
            btnEksi.BackColor = Color.PaleGreen;
            btnEksi.FlatAppearance.BorderSize = 0;
            btnEksi.FlatStyle = FlatStyle.Flat;
            btnEksi.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEksi.ForeColor = Color.DarkOliveGreen;
            btnEksi.Location = new Point(575, 431);
            btnEksi.Margin = new Padding(3, 4, 3, 4);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(73, 64);
            btnEksi.TabIndex = 30;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = false;
            btnEksi.Click += btnEksi_Click;
            // 
            // btnArti
            // 
            btnArti.BackColor = Color.PaleGreen;
            btnArti.FlatAppearance.BorderSize = 0;
            btnArti.FlatStyle = FlatStyle.Flat;
            btnArti.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnArti.ForeColor = Color.DarkOliveGreen;
            btnArti.Location = new Point(488, 431);
            btnArti.Margin = new Padding(3, 4, 3, 4);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(69, 64);
            btnArti.TabIndex = 29;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = false;
            btnArti.Click += btnArti_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkOliveGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(273, 499);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(209, 49);
            btnEkle.TabIndex = 28;
            btnEkle.Text = "Kaydet";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(187, 457);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 26;
            label4.Text = "Porsiyon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(206, 420);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 27;
            label3.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ButtonShadow;
            dateTimePicker1.Location = new Point(273, 412);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(194, 377);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 24;
            label2.Text = "Yemek:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(206, 335);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 23;
            label1.Text = "Öğün:";
            // 
            // cmbYemek
            // 
            cmbYemek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemek.ForeColor = Color.Black;
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(273, 373);
            cmbYemek.Margin = new Padding(3, 4, 3, 4);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(209, 28);
            cmbYemek.TabIndex = 22;
            cmbYemek.SelectedIndexChanged += cmbYemek_SelectedIndexChanged;
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.ForeColor = Color.Black;
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(273, 331);
            cmbOgun.Margin = new Padding(3, 4, 3, 4);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(209, 28);
            cmbOgun.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(618, 83);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // OgunEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(789, 636);
            Controls.Add(pictureBox1);
            Controls.Add(lstUrunler);
            Controls.Add(nmrPorsiyon);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgunEkle";
            Text = "OgunEkle";
            Load += OgunEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstUrunler;
        private NumericUpDown nmrPorsiyon;
        private Button btnEksi;
        private Button btnArti;
        private Button btnEkle;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private ComboBox cmbYemek;
        private ComboBox cmbOgun;
        private PictureBox pictureBox1;
    }
}