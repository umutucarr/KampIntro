using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //DO NOT REPEAT YOURSELF - DRY - Clean Code - Best Practice (doğru uygulama teknikleri)
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            //c#, java gibi dille type safe - tip güvenliği vardır. 
            foreach (Urun urun in urunler) //var urun yazarsak ta olur var direk  veri tipini alır.
            {
                Console.WriteLine(urun.Adi+" "+ urun.Fiyati+" "+urun.Aciklama);
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("-----------metodlar------------");
            //instance - örnek 
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 14,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80,20);




        }
    }
}
