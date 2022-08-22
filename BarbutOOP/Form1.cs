using BarbutOOP.Models;

namespace BarbutOOP
{
    public partial class Form1 : Form
    {
        Zar zar = new Zar();
        string dice = "dice-";
        string uzanti = ".png";

        string klasor = Application.StartupPath.Replace( @"bin\Debug\net6.0-windows", @"dices\");

        // C:\Users\akilbek.ismanov\source\repos\BarbutOOP\BarbutOOP\bin\Debug\net6.0-windows

        public Form1()
        {
            InitializeComponent();
        }

        private void lSayi1_Click(object sender, EventArgs e)
        {

        }

        private void bZarAt_Click(object sender, EventArgs e)
        {
            ZarAt();

        }

        void ZarAt()
        {
            zar.At();
            int Sayi1 = zar.Sayi;
            lSayi1.Text = Sayi1.ToString();
            lSayi1.Visible = true;
            pbSayi1.ImageLocation = klasor + dice + Sayi1 + uzanti;
            zar.At();
            int Sayi2 = zar.Sayi;
            lSayi2.Text = Sayi2.ToString();
            lSayi2.Visible = true;
            pbSayi2.ImageLocation = klasor + dice + Sayi2 + uzanti;

            if (Sayi1 > Sayi2)
                lbSonuc.Items.Add("Sen");
            else if (Sayi2 > Sayi1)
                lbSonuc.Items.Add("Rakip");
            else
                //lbSonuc.Items.Add("Berabere"); // burda berabere yazdýrmak istiyorsak
                ZarAt();  // burda berabere gelince method'u tekrar çagýrýrýz berebere olmayacak
        }
    }
}