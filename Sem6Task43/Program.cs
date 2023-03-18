int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
string LineCross(int k1, int k2, int b1, int b2)
{
    string res = "Отрезки с заданными параметрами не имеют точек пересечения!";
    if (k1!=k2)
    {
        int x = (-b1+b2)/(-k1+k2);
        int y = (k2 * x) + b2;
        res = "Значение координаты X: " + (x).ToString() + " и " + "значение координаты Y:" + (y).ToString();
    }
    return res; 
}
int k1 = ReadData("Введите значение переменной k1: ");
int k2 = ReadData("Введите значение переменной k2: ");
int b1 = ReadData("Введите значение переменной b1: ");
int b2 = ReadData("Введите значение переменной b2: ");
String res = LineCross(k1,k2,b1,b2);
PrintData("Координаты точки пересечения отрезков: " + res);