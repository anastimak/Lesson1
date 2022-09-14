// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            array [i, j] = new Random().Next (0, 10);
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

int [,] BubbleSortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - k; j++)
            {
                if (array [i,j] < array [i, j+1])
                {
                    int temp = array [i,j];
                    array [i,j] = array [i, j+1];
                    array [i, j+1] = temp;
                }
            }
        }
    }
    return array;
}

int [,] array = FillArray (4, 4);
PrintArray (array);
System.Console.WriteLine ("Отсортированный массив:");
int [,] newarray = BubbleSortArray (array);
PrintArray (newarray);