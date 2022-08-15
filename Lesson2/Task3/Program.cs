// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Prompt(string message) 
{
    System.Console.Write(message);          //Вывод сообщения
    string readValue = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (readValue);     //Преобразование строки в целое число
    return result;                          //Возврат результата
}

int num = Prompt ("Введите число: ");

if (num > 99)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    System.Console.WriteLine ($"Третья цифра числа: {result}");
}
else
{
    System.Console.WriteLine ($"Третьей цифры числа не существует");
}