using System.Runtime.CompilerServices;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");

            //int number = 100;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;

            //} while(number >=11);

            //string[] students = { "İrem", "Emir","Umay" };
            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student); 
            //}

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}