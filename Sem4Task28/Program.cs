using System.Numerics;
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++) 
    {
        res *= i;
    }
    return res;
}
int num = ReadData("Введите число: ");
PrintData("Значение факториала: " + FactorCalc(num));