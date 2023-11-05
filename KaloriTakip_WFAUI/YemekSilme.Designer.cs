namespace KaloriTakip_WFAUI
{
    partial class YemekSilme
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
            btnSil = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbYemeklerYemekSilme = new ComboBox();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkOliveGreen;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(305, 233);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(227, 52);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOliveGreen;
            label7.Location = new Point(330, 130);
            label7.Name = "label7";
            label7.Size = new Size(170, 32);
            label7.TabIndex = 18;
            label7.Text = "YEMEK SİLME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkOliveGreen;
            label8.Location = new Point(213, 183);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 17;
            label8.Text = "Yemekler:";
            // 
            // cmbYemeklerYemekSilme
            // 
            cmbYemeklerYemekSilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemeklerYemekSilme.FormattingEnabled = true;
            cmbYemeklerYemekSilme.Location = new Point(305, 180);
            cmbYemeklerYemekSilme.Margin = new Padding(3, 4, 3, 4);
            cmbYemeklerYemekSilme.Name = "cmbYemeklerYemekSilme";
            cmbYemeklerYemekSilme.Size = new Size(227, 28);
            cmbYemeklerYemekSilme.TabIndex = 16;
            // 
            // YemekSilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSil);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(cmbYemeklerYemekSilme);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YemekSilme";
            Text = "YemekSilme";
            Load += YemekSilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Label label7;
        private Label label8;
        private ComboBox cmbYemeklerYemekSilme;
    }
}