// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

void generaitArray (int [] array)       //Генерация массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(99, 1000);
    }
}

void printArray (int [] array)          //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write (array [i] + " ");
    }
}

int evenNumbers (int [] array)          //Подсчет четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int [] array = new int [10];
generaitArray (array);
printArray (array);
System.Console.Write ("");
evenNumbers (array);
System.Console.WriteLine ($"- в данном массиве количество четных чисел равно: {evenNumbers(array)}");