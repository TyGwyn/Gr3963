//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
int[] Gen1DArr(int len, int min, int max)
//Блок корректировки входных данных
{

    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    //Генерируем одномерный массив
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i]=rnd.Next(min, max + 1);
    }
    return arr;
}
int CountSumInRange(int []arr)
{
    
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i%2==1)
        {
            res+=arr[i];
        }
    }
    return res; 
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int []testArr=Gen1DArr(12, -9, 9);
Print1DArr(testArr);
int res = CountSumInRange(testArr);
PrintData("Результат подсчёта суммы чисел c нечётным индексом в массиве: " + res);