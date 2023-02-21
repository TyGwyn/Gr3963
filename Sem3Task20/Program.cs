int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Введите координату x точки А:");
int y1 = ReadData("Введите координату y точки А:");
int x2 = ReadData("Введите координату x точки B:");
int y2 = ReadData("Введите координату y точки B:");

double res = CalcLen2D(x1, x2, y1, y2);

PrintData("Расстояние между точками A и B: ", res);
