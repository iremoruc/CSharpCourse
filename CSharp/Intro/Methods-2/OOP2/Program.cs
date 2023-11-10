namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi= "Demiroğ";
            musteri1.TcNo = "12345678910";

            //kodlama.io
            TuzelMusteri musteri2= new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "125";
            musteri2.SirketAdi= "kodlama.io";
            musteri2.VergiNo = "12345678930";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();


        }
    }
}