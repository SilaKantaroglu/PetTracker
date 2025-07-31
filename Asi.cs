namespace PetTracker
{
    public class Asi
    {
        public  string AsiAdi { get; set; }
        public DateTime Tarih { get; set; }

        public override string ToString()
        {
            return $"{AsiAdi} - {Tarih.ToShortDateString()}";
        }
    }



}
