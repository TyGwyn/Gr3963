void PrintData(string line)
{
    Console.WriteLine(line);
}
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
string LineGenRec(int N)
{
    if (N == 1)
    {
        return "1";
    }
    else
    {
        return LineGenRec(N-1) + " " + N;
    }
}

int N = ReadData("Введите число N: ");
string res = LineGenRec(N);
PrintData("Положительные числа от 1 до N: "+ res);