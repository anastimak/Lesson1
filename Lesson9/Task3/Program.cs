// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int Ackermann (int m, int n)
{
    if (m == 0) {return n + 1;}
    if (m > 0 && n == 0)
    {
        return Ackermann (m - 1, 1);
    }
    return Ackermann (m - 1, Ackermann (m, n - 1));
}

int m = Prompt ("Введите первое число: ");
int n = Prompt ("Введите второе число: ");
System.Console.WriteLine (Ackermann (m, n));