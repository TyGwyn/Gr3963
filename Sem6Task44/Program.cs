int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
string FibNum(int num)
{
    string res = "0 1";
    int first = 0; int last = 1;
    for (int i = 2; i < num; i++)
    {
        res = res + " " + (first + last).ToString();
        (first,last) = (last, first + last);
    }
    return res;
}
int num = ReadData("Введите количество элементов чисел Фиббоначи: ");
PrintData(FibNum(num));