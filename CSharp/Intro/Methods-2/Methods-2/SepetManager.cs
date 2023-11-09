using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    public class SepetManager //bir operasyon tutuyor
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine($"Sepete eklendi: {urun.Adi}");
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine($"Sepete eklendi: {urunAdi}");

        }
    }
}
