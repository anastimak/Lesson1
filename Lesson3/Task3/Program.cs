// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

void CubNumbers (int num)
{
    int i = 0;
    while (i <= num)
    {
        System.Console.Write (i*i*i + " ");
        i++;
    }
}

int num = Prompt ("Введите число: ");
CubNumbers (num);
System.Console.WriteLine ($"- таблица кубов чисел от 1 до {num}");