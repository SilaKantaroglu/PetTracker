using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetTracker
{
    public partial class HayvanDetayForm : Form
    {
        private Hayvan seciliHayvan;
        public HayvanDetayForm(Hayvan hayvan)
        {
            InitializeComponent();
            seciliHayvan = hayvan;
        }

        private void HayvanDetayForm_Load(object sender, EventArgs e)
        {
            BilgileriGoster();
        }


        private void BilgileriGoster()
        {
            txtDetayIsim.Text = seciliHayvan.Isim;
            txtDetayYas.Text = seciliHayvan.Yas.ToString();
            txtDetayTur.Text = seciliHayvan.Tur;
            txtDetayCinsiyet.Text = seciliHayvan.Cinsiyet;
            txtDetayAgirlik.Text = seciliHayvan.Agirlik.ToString("0.0") + " kg";
            txtDetayEkBilgi.Text = seciliHayvan.EkBilgi;

            lstDetayAsilar.Items.Clear();
            foreach (var asi in seciliHayvan.Asilar)
            {
                lstDetayAsilar.Items.Add($"{asi.AsiAdi} - {asi.Tarih.ToShortDateString()}");
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDetayAgirlik.Text, out double agirlik) && int.TryParse(txtDetayYas.Text, out int yas))
            {
                seciliHayvan.Isim = txtDetayIsim.Text;
                seciliHayvan.Yas = yas;
                seciliHayvan.Tur = txtDetayTur.Text;
                seciliHayvan.Cinsiyet = txtDetayCinsiyet.Text;
                seciliHayvan.Agirlik = agirlik;
                seciliHayvan.EkBilgi = txtDetayEkBilgi.Text;

                MessageBox.Show("Bilgiler güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Güncelleme yapıldı bilgisi için
                this.Close();
            }
            else
            {
                MessageBox.Show("Yaş ve ağırlık sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAsiSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = lstDetayAsilar.SelectedIndex;
            if (seciliIndex >= 0 && seciliIndex < seciliHayvan.Asilar.Count)
            {
                var silinecekAsi = seciliHayvan.Asilar[seciliIndex];
                var sonuc = MessageBox.Show($"'{silinecekAsi.AsiAdi}' aşısını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    seciliHayvan.Asilar.RemoveAt(seciliIndex);
                    BilgileriGoster();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir aşı seçin.");
            }
        }



       
    }
}
