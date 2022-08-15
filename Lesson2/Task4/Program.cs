// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int Prompt(string message) 
{
    System.Console.Write(message);          //Вывод сообщения
    string readValue = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (readValue);     //Преобразование строки в целое число
    return result;                          //Возврат результата
}

int num = Prompt ("Введите число, обозначающее день недели: ");

if (num <= 5)
{
    System.Console.WriteLine ($"Этот день не выходной");
}
else if (num >=6 && num <=7)
{
    System.Console.WriteLine ($"Этот день выходной");
}
else
{
    System.Console.WriteLine ($"Такого дня недели не существует");
}
