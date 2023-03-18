int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int CountNum(int numM)
{
    int res = 0;
    for (int i = 0; i < numM; i++)
    {
        if(ReadData(" ")>0)
        {
            res++;
        }
    }
    return res;
}
int numM = ReadData("Введите лимит принимаемых чисел: ");
int res = CountNum(numM);
PrintData("Введённых чисел больше 0: " + res);