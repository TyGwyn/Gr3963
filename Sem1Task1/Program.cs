// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите 1-ое число: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите 2-ое число: ");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if ((num2 * num2) == num1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}