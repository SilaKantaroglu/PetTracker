using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTracker
{
    public class Hayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }
        public string Tur { get; set; }
        public string Cinsiyet { get; set; }
        public double Agirlik { get; set; }
        public string EkBilgi { get; set; }
        public List<Asi> Asilar { get; set; } = new List<Asi>();

        public override string ToString()
        {
            return $"{Isim} ({Tur})";
        }
    }
}
