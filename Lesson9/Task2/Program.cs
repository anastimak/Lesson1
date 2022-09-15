// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int SumPositiveNumbers (int m, int n)
{
    if (m > n) {return 0;}
    return SumPositiveNumbers (m + 1, n) + m;
}

int m = Prompt ("Введите минимальное число: ");
int n = Prompt ("Введите максимальное число: ");
SumPositiveNumbers (m, n);
System.Console.WriteLine ($"Сумма элементов равна: {SumPositiveNumbers (m, n)}");