// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string? lineN = Console.ReadLine();
if(lineN != null)
{
    int n = int.Parse(lineN);
    string res = String.Empty;
    int negN = n * (-1);
    while (negN<=n)
    {
        res = res + negN + "_";
        negN++;
    }
    res = res + n;
Console.WriteLine(res);    
}
