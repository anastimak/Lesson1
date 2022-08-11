//Написать программу, которая на вход принимает число N и выдает на выходе четные числа от 1 до N

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int a;
a = Prompt ("Введите число: ");
int count = 2;

while (count <= a)
{
    System.Console.Write ($"{count}, ");
    count += 2;
}