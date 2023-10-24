namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //string city2 = "İstanbul";
            //string result = city + city2;

            //Intro();

            string sentence = "My name is İrem";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith(" ğ");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, "); // 0ncı elemndan itibaren cümleye ekle
            var result9 = sentence.Substring(3,4); // 3.karakterden itibaren 4 tane al
            var result10= sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,5); // 2den itibaren 5 karakteri sil
            Console.WriteLine(result12);

        }
    }
}