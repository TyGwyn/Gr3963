// See https://aka.ms/new-console-template for more information
//Найти максимальное
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число A");
var numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
var numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
var numC = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine("Число А > B");
    if (numA > numC)
    {
        Console.WriteLine("Число A - максимальное");
    }
    else
    {
        Console.WriteLine("Число C - максимальное");
    }
}
else
    {
        if (numB > numC)
    {
        Console.WriteLine("Число B - максимальное");
    }
    else
    {
        Console.WriteLine("Число C - максимальное");
    }

    }