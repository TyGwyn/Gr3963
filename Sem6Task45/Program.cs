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
int[] CopyArrayStandartTools(int [] inputArr)
{
    int []outArr = new int[inputArr.Length];
    inputArr.CopyTo(outArr,0);
    return outArr;
}
int []testArr = Gen1DArr(40,1,50);
Print1DArr(testArr);
int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArr(testArrNew);
