// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

void Pallindrom (int num)
{
    if (num < 100000 && num > 9999)
    {
        if (num / 10000 != num % 10)
        {
            System.Console.WriteLine("Число не является палиндромом");
        }
        else
        {
            if (num / 1000 - (num / 10000 * 10) == num / 10 % 10)
            {
                System.Console.WriteLine("Число является палиндромом");
            }
        }
    }
    else
    {
        System.Console.WriteLine ("Число не пятизначное");
    }
}

int num = Prompt ("Введите пятизначное число: ");
Pallindrom (num);