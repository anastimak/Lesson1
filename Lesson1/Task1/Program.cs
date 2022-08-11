//Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int a;
int b;
a = Prompt ("Введите первое число: ");
b = Prompt ("Введите второе число: ");

if (a > b)
{
    System.Console.WriteLine ($"Максимальное число - {a}, минимальное число - {b}");
}
else
{
    System.Console.WriteLine ($"Максимальное число - {b}, минимальное число - {a}");
}