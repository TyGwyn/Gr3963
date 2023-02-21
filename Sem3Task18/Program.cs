int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintAnswer(int qrt)
{
    if (qrt > 0 && qrt < 5)
    {
        if (qrt == 1) Console.WriteLine("x>0 , y>0");
        if (qrt == 2) Console.WriteLine("x>0, y<0");
        if (qrt == 3) Console.WriteLine("x<0, y<0");
        if (qrt == 4) Console.WriteLine("x<0, y>0");
    }
    else 
    {
        Console.WriteLine("Неверное обозначение четверти");
    }
}
int qrt = ReadData("Введите номер четверти: ");
PrintAnswer(qrt);
