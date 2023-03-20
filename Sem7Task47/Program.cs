int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void Print2DArrDoub(double[,] arr)
{
    //Добавление цвета для шрифта вывода в консоль
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.Yellow,ConsoleColor.White,ConsoleColor.Gray};
    for (int i = 0; i < arr.GetLength(0); i++)
    //добавили прохождение цикла по заданному количеству строк
    {
        ////добавили прохождение цикла по заданному количеству столбцов
        for(int j=0;j<arr.GetLength(1); j++)
        {
            //рандомайзер цвета
            Console.ForegroundColor = col[new Random().Next(0,8)];
            Console.Write(arr[i,j]+ " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
double[,] Gen2DArrDoub(int rows, int columns, int min, int max)
{
    //Блок корректировки входных данных
    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    double[,] arr = new double [rows,columns];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]= rnd.Next(min,max+1)+rnd.NextDouble();
        } 
    }
    return arr;
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
//получение от пользователя значения количества строк
int row = ReadData("Введите количество строк: ");
//получение от пользователя значения количества столбцов
int column = ReadData("Введите количество строк: ");
double[,] Test2dArrDoub = Gen2DArrDoub(row, column,10,99);
PrintData("Сгенерированный 2D массив наполненный случайными вещественными числами: ");
Print2DArrDoub(Test2dArrDoub);
