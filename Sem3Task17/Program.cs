int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintQuterTest(int x, int y)
{
    if (x>0 && y>0) Console.WriteLine("Точка в 1-й четверти");
    if (x>0 && y<0) Console.WriteLine("Точка в 2-й четверти");
    if (x<0 && y<0) Console.WriteLine("Точка в 3-й четверти");
    if (x<0 && y>0) Console.WriteLine("Точка в 4-й четверти");
} 

int coordX = ReadData("Введите координату X: ");

int coordY = ReadData("Введите координату Y: ");

PrintQuterTest(coordX,coordY);