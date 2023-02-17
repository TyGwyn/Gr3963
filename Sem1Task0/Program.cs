// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были пустыми
if (inputNum != null)
{
    //Парсим введённое число
   
    //Вычисляем квадрат числа
    
    
    //Выводим данные в консоль

    Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));
}