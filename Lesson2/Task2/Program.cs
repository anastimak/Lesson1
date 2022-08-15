// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int Prompt(string message) 
{
    System.Console.Write(message);          //Вывод сообщения
    string readValue = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (readValue);     //Преобразование строки в целое число
    return result;                          //Возврат результата
}

int num = new Random().Next(99, 1000);
System.Console.WriteLine(num);

int numSecond = 10 * (num / 100 % 10) + (num % 10); 
System.Console.WriteLine(numSecond);