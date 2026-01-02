using System.Diagnostics;

class Program
{
    static void Main()
    {
        bool ATMloop = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Dil Seçiniz TR | Selec Language EN");
        Console.ResetColor();
        string Sdil = Console.ReadLine() ?? "TR";
        Bankamatik YeniHesap = new Bankamatik("Kürşat" Sdil);
        while (ATMloop)
        {


            YeniHesap.BilgiGoster();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
            Console.WriteLine("1 Para Çekmek");
            Console.WriteLine("2 Para yatırmak");
            Console.WriteLine("0 Çıkış yapın");
            string cevap = Console.ReadLine() ?? "";
            if (cevap == "1")
            {
                YeniHesap.ParaCek();

            }
            else if (cevap == "2")
            {
                YeniHesap.ParaYatır();
            }
            else if (cevap == "0")
            {
                ATMloop = false;
            }
            else
            {
                Console.WriteLine("lütfen doğru tuşa basınız");
            }

        }

    }

    class Bankamatik
    {
        string dil ; 
        double miktar;
        public string? HesapSahibi;
        public double Bakiye = 500;


        public Bankamatik(string Gelenİsim, string Gelendil)
        {
            HesapSahibi = Gelenİsim;
            dil = Gelendil.ToUpper();

        }

        public void ParaYatır()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lütfen Yatırmak istediğiniz miktarı giriniz");
            miktar = Convert.ToInt32(Console.ReadLine());
            Bakiye += miktar;
            Console.WriteLine($"Hesabınıza {miktar} yatırıldı.Yeni bakiye {Bakiye}");
        }

        public void ParaCek()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lütfen Çekmek istediğiniz miktarı giriniz");
            miktar = Convert.ToInt32(Console.ReadLine());

            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                Console.WriteLine($"Para Çekildi Geri kalan Para {Bakiye}");
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye");
            }
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Sayın {HesapSahibi} Hesabınızdaki Para: {Bakiye}");
        }

        public void lang()
        {
            
        }
    }


}