// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var numN = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= numN; i = i + 2)
{
    Console.Write(i + " ");
}