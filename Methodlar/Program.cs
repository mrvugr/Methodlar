using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string acıklama = "Amasya Elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };
            //Urun urun1 = new Urun();//classı tanımlamak classın örneği

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat1 = 15;
            urun1.Acıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat1 = 80;
            urun2.Acıklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat1);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("--------Metotlar----------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakir Karpuzu", 12,6);
        }
    }
}



//dont repeat yourself --DRY 