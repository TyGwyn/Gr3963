int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
bool Test(int a, int b, int c)
{
  return(a<=b+c);
}
bool TriangleTest(int a, int b, int c)
{
    bool res = false;
    //if((a<=b+c)&&(b<=a+c)&&(c<=a+b))
    if (Test(a,b,c)&&Test(b,a,c)&&Test(c,a,b))
    {
        res = true;
    }
    return res;
}
int a = ReadData("Введите длину отрезка а: ");
int b = ReadData("Введите длину отрезка b: ");
int c = ReadData("Введите длину отрезка c: ");
bool res = TriangleTest( a, b, c);
PrintData("Результат проверки: " + res);
