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
    Random rnd = new Random();
    int[] arr = new int [len];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i]= rnd.Next(min, max + 1);
    }
    return arr;
}
void SwapArray(int []arr)
{
    int bufElem = 0;
    for (int i=0; i < arr.Length/2; i++)
    {
        bufElem = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = bufElem;
    }
}
int [] SwapNewArray(int[] arr)
{
    int[] outArr = new int [arr.Length];
    for (int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}
int[] testArray = Gen1DArr(123,10,100);
Print1DArr(testArray);
SwapArray(testArray);
Print1DArr(testArray);

