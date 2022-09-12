// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int [,] FillArray (int i, int j) // Заполнение массива случайными числами
{
    int [,] array = new int [i, j];
    for (i = 0; i < array.GetLength(0); i++) // строка
    {
        for (j = 0; j < array.GetLength(1); j++) // столбец
        {
            array [i, j] = new Random().Next (10, 99);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++) // строка
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбец
        {
            System.Console.Write ($"{array [i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void FindingElement (int [,] array, int row, int col)
{
    if (row < array.GetLength(0))
    {
        if (col < array.GetLength(1))
        {
            System.Console.WriteLine ($"В этой позиции находится элемент: {array [row, col]}");
        }
    }
    else
    {
    System.Console.WriteLine ($"Элемент не существует");
    }
}

int [,] array = FillArray (3, 3);
int row = Prompt ("Введите номер строки: ");
int col = Prompt ("Введите номер столбца: ");
PrintArray (array);
FindingElement (array, row, col);