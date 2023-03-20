int[,] Gen2DArrMod(int countRow, int countColumn)

{
    //Генерируем двумерный массив
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    //цикл перемещения по строке
    for (int i = 0; i < countRow; i++)
    {
        //цикл перемещения по столбцу
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = i + j;
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
int[,] Test2d = Gen2DArrMod(8, 9);
Console.WriteLine("Исходный массив");
Print2DArr(Test2d);