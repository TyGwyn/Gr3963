//Метод, позволяющий выдать сообщение пользователю и получать от него входящие данные
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
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
//метод, возводящий в квадрат числа заданного 2d-массива с чётными индексами
void Update2DArr (int [,]arr)
{
    for (int i=0; i<arr.GetLength(0); i+=2)
    {
        for (int j=0;j<arr.GetLength(1); j+=2)
        {
            //универсальное решение
            //if ((i%2==0) &&(j%2==0))
            {
            arr[i,j]*=arr[i,j];
            //arr[i,j]=Math.Pow(arr[i,j], 2);
            }
        }
    }
}
int row = ReadData("Введите количество строк: ");
//получение от пользователя значения количества столбцов
int column = ReadData("Введите количество строк: ");
int[,]Test2dArr = Gen2DArr(row,column,1,99);
Print2DArr(Test2dArr);
Update2DArr(Test2dArr);
Print2DArr(Test2dArr);