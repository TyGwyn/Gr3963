int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
string LineBuilder(int num, int pow)
{
    string res = string.Empty;
    for (int i=1; i<=num; i++)
    {
        res = res + Math.Pow(i,pow) + " ";
    }
    return res;
}
int N = ReadData("Введите конечное число");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));
