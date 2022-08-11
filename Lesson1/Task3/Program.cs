//Написать программу, которая на вход принимает число и выдает, является ли число четным

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int a;
a = Prompt ("Введите число: ");

if ((a % 2) == 0) 
{
    System.Console.WriteLine ($"Число четное");
}
else 
{
   System.Console.WriteLine ($"Число нечетное");
}
