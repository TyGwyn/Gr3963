//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введите координату x точки А:");
int y1 = ReadData("Введите координату y точки А:");
int z1 = ReadData("Введите координату z точки А:");
int x2 = ReadData("Введите координату x точки B:");
int y2 = ReadData("Введите координату y точки B:");
int z2 = ReadData("Введите координату z точки А:");

double res = CalcLen3D(x1, x2, y1, y2, z1,z2);

PrintData("Расстояние между точками A и B: ", res);