void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
int[] Gen1DArr(int len, int minValue, int maxValue)

//Блок корректировки входных данных
{

    if (minValue>maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    //Генерируем одномерный массив
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i]=rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
(int posit, int negat) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negatSum = 0;

    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
        positSum+=arr[i];
        }
    else 
    {
        negatSum+= arr[i];
    }
    }
    return (positSum, negatSum);

}
int [] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
(int posit, int negat) results = NegPosSum(testArr);
PrintData("Сумма положительных чисел в массиве: ",results.posit);
PrintData("Сумма отрицательных чисел в массиве: ",results.negat);