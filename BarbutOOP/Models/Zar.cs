namespace BarbutOOP.Models
{
    class Zar
    {
        Random random = new Random();
        public int Sayi { get; set; }

        public void At()
        {
            Sayi = random.Next(1, 7);
        }
    }
}
