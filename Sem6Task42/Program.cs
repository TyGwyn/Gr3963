int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
string DecToBin(int num)
{
    string res = string.Empty;
    while (num>0)
    {
        res = num%2 + res;
        num = num/2;
    }
    return res;
}
int num = ReadData("Введите число: ");
string res = DecToBin(num);
PrintData("Результат действия: " + res);