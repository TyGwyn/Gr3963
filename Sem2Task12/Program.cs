// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int fstNum  = int.Parse(Console.ReadLine()??"0");
int scdNum = Convert.ToInt32(Console.ReadLine());
if (fstNum%scdNum == 0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine("Не кратно, остаток" + fstNum%scdNum);
}