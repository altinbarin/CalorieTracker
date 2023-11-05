namespace KaloriTakip_WFAUI
{
    partial class GuncelleForm
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
            cbYemekIsmi = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnTarihGetir = new Button();
            btnKaldir = new Button();
            btnEkle = new Button();
            lstOgunler = new ListBox();
            nmrPorsiyon = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lstOgunDetaylari = new ListView();
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).BeginInit();
            SuspendLayout();
            // 
            // cbYemekIsmi
            // 
            cbYemekIsmi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYemekIsmi.FormattingEnabled = true;
            cbYemekIsmi.Location = new Point(28, 285);
            cbYemekIsmi.Name = "cbYemekIsmi";
            cbYemekIsmi.Size = new Size(153, 23);
            cbYemekIsmi.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnTarihGetir
            // 
            btnTarihGetir.BackColor = Color.DarkOliveGreen;
            btnTarihGetir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTarihGetir.ForeColor = Color.White;
            btnTarihGetir.Location = new Point(102, 105);
            btnTarihGetir.Name = "btnTarihGetir";
            btnTarihGetir.Size = new Size(227, 23);
            btnTarihGetir.TabIndex = 5;
            btnTarihGetir.Text = "Tarih Getir";
            btnTarihGetir.UseVisualStyleBackColor = false;
            btnTarihGetir.Click += btnTarihGetir_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.BackColor = Color.DarkOliveGreen;
            btnKaldir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaldir.ForeColor = Color.White;
            btnKaldir.Location = new Point(196, 336);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(72, 34);
            btnKaldir.TabIndex = 3;
            btnKaldir.Text = "Kaldır";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkOliveGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(28, 336);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(153, 34);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstOgunler
            // 
            lstOgunler.FormattingEnabled = true;
            lstOgunler.ItemHeight = 15;
            lstOgunler.Location = new Point(441, 30);
            lstOgunler.Name = "lstOgunler";
            lstOgunler.Size = new Size(347, 124);
            lstOgunler.TabIndex = 6;
            lstOgunler.SelectedIndexChanged += lstOgunler_SelectedIndexChanged;
            // 
            // nmrPorsiyon
            // 
            nmrPorsiyon.DecimalPlaces = 1;
            nmrPorsiyon.Location = new Point(196, 285);
            nmrPorsiyon.Name = "nmrPorsiyon";
            nmrPorsiyon.Size = new Size(72, 23);
            nmrPorsiyon.TabIndex = 7;
            nmrPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(28, 258);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 8;
            label1.Text = "Yemek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(195, 258);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 9;
            label2.Text = "Porsiyon";
            // 
            // lstOgunDetaylari
            // 
            lstOgunDetaylari.Location = new Point(292, 211);
            lstOgunDetaylari.Name = "lstOgunDetaylari";
            lstOgunDetaylari.Size = new Size(496, 227);
            lstOgunDetaylari.TabIndex = 10;
            lstOgunDetaylari.UseCompatibleStateImageBehavior = false;
            // 
            // GuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lstOgunDetaylari);
            Controls.Add(btnTarihGetir);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrPorsiyon);
            Controls.Add(lstOgunler);
            Controls.Add(btnEkle);
            Controls.Add(btnKaldir);
            Controls.Add(cbYemekIsmi);
            Name = "GuncelleForm";
            Text = "GuncelleForm";
            Load += GuncelleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrPorsiyon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOgunId;
        private ComboBox cbYemekIsmi;
        private DateTimePicker dateTimePicker1;
        private Button btnKaldir;
        private Button btnEkle;
        private Button btnTarihGetir;
        private ListBox lstOgunler;
        private NumericUpDown nmrPorsiyon;
        private Label label1;
        private Label label2;
        private ListView lstOgunDetaylari;
    }
}