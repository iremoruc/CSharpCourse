using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Emir","İrem","Umay" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Emir","İrem","Umay" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Nur");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);






        }
    }
}