int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
//Блок корректировки входных данных
{

    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    //Генерируем двумерный массив
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    //цикл перемещения по строке
    for (int i = 0; i < countRow; i++)
    {
        //цикл перемещения по столбцу
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void Print2DArr(int[,] arr)
{
    //Добавление цвета для шрифта вывода в консоль
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Gray };
    for (int i = 0; i < arr.GetLength(0); i++)
    //добавили прохождение цикла по заданному количеству строк
    {
        ////добавили прохождение цикла по заданному количеству столбцов
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //рандомайзер цвета
            Console.ForegroundColor = col[new Random().Next(0, 8)];
            Console.Write(arr[i, j] + " ");
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
int[] BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}
void Sort2DArr(int[,] arr)
{
    int[] row = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            row[j] = arr[i, j];
        }
        BubbleSort(row);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
        
    }
}
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int [,]Test2dArr = Gen2DArr(row,column, 0, 100);
PrintData("Исходный массив");
Print2DArr(Test2dArr);
PrintData("Отсортированный массив");
Sort2DArr(Test2dArr);
Print2DArr(Test2dArr);