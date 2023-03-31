void PrintData(string line)
{
    Console.WriteLine(line);
}
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
int RecSumDigMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
        return m + RecSumDigMN(m + 1, n);
}
int M = ReadData("Введите значение M: ");
int N = ReadData("Введите значение N: ");
int res = RecSumDigMN(M, N);
PrintData("Сумма чисел от M до N: " + res);