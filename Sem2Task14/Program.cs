// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Num = int.Parse(Console.ReadLine()??"0");
//bool per = ((Num%23 == 0) && (Num%7 == 0));
if ((Num%23 == 0) && (Num%7 == 0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}