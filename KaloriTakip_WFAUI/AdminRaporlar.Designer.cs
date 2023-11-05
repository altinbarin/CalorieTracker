namespace KaloriTakip_WFAUI
{
    partial class AdminRaporlar
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
            btnOguneGoreYemek = new Button();
            btnHangiYemekHangiOgun = new Button();
            btnEnCokHangiYemek = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnOguneGoreYemek
            // 
            btnOguneGoreYemek.BackColor = Color.DarkOliveGreen;
            btnOguneGoreYemek.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOguneGoreYemek.ForeColor = Color.White;
            btnOguneGoreYemek.Location = new Point(40, 46);
            btnOguneGoreYemek.Name = "btnOguneGoreYemek";
            btnOguneGoreYemek.Size = new Size(153, 63);
            btnOguneGoreYemek.TabIndex = 0;
            btnOguneGoreYemek.Text = "Hangi Öğünde En Çok Ne Yenmiş";
            btnOguneGoreYemek.UseVisualStyleBackColor = false;
            btnOguneGoreYemek.Click += btnOguneGoreYemek_Click;
            // 
            // btnHangiYemekHangiOgun
            // 
            btnHangiYemekHangiOgun.BackColor = Color.DarkOliveGreen;
            btnHangiYemekHangiOgun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHangiYemekHangiOgun.ForeColor = Color.White;
            btnHangiYemekHangiOgun.Location = new Point(40, 159);
            btnHangiYemekHangiOgun.Name = "btnHangiYemekHangiOgun";
            btnHangiYemekHangiOgun.Size = new Size(153, 63);
            btnHangiYemekHangiOgun.TabIndex = 0;
            btnHangiYemekHangiOgun.Text = "Hangi Yemek Hangi Öğünde Kaç Tane Yenmiş";
            btnHangiYemekHangiOgun.UseVisualStyleBackColor = false;
            btnHangiYemekHangiOgun.Click += btnHangiYemekHangiOgun_Click;
            // 
            // btnEnCokHangiYemek
            // 
            btnEnCokHangiYemek.BackColor = Color.DarkOliveGreen;
            btnEnCokHangiYemek.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnCokHangiYemek.ForeColor = Color.White;
            btnEnCokHangiYemek.Location = new Point(40, 254);
            btnEnCokHangiYemek.Name = "btnEnCokHangiYemek";
            btnEnCokHangiYemek.Size = new Size(153, 63);
            btnEnCokHangiYemek.TabIndex = 0;
            btnEnCokHangiYemek.Text = "En Çok Yenen Yemek";
            btnEnCokHangiYemek.UseVisualStyleBackColor = false;
            btnEnCokHangiYemek.Click += btnEnCokHangiYemek_Click;
            // 
            // label1
            // 
            label1.Location = new Point(245, 254);
            label1.Name = "label1";
            label1.Size = new Size(291, 63);
            label1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(234, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(349, 169);
            listBox1.TabIndex = 3;
            // 
            // AdminRaporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(651, 359);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(btnEnCokHangiYemek);
            Controls.Add(btnHangiYemekHangiOgun);
            Controls.Add(btnOguneGoreYemek);
            Name = "AdminRaporlar";
            Text = "AdminRaporlar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOguneGoreYemek;
        private Button btnHangiYemekHangiOgun;
        private Button btnEnCokHangiYemek;
        private Label label1;
        private ListBox listBox1;
    }
}