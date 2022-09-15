// Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

void FindPositiveNumbers (int m, int n)
{
    if (m > n) {return;}
    if (m % 2 == 0)
    {
        System.Console.WriteLine ($"{m} ");
    }
    FindPositiveNumbers (m + 1, n);
}


int m = Prompt ("Введите минимальное число: ");
int n = Prompt ("Введите максимальное число: ");
FindPositiveNumbers (m, n);