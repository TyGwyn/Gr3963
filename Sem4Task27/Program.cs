int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int DigitSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        res+= num%10;
        num = num/10;
    }
    return res;
}
int num = ReadData("Введите число: ");
PrintData ("Сумма цифр в числе: " + DigitSum(num));
