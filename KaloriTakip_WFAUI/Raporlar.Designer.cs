namespace KaloriTakip_WFAUI
{
    partial class Raporlar
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
            lstRaporlar = new ListView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnGunlukRapor = new Button();
            btnAylikRapor = new Button();
            btnHaftalikRapor = new Button();
            lstYemekler = new ListView();
            SuspendLayout();
            // 
            // lstRaporlar
            // 
            lstRaporlar.Location = new Point(479, 16);
            lstRaporlar.Margin = new Padding(3, 4, 3, 4);
            lstRaporlar.MultiSelect = false;
            lstRaporlar.Name = "lstRaporlar";
            lstRaporlar.Size = new Size(432, 206);
            lstRaporlar.TabIndex = 1;
            lstRaporlar.UseCompatibleStateImageBehavior = false;
            lstRaporlar.SelectedIndexChanged += lstRaporlar_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 65);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(32, 69);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 3;
            label1.Text = "Tarih Seçiniz:";
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.BackColor = Color.DarkOliveGreen;
            btnGunlukRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunlukRapor.ForeColor = Color.White;
            btnGunlukRapor.Location = new Point(153, 148);
            btnGunlukRapor.Margin = new Padding(3, 4, 3, 4);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(228, 57);
            btnGunlukRapor.TabIndex = 4;
            btnGunlukRapor.Text = "Günlük Rapor Göster";
            btnGunlukRapor.UseVisualStyleBackColor = false;
            btnGunlukRapor.Click += btnGunlukRapor_Click;
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackColor = Color.DarkOliveGreen;
            btnAylikRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAylikRapor.ForeColor = Color.White;
            btnAylikRapor.Location = new Point(153, 350);
            btnAylikRapor.Margin = new Padding(3, 4, 3, 4);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(228, 59);
            btnAylikRapor.TabIndex = 5;
            btnAylikRapor.Text = "Aylık Rapor Göster";
            btnAylikRapor.UseVisualStyleBackColor = false;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // btnHaftalikRapor
            // 
            btnHaftalikRapor.BackColor = Color.DarkOliveGreen;
            btnHaftalikRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaftalikRapor.ForeColor = Color.White;
            btnHaftalikRapor.Location = new Point(153, 251);
            btnHaftalikRapor.Margin = new Padding(3, 4, 3, 4);
            btnHaftalikRapor.Name = "btnHaftalikRapor";
            btnHaftalikRapor.Size = new Size(228, 56);
            btnHaftalikRapor.TabIndex = 6;
            btnHaftalikRapor.Text = "Haftalık Rapor Göster";
            btnHaftalikRapor.UseVisualStyleBackColor = false;
            btnHaftalikRapor.Click += btnHaftalikRapor_Click_1;
            // 
            // lstYemekler
            // 
            lstYemekler.Location = new Point(479, 286);
            lstYemekler.Margin = new Padding(3, 4, 3, 4);
            lstYemekler.Name = "lstYemekler";
            lstYemekler.Size = new Size(432, 199);
            lstYemekler.TabIndex = 7;
            lstYemekler.UseCompatibleStateImageBehavior = false;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(959, 524);
            Controls.Add(lstYemekler);
            Controls.Add(btnHaftalikRapor);
            Controls.Add(btnAylikRapor);
            Controls.Add(btnGunlukRapor);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lstRaporlar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Raporlar";
            Text = "Raporlar";
            Load += Raporlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstRaporlar;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnGunlukRapor;
        private Button btnAylikRapor;
        private Button btnHaftalikRapor;
        private ListView lstYemekler;
    }
}