// Написать программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string readValue = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (readValue);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int num = Prompt ("Введите трехзначное число: "); 

if (99 < num && num < 1000)
{
    num = num / 10 % 10;
    System.Console.WriteLine ($"Вторая цифра числа: {num}");
}
else
{
    System.Console.WriteLine ($"Число не трехзначное");
}

