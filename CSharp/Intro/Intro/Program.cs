// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int sayac = 0;
for (int sayi = 2; sayi <= 100; sayi++)
{
    int kontrol = 0;

    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            kontrol = 1;
            break;
        }
    }
    if (kontrol == 0)
    {
        Console.WriteLine("{0} asaldır.", sayi);
        sayac++;
    }
}

