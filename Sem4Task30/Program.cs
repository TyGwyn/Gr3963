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
{
    int[] arr = new int[len];
    for (int i=0; i < len; i++)
    {
        arr[i]=new Random().Next(min, max + 1);
    }
    return arr;
}
Print1DArr (Gen1DArr(8, 0, 1));
