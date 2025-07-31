using Newtonsoft.Json;

namespace PetTracker
{
    public partial class Form1 : Form
    {
     
        List<Hayvan> hayvanListesi = new List<Hayvan>();


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(new string[] { "Erkek", "Dişi" });
            cmbTur.Items.AddRange(new string[] { "Kedi", "Köpek", "Kuş" });
            cmbTur.SelectedIndex = 0;
            hayvanListesi = HayvanVeriServisi.VerileriYukle();
            HayvanlariListele();
        }





        private void HayvanlariListele()
        {
            lstHayvanlar.Items.Clear();
            foreach (var hayvan in hayvanListesi)
            {
                lstHayvanlar.Items.Add(hayvan);
            }
        }

        private void AsilariListele(Hayvan hayvan)
        {
            lstAsilar.Items.Clear();
            if (hayvan != null)
            {
                foreach (var asi in hayvan.Asilar)
                {
                    lstAsilar.Items.Add(asi);
                }
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsim.Text))
            {
                MessageBox.Show("Hayvan ismi giriniz.");
                return;
            }

            Hayvan hayvan = new Hayvan
            {
                Isim = txtIsim.Text,
                Yas = int.TryParse(txtYas.Text, out int yas) ? yas : 0,
                Tur = cmbTur.SelectedItem?.ToString() ?? "Bilinmiyor",
                Cinsiyet = cmbCinsiyet.SelectedItem.ToString(),
                Agirlik = Convert.ToDouble(txtAgirlik.Text),
                EkBilgi = txtEkBilgi.Text,
            };

            hayvanListesi.Add(hayvan);
            HayvanVeriServisi.VerileriKaydet(hayvanListesi);
            HayvanlariListele();

            cmbTur.SelectedIndex = -1;
            cmbCinsiyet.SelectedIndex = -1;
            txtAgirlik.Clear();
            txtIsim.Clear();
            txtYas.Clear();
            txtEkBilgi.Clear();

        }




        private void btnAsiEkle_Click_1(object sender, EventArgs e)
        {
            if (lstHayvanlar.SelectedItem is Hayvan seciliHayvan)
            {
                if (string.IsNullOrWhiteSpace(txtAsiAdi.Text))
                {
                    MessageBox.Show("Aşı adı giriniz.");
                    return;
                }

                Asi asi = new Asi
                {
                    AsiAdi = txtAsiAdi.Text,
                    Tarih = dtpAsiTarihi.Value
                };

                seciliHayvan.Asilar.Add(asi);
                HayvanVeriServisi.VerileriKaydet(hayvanListesi);
                AsilariListele(seciliHayvan);

                txtAsiAdi.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir hayvan seçin.");
            }
        }




        private void lstHayvanlar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstHayvanlar.SelectedItem is Hayvan seciliHayvan)
            {
                AsilariListele(seciliHayvan);

            }
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            
            if (lstHayvanlar.SelectedItem is Hayvan seciliHayvan)
            {
                var hayvanDetayForm = new HayvanDetayForm(seciliHayvan);
                if (hayvanDetayForm.ShowDialog() == DialogResult.OK)
                {
                    HayvanlariListele();

                    HayvanVeriServisi.VerileriKaydet(hayvanListesi); // Güncellenen verileri kaydet
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
            }
        }
    }
        
}

