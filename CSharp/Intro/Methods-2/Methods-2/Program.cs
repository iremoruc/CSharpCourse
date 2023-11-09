namespace Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; // genelde veriler bi veri kaynağından gelir

            //Type-safe-- Tip güvenliği
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("-----------------");

            //instance - class örneği
            //enscapsulation
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "kırmızı elma", 13);
            sepetManager.Ekle2("karpuz", "diyarbakır", 19);



        }
    }
}
// Dont repaat yourseflf - DRY - Clean code - Best Practice