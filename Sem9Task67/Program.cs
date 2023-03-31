int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int RecSumDig (int num)
{
    if (num == 0)
    return 0;
    else
    {
    return (num%10 + RecSumDig(num/10));
    }
}
int num = ReadData("Введите число: ");
int res = RecSumDig(num);
PrintData("Результат сложения элементов числа: "+res);