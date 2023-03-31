void PrintData(string line)
{
    Console.WriteLine(line);
}
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
int n = ReadData("Введите значение числа n: ");
int m = ReadData("Введите значение числа m: ");
int AccermFunc = A(n,m);
PrintData("Результат вычисления функции Аккермана для переменных n и m: " + AccermFunc);