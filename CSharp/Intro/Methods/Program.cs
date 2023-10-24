// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Add()
{
    Console.WriteLine("Added");
}

static int Add2(int number1, int number2=30) // dafault parametreler her zaman metodların sonunda tanımlanır.
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int number1,int number2)
{
    return number1 * number2;
}
static int Multiply(int number1,int number2,int number3) // overloading
{
    return number1 * number2 * number3;
}

static int Add4(params int[] numbers)
{
    return numbers.Sum();
}

Add();
Add2(20);
Add2(30,12);

int number1 = 20;
int number2 = 100;
var result = Add3(ref number1, number2); // out
Console.WriteLine(result);
Console.WriteLine(Add4(1,2,3,4,5,6,7));