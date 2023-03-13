//Напишите программу, принимающую на вход число А, и выдающую сумму от 1-го до А.
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int SumSimple(int numA)
{
    int sum = 0;

    for (int i = 0; i <= numA; i++)
    {
        sum += i;
    }

    return sum;
}
int numberA=ReadData("Введите число A: ");
int res1 = SumSimple(numberA);
PrintData ("Сумма чисел от 1-го до А равна: "+ res1);

