// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string? lineN = Console.ReadLine();
if (lineN != null)
{
   int n = int.Parse(lineN);
   int res = n % 10;
   Console.WriteLine("Последняя цифра:" + res);
}