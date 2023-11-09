namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emir");

            Console.WriteLine(isimler.Lenght);
            isimler.Add("irem");

            Console.WriteLine(isimler.Lenght);

            foreach(var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}