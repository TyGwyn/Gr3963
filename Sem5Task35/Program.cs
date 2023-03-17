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
int CountElemInRange(int []arr, int minValue, int maxValue)
{
    if (minValue>maxValue)
    {
        int buf2 = minValue;
        minValue = maxValue;
        maxValue = buf2;
    }
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if((arr[i]>minValue)&&(arr[i]<maxValue))
        {
            res++ ;
        }
    }
    return res; 
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
int []testArr=Gen1DArr(123, -123, 123);
Print1DArr(testArr);
int minValue=ReadData("Введите значение для нижней границы: ");
int maxValue=ReadData("Введите значение для верхней границы: ");
int res = CountElemInRange(testArr, minValue, maxValue);
PrintData("Результат подсчёта: " + res);

