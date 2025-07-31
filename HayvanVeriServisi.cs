using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetTracker
{
    public class HayvanVeriServisi
    {

        private static readonly string DosyaYolu = "veridosyasi.json";

        public static void VerileriKaydet(List<Hayvan> hayvanListesi)
        {
            try
            {
                string json = JsonConvert.SerializeObject(hayvanListesi, Formatting.Indented);
                File.WriteAllText(DosyaYolu, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Kaydetme sırasında hata oluştu: " + ex.Message);
            }
        }

        public static List<Hayvan> VerileriYukle()
        {
            try
            {
                if (File.Exists(DosyaYolu))
                {
                    string json = File.ReadAllText(DosyaYolu);
                    return JsonConvert.DeserializeObject<List<Hayvan>>(json);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Yükleme sırasında hata oluştu: " + ex.Message);
            }

            return new List<Hayvan>();
        }
    }
}
