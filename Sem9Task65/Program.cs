int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
string RecMN(int M, int N)
{
    string res = String.Empty;

    if (M >= N)
    {
        res = N.ToString();
    }
    else
    {
        res = res + M + " " + RecMN(M + 1, N);
    }
    return res;
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int M = ReadData("Введите значение M: ");
int N = ReadData("Введите значение N: ");
string res = RecMN(M,N);
PrintData("Результат" + res);