// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void AverageNumberColumn (int [,] array)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        result = result / array.GetLength(0);
        System.Console.WriteLine ($"Среднее арифметическое {j+1} столбца: {Math.Round(result, 2)}\t");
    }
}

int [,] array = FillArray (3, 3);
PrintArray (array);
AverageNumberColumn (array);