// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int a = Prompt ("Введите первое число: ");
int b = Prompt ("Введите второе число: ");

int degreeNumber (int a, int b)
{
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
}

int number = degreeNumber (a, b);
System.Console.WriteLine ($"Число {a}, возведенное в степень числа {b}, равно: {number}");