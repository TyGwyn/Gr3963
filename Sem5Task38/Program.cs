void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
double[] Gen1DArr(int len)
{
    Random rnd = new Random();
    double[] arr = new double [len];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i]= rnd.NextDouble();
    }
    return arr;
}
double MaxMin(double[]arr)
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i=0; i < arr.Length; i++)
    {
        if(arr[i]>max) 
        {
            max = arr[i];
        }
        if(arr[i]<max)
        {
            min = arr[i];
        }
        res = max-min; 
    }
    return res;
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
double []testArr = Gen1DArr(20);
Print1DArr(testArr);
double res = MaxMin(testArr);
PrintData("Результат вычисления разницы между максимальным и минимальным элементами массива, состоящего из дробных чисел: " + res);
