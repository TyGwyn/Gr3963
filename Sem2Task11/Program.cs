// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = new Random().Next(100,1000);
Console.WriteLine(num);
int lastDigit = num%10;
int firstDigit = num/100;
num = firstDigit * 10 + lastDigit;
Console.WriteLine(num);