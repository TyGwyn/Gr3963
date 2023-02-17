// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3
Console.WriteLine("Введите число A");
var numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
var numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine("Число А > B");
}
else
{
   Console.WriteLine("Число B > A"); 
}
