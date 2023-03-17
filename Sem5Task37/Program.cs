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
int[] ConvertArr(int []arr)
{
    int len = arr.Length/2;
    
    if (arr.Length%2==1)
    {
        len = len + 1;
    }
    int []bufArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        bufArr[i] = arr[i] * arr[arr.Length-1-i];
    }
    return bufArr;
}
int[]testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
Print1DArr(ConvertArr(testArr));
