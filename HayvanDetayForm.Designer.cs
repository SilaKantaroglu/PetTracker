namespace PetTracker
{
    partial class HayvanDetayForm
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
            lblDetayIsım = new Label();
            lblDetayTur = new Label();
            lblDetayYas = new Label();
            lblDetayCinsiyet = new Label();
            lblAgirlik = new Label();
            label1 = new Label();
            lblAsilar = new Label();
            txtDetayIsim = new TextBox();
            txtDetayTur = new TextBox();
            txtDetayYas = new TextBox();
            txtDetayCinsiyet = new TextBox();
            txtDetayAgirlik = new TextBox();
            txtDetayEkBilgi = new TextBox();
            lstDetayAsilar = new ListBox();
            btnGuncelle = new Button();
            btnAsiSil = new Button();
            btnHayvaniSil = new Button();
            SuspendLayout();
            // 
            // lblDetayIsım
            // 
            lblDetayIsım.AutoSize = true;
            lblDetayIsım.Location = new Point(51, 57);
            lblDetayIsım.Name = "lblDetayIsım";
            lblDetayIsım.Size = new Size(32, 15);
            lblDetayIsım.TabIndex = 11;
            lblDetayIsım.Text = "İsim:";
            // 
            // lblDetayTur
            // 
            lblDetayTur.AutoSize = true;
            lblDetayTur.Location = new Point(51, 98);
            lblDetayTur.Name = "lblDetayTur";
            lblDetayTur.Size = new Size(24, 15);
            lblDetayTur.TabIndex = 12;
            lblDetayTur.Text = "Tür";
            // 
            // lblDetayYas
            // 
            lblDetayYas.AutoSize = true;
            lblDetayYas.Location = new Point(51, 143);
            lblDetayYas.Name = "lblDetayYas";
            lblDetayYas.Size = new Size(30, 15);
            lblDetayYas.TabIndex = 13;
            lblDetayYas.Text = "Yaş: ";
            // 
            // lblDetayCinsiyet
            // 
            lblDetayCinsiyet.AutoSize = true;
            lblDetayCinsiyet.Location = new Point(51, 192);
            lblDetayCinsiyet.Name = "lblDetayCinsiyet";
            lblDetayCinsiyet.Size = new Size(58, 15);
            lblDetayCinsiyet.TabIndex = 14;
            lblDetayCinsiyet.Text = "Cinsiyet : ";
            // 
            // lblAgirlik
            // 
            lblAgirlik.AutoSize = true;
            lblAgirlik.Location = new Point(51, 243);
            lblAgirlik.Name = "lblAgirlik";
            lblAgirlik.Size = new Size(50, 15);
            lblAgirlik.TabIndex = 15;
            lblAgirlik.Text = "Ağırlık : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 300);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Ek Bilgi : ";
            // 
            // lblAsilar
            // 
            lblAsilar.AutoSize = true;
            lblAsilar.Location = new Point(51, 399);
            lblAsilar.Name = "lblAsilar";
            lblAsilar.Size = new Size(42, 15);
            lblAsilar.TabIndex = 17;
            lblAsilar.Text = "Aşılar: ";
            // 
            // txtDetayIsim
            // 
            txtDetayIsim.Location = new Point(146, 49);
            txtDetayIsim.Name = "txtDetayIsim";
            txtDetayIsim.ReadOnly = true;
            txtDetayIsim.Size = new Size(125, 23);
            txtDetayIsim.TabIndex = 18;
            // 
            // txtDetayTur
            // 
            txtDetayTur.Location = new Point(146, 86);
            txtDetayTur.Name = "txtDetayTur";
            txtDetayTur.ReadOnly = true;
            txtDetayTur.Size = new Size(125, 23);
            txtDetayTur.TabIndex = 19;
            // 
            // txtDetayYas
            // 
            txtDetayYas.Location = new Point(146, 135);
            txtDetayYas.Name = "txtDetayYas";
            txtDetayYas.ReadOnly = true;
            txtDetayYas.Size = new Size(125, 23);
            txtDetayYas.TabIndex = 20;
            // 
            // txtDetayCinsiyet
            // 
            txtDetayCinsiyet.Location = new Point(146, 184);
            txtDetayCinsiyet.Name = "txtDetayCinsiyet";
            txtDetayCinsiyet.Size = new Size(125, 23);
            txtDetayCinsiyet.TabIndex = 21;
            // 
            // txtDetayAgirlik
            // 
            txtDetayAgirlik.Location = new Point(146, 235);
            txtDetayAgirlik.Name = "txtDetayAgirlik";
            txtDetayAgirlik.Size = new Size(125, 23);
            txtDetayAgirlik.TabIndex = 22;
            // 
            // txtDetayEkBilgi
            // 
            txtDetayEkBilgi.Location = new Point(146, 300);
            txtDetayEkBilgi.Multiline = true;
            txtDetayEkBilgi.Name = "txtDetayEkBilgi";
            txtDetayEkBilgi.Size = new Size(125, 23);
            txtDetayEkBilgi.TabIndex = 23;
            // 
            // lstDetayAsilar
            // 
            lstDetayAsilar.FormattingEnabled = true;
            lstDetayAsilar.ItemHeight = 15;
            lstDetayAsilar.Location = new Point(135, 399);
            lstDetayAsilar.Name = "lstDetayAsilar";
            lstDetayAsilar.Size = new Size(125, 64);
            lstDetayAsilar.TabIndex = 24;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(35, 508);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(146, 28);
            btnGuncelle.TabIndex = 25;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnAsiSil
            // 
            btnAsiSil.Location = new Point(196, 508);
            btnAsiSil.Name = "btnAsiSil";
            btnAsiSil.Size = new Size(146, 28);
            btnAsiSil.TabIndex = 26;
            btnAsiSil.Text = "Seçili Aşıyı Sil";
            btnAsiSil.UseVisualStyleBackColor = true;
            btnAsiSil.Click += btnAsiSil_Click;
            // 
            // btnHayvaniSil
            // 
            btnHayvaniSil.Location = new Point(0, 0);
            btnHayvaniSil.Name = "btnHayvaniSil";
            btnHayvaniSil.Size = new Size(75, 23);
            btnHayvaniSil.TabIndex = 30;
            // 
            // HayvanDetayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 579);
            Controls.Add(btnHayvaniSil);
            Controls.Add(btnAsiSil);
            Controls.Add(btnGuncelle);
            Controls.Add(lstDetayAsilar);
            Controls.Add(txtDetayEkBilgi);
            Controls.Add(txtDetayAgirlik);
            Controls.Add(txtDetayCinsiyet);
            Controls.Add(txtDetayYas);
            Controls.Add(txtDetayTur);
            Controls.Add(txtDetayIsim);
            Controls.Add(lblAsilar);
            Controls.Add(label1);
            Controls.Add(lblAgirlik);
            Controls.Add(lblDetayCinsiyet);
            Controls.Add(lblDetayYas);
            Controls.Add(lblDetayTur);
            Controls.Add(lblDetayIsım);
            Name = "HayvanDetayForm";
            Text = "Hayvan Detayları";
            Load += HayvanDetayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetayIsım;
        private Label lblDetayTur;
        private Label lblDetayYas;
        private Label lblDetayCinsiyet;
        private Label lblAgirlik;
        private Label label1;
        private Label lblAsilar;
        private TextBox txtDetayIsim;
        private TextBox txtDetayTur;
        private TextBox txtDetayYas;
        private TextBox txtDetayCinsiyet;
        private TextBox txtDetayAgirlik;
        private TextBox txtDetayEkBilgi;
        private ListBox lstDetayAsilar;
        private Button btnGuncelle;
        private Button btnAsiSil;
        private Button btnHayvaniSil;
    }
}