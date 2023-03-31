int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void LineGenRec(int num)
{
    Console.Write(num + " ");
    if (num == 1)
    {

    }
    else
    {
        LineGenRec(num - 1);
    }
}
int number = ReadData("Введите число N: ");
LineGenRec(number);