// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Random numSintezator = new System.Random();
//Var. 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum=rndNumber%10;

if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(secondNum);
}


