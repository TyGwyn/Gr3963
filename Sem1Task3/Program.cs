// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число");
string? lineDay = Console.ReadLine();
if (lineDay != null)
{
   int day = int.Parse(lineDay);
   string[] dayWeek = new string [7];
   dayWeek[0]="Понедельник";
   dayWeek[1]="Вторник";
   dayWeek[2]="Среда";
   dayWeek[3]="Четверг";
   dayWeek[4]="Пятница";
   dayWeek[5]="Суббота";
   dayWeek[6]="Воскресенье";
Console.WriteLine(dayWeek[day - 1]);
}