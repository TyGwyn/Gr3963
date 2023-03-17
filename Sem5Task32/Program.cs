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
void InvertArr(int[]arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=arr[i]*(-1);
    }
}
int[] testArr=Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InvertArr(testArr);
Print1DArr(testArr);