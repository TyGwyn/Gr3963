
void squareTest(int numA, int numB)
{
    if(numA == Math.Pow(numB,2))
    {
        Console.WriteLine(numA + " является квадратом " + numB);
    }
    else
    {
        Console.WriteLine(numA + " не является квадратом " + numB);
    }
}    
Console.WriteLine("Введите 1-ое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите 2-ое число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
squareTest(numA, numB);
squareTest(numB, numA);
