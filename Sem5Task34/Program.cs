//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
int CountElemInRange(int []arr)
{
    
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        {
            res++ ;
        }
    }
    return res; 
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int []testArr=Gen1DArr(12, 100, 999);
Print1DArr(testArr);
int res = CountElemInRange(testArr);
PrintData("Результат подсчёта чётных чисел в массиве: " + res);