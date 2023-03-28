int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
//Блок корректировки входных данных
{

    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    //Генерируем двумерный массив
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    //цикл перемещения по строке
    for (int i=0; i < countRow; i++)
    {
        //цикл перемещения по столбцу
        for (int j=0; j < countColumn; j++)
        {
            arr[i,j]=rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void Print2DArr(int[,] arr)
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
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int [,] Multiply2DArr(int [,]ar1, int [,]ar2)
{
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
                for (int j = 0; j < ar2.GetLength(0); ++j)
                    for (int k = 0; k < ar2.GetLength(1); ++k)
                        m[i, k] += ar1[i, j] * ar2[j, k];
            return m;
}
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int [,] First2dArr = Gen2DArr(row,column, 0, 10);
PrintData("Первый массив");
Print2DArr(First2dArr);
int rows = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int [,]Second2dArr = Gen2DArr(rows,col, 0, 10);
PrintData("Второй массив");
Print2DArr(Second2dArr);
int [,] res2DArr = Multiply2DArr(First2dArr, Second2dArr);
PrintData("Результирующий массив");
Print2DArr(res2DArr);
