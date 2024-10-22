// zadanie 1 //

using System.Collections.Generic;

int n = 10;
do
{
    Console.Write($"{n}\n");
    n--;
} while  (n >= 0);


// zadanie 2 //
string s;
do
{
    Console.WriteLine("Podaj haslo");
    s = Console.ReadLine();
}while (s != "koniec");

// zadanie 3 //
int j = 1;
Console.WriteLine("Liczby parzyste:");
while (j <= 100)
{
    if (j % 2 == 0)
        Console.WriteLine(j);
    j++;
}

// zadanie 4 //
for (int i = 1; i <= 15; i++)
    Console.WriteLine($"Sqaure of {i} euquals {i*i}");

// zadanie 5 i 6// 
List<int> numbers = new() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int value in numbers)
{
    if (value % 7 == 0) Console.WriteLine(value);
    break ( )
}


