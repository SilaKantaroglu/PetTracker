namespace PetTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTur = new ComboBox();
            txtIsim = new TextBox();
            txtYas = new TextBox();
            lblIsım = new Label();
            lblYas = new Label();
            btnEkle = new Button();
            btnAsiEkle = new Button();
            lstHayvanlar = new ListBox();
            lstAsilar = new ListBox();
            lblTur = new Label();
            lblHayvanlar = new Label();
            lblAsilar = new Label();
            lblAsiAdi = new Label();
            txtAsiAdi = new TextBox();
            dtpAsiTarihi = new DateTimePicker();
            btnDetayGoster = new Button();
            lblDetayYas = new Label();
            lblCinsiyet = new Label();
            lblAgirlik = new Label();
            lblEkbilgi = new Label();
            cmbCinsiyet = new ComboBox();
            txtAgirlik = new TextBox();
            txtEkBilgi = new TextBox();
            SuspendLayout();
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(78, 34);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(125, 23);
            cmbTur.TabIndex = 0;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(78, 63);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(125, 23);
            txtIsim.TabIndex = 1;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(78, 96);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 23);
            txtYas.TabIndex = 2;
            // 
            // lblIsım
            // 
            lblIsım.AutoSize = true;
            lblIsım.Location = new Point(12, 71);
            lblIsım.Name = "lblIsım";
            lblIsım.Size = new Size(35, 15);
            lblIsım.TabIndex = 3;
            lblIsım.Text = "İsim :";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(12, 104);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(30, 15);
            lblYas.TabIndex = 4;
            lblYas.Text = "Yaş :";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(22, 237);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(139, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Hayvan Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnAsiEkle
            // 
            btnAsiEkle.Location = new Point(352, 171);
            btnAsiEkle.Name = "btnAsiEkle";
            btnAsiEkle.Size = new Size(122, 23);
            btnAsiEkle.TabIndex = 7;
            btnAsiEkle.Text = "Aşı Ekle";
            btnAsiEkle.UseVisualStyleBackColor = true;
            btnAsiEkle.Click += btnAsiEkle_Click_1;
            // 
            // lstHayvanlar
            // 
            lstHayvanlar.FormattingEnabled = true;
            lstHayvanlar.ItemHeight = 15;
            lstHayvanlar.Location = new Point(22, 293);
            lstHayvanlar.Name = "lstHayvanlar";
            lstHayvanlar.Size = new Size(198, 94);
            lstHayvanlar.TabIndex = 8;
            lstHayvanlar.SelectedIndexChanged += lstHayvanlar_SelectedIndexChanged_1;
            // 
            // lstAsilar
            // 
            lstAsilar.FormattingEnabled = true;
            lstAsilar.ItemHeight = 15;
            lstAsilar.Location = new Point(311, 227);
            lstAsilar.Name = "lstAsilar";
            lstAsilar.Size = new Size(198, 94);
            lstAsilar.TabIndex = 9;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(12, 37);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(62, 15);
            lblTur.TabIndex = 10;
            lblTur.Text = "Tür seçiniz";
            // 
            // lblHayvanlar
            // 
            lblHayvanlar.AutoSize = true;
            lblHayvanlar.Location = new Point(22, 275);
            lblHayvanlar.Name = "lblHayvanlar";
            lblHayvanlar.Size = new Size(66, 15);
            lblHayvanlar.TabIndex = 11;
            lblHayvanlar.Text = "Hayvanlar: \r\n";
            // 
            // lblAsilar
            // 
            lblAsilar.AutoSize = true;
            lblAsilar.Location = new Point(311, 209);
            lblAsilar.Name = "lblAsilar";
            lblAsilar.Size = new Size(42, 15);
            lblAsilar.TabIndex = 12;
            lblAsilar.Text = "Aşılar: ";
            // 
            // lblAsiAdi
            // 
            lblAsiAdi.AutoSize = true;
            lblAsiAdi.Location = new Point(311, 96);
            lblAsiAdi.Name = "lblAsiAdi";
            lblAsiAdi.Size = new Size(64, 15);
            lblAsiAdi.TabIndex = 13;
            lblAsiAdi.Text = "Aşının Adı:";
            // 
            // txtAsiAdi
            // 
            txtAsiAdi.Location = new Point(384, 88);
            txtAsiAdi.Name = "txtAsiAdi";
            txtAsiAdi.Size = new Size(125, 23);
            txtAsiAdi.TabIndex = 14;
            // 
            // dtpAsiTarihi
            // 
            dtpAsiTarihi.Location = new Point(311, 130);
            dtpAsiTarihi.Name = "dtpAsiTarihi";
            dtpAsiTarihi.Size = new Size(200, 23);
            dtpAsiTarihi.TabIndex = 15;
            // 
            // btnDetayGoster
            // 
            btnDetayGoster.Location = new Point(22, 393);
            btnDetayGoster.Name = "btnDetayGoster";
            btnDetayGoster.Size = new Size(139, 23);
            btnDetayGoster.TabIndex = 17;
            btnDetayGoster.Text = "Detay Göster";
            btnDetayGoster.UseVisualStyleBackColor = true;
            btnDetayGoster.Click += btnDetayGoster_Click;
            // 
            // lblDetayYas
            // 
            lblDetayYas.Location = new Point(0, 0);
            lblDetayYas.Name = "lblDetayYas";
            lblDetayYas.Size = new Size(100, 23);
            lblDetayYas.TabIndex = 0;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(12, 138);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(55, 15);
            lblCinsiyet.TabIndex = 18;
            lblCinsiyet.Text = "Cinsiyet :";
            // 
            // lblAgirlik
            // 
            lblAgirlik.AutoSize = true;
            lblAgirlik.Location = new Point(12, 171);
            lblAgirlik.Name = "lblAgirlik";
            lblAgirlik.Size = new Size(47, 15);
            lblAgirlik.TabIndex = 19;
            lblAgirlik.Text = "Ağırlık :";
            // 
            // lblEkbilgi
            // 
            lblEkbilgi.AutoSize = true;
            lblEkbilgi.Location = new Point(12, 200);
            lblEkbilgi.Name = "lblEkbilgi";
            lblEkbilgi.Size = new Size(54, 15);
            lblEkbilgi.TabIndex = 20;
            lblEkbilgi.Text = "Ek Bilgi : ";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(78, 133);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(125, 23);
            cmbCinsiyet.TabIndex = 21;
            // 
            // txtAgirlik
            // 
            txtAgirlik.Location = new Point(78, 168);
            txtAgirlik.Name = "txtAgirlik";
            txtAgirlik.Size = new Size(125, 23);
            txtAgirlik.TabIndex = 22;
            // 
            // txtEkBilgi
            // 
            txtEkBilgi.Location = new Point(78, 201);
            txtEkBilgi.Name = "txtEkBilgi";
            txtEkBilgi.Size = new Size(125, 23);
            txtEkBilgi.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 442);
            Controls.Add(txtEkBilgi);
            Controls.Add(txtAgirlik);
            Controls.Add(cmbCinsiyet);
            Controls.Add(lblEkbilgi);
            Controls.Add(lblAgirlik);
            Controls.Add(lblCinsiyet);
            Controls.Add(lblDetayYas);
            Controls.Add(btnDetayGoster);
            Controls.Add(dtpAsiTarihi);
            Controls.Add(txtAsiAdi);
            Controls.Add(lblAsiAdi);
            Controls.Add(lblAsilar);
            Controls.Add(lblHayvanlar);
            Controls.Add(lblTur);
            Controls.Add(lstAsilar);
            Controls.Add(lstHayvanlar);
            Controls.Add(btnAsiEkle);
            Controls.Add(btnEkle);
            Controls.Add(lblYas);
            Controls.Add(lblIsım);
            Controls.Add(txtYas);
            Controls.Add(txtIsim);
            Controls.Add(cmbTur);
            Name = "Form1";
            Text = "Pet Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTur;
        private TextBox txtIsim;
        private TextBox txtYas;
        private Label lblIsım;
        private Label lblYas;
        private Button btnEkle;
        private Button btnAsiEkle;
        private ListBox lstHayvanlar;
        private ListBox lstAsilar;
        private Label lblTur;
        private Label lblHayvanlar;
        private Label lblAsilar;
        private Label lblAsiAdi;
        private TextBox txtAsiAdi;
        private DateTimePicker dtpAsiTarihi;
        private Button btnDetayGoster;
        private Label lblDetayYas;
        private Label lblCinsiyet;
        private Label lblAgirlik;
        private Label lblEkbilgi;
        private ComboBox cmbCinsiyet;
        private TextBox txtAgirlik;
        private TextBox txtEkBilgi;
    }
}
