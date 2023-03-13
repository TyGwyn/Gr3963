int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int Pow(int a, int b)
{
    int res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b-1;
    }
    return res;
}
int a = ReadData("Введите число а: ");
int b = ReadData("Введите число b: ");
PrintData("Результат возведения в степень: " + Pow(a,b));