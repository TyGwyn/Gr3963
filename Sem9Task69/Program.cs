int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int RecPow(int a, int b)
{
    if (b<=1)
    return a;
    else
    {
        return a * RecPow(a,b-1);
    }
}
int a = ReadData("Введите значение a (числа возводимого в степень): ");
int b = ReadData("Введите значение b (значение степени): ");
int res = RecPow(a,b);
PrintData("Результат возведения в степень: " + res);

