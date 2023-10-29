
// Asal sayı çözümü
//int sayac = 0;
//for (int sayi = 2; sayi <= 100; sayi++)
//{
//    int kontrol = 0;

//    for (int i = 2; i < sayi; i++)
//    {
//        if (sayi % i == 0)
//        {
//            kontrol = 1;
//            break;
//        }
//    }
//    if (kontrol == 0)
//    {
//        Console.WriteLine("{0} asaldır.", sayi);
//        sayac++;
//    }
//}

//1 - Write a C# program to check if the entered number is Armstrong number? 
void question_1()
{
    int find_number_of_digits(int number)
    {
        int n_digits = 0;
        while (number > 0)
        {
            n_digits++;
            number /= 10;
        }
        return (n_digits);
    }

    int find_armstrong_value(int number, int n_digits)
    {
        double sum = 0;
        while (number > 0)
        {
            sum += Math.Pow(number % 10, n_digits);
            number /= 10;
        }
        return (int)sum;
    }

    Console.WriteLine("QUESTION: Write a C# program to check if the entered number is Armstrong number?");
    Console.Write("Give a positive number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int n_digits = find_number_of_digits(number);
    int arms_value = find_armstrong_value(number, n_digits);

    Console.WriteLine($"Armstrong value is: {arms_value}");
    if (arms_value == number)
    {
        Console.WriteLine($"{number} is an Armstrong Number");
    }
    else
    {
        Console.WriteLine($"{number} is NOT an Armstrong Number");
    }
}

//2-Write a C# function to print first 100 numbers in Fibonacci series? 
void question_2()
{
    void fibonacci_computer(int number)
    {
        int current = 1, prev = 0, next;
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(current);
            next = current + prev;
            prev = current;
            current = next;
        }
    }

    Console.WriteLine("QUESTION: Write a C# function to print first n numbers in Fibonacci series? ");
    Console.Write("Give a positive number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    fibonacci_computer(number);
}

//3-Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1 
void question_3()
{
    Console.WriteLine("QUESTION: Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1 ");
    Console.Write("Give a string: ");
    string input = Console.ReadLine();
    input = input.ToLower();

    for (char letter = '0'; letter <= 'z'; letter++)
    {
        int count = 0;
        foreach (char input_letter in input)
        {
            if (letter == input_letter) count++;
        }
        if (count > 0) Console.WriteLine($"{letter}:{count}");
    }
}

//4-How to check if two Strings are anagrams of each other? 
void question_4()
{
    Console.WriteLine("QUESTION: How to check if two Strings are anagrams of each other? ");
    Console.Write("Give the first string: ");
    string input1 = Console.ReadLine().ToLower();
    Console.Write("Give the second string: ");
    string input2 = Console.ReadLine().ToLower();


    bool is_anagram = true;
    for (char letter = '0'; letter <= 'z'; letter++)
    {
        int count1 = 0, count2 = 0;
        foreach (char letter1 in input1)
        {
            if (letter == letter1) count1++;
        }
        foreach (char letter2 in input2)
        {
            if (letter == letter2) count2++;
        }

        if (count1 != count2)
        {
            is_anagram = false;
        }
    }
    if (is_anagram) Console.WriteLine($"{input1} and {input2} words are Anagrams");
    else Console.WriteLine($"{input1} and {input2} words are NOT Anagrams");
}

//5-How to determine if the string has all unique characters.
void question_5()
{
    Console.WriteLine("QUESTION: How to determine if the string has all unique characters. ");
    Console.Write("Give the input string: ");
    string input = Console.ReadLine();

    bool is_unique = true;
    for (char letter = '0'; letter <= 'z'; letter++)
    {
        int count = 0;
        foreach (char input_letter in input)
        {
            if (letter == input_letter) count++;
        }

        if (count > 1)
        {
            is_unique = false;
            Console.WriteLine($"'{letter}' character occurs {count} times");

        }
    }
    if (is_unique) Console.WriteLine($"{input} string has all unique characters");
    else Console.WriteLine($"{input} string does NOT have all unique characters");
}

// 6-Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210)
int get_sum_of_divisors_of_a_number(int number)
{
    int sum_of_divisors = 1;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            sum_of_divisors += i;
            if (number / i != i) sum_of_divisors += number / i;
        }
    }
    return sum_of_divisors;
}
void question_6()
{
    Console.WriteLine("QUESTION: Write a C# program finds first n amicable pairs. (Output: 1-> 220-284 2: 1184-1210) ");
    Console.Write("Give the number of pairs required: ");
    int n_pairs = Convert.ToInt32(Console.ReadLine());
    int num1 = 0, num2 = 0;
    for (int i = 1; i <= n_pairs; i++)
    {
        bool is_found = false;
        while (!is_found)
        {
            num2 = get_sum_of_divisors_of_a_number(num1);
            int sum_of_divisors_of_num2 = get_sum_of_divisors_of_a_number(num2);
            if (sum_of_divisors_of_num2 == num1 && num1 < num2)
            {
                is_found = true;
            }
            num1++;
        }
        Console.WriteLine($"Pair {i} : {num1 - 1}-{num2}");
    }
}

// 7-Write a C# program finds first 10 perfect numbers.
// SAÇMA, 9uncu perfect number 19 basamaklı bir sayı.. 2305843008139952128
// 6ncı perfect sayı 33550336
void question_7()
{
    Console.WriteLine("QUESTION: Write a C# program finds first n perfect numbers. ");
    Console.Write("Give the number of perfect numbers required: ");
    int n_number = Convert.ToInt32(Console.ReadLine());
    int num1 = 0;
    for (int i = 1; i <= n_number; i++)
    {
        bool is_found = false;
        while (!is_found)
        {
            int sum_of_divisors = get_sum_of_divisors_of_a_number(num1);

            if (sum_of_divisors == num1)
            {
                is_found = true;
            }
            num1++;
        }
        Console.WriteLine($"Perfect number {i} : {num1 - 1}");
    }
}


Console.Write("Select a question from 1 to 7 : ");
int question_number = Convert.ToInt32(Console.ReadLine());
switch (question_number)
{
    case 1:
        question_1();
        break;
    case 2:
        question_2();
        break;
    case 3:
        question_3();
        break;
    case 4:
        question_4();
        break;
    case 5:
        question_5();
        break;
    case 6:
        question_6();
        break;
    case 7:
        question_7();
        break;
    default:
        Console.WriteLine("Not a valid question number");
        break;
}





