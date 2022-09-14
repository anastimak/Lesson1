// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] MultiplicationMatrix (int [,] array1, int [,] array2)
{
    int [,] array3 = new int [array1.GetLength (0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
            {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                    array3 [i,j] += array1 [i,k] * array2 [k,j];
            }
            }
    }
    return array3;
}

System.Console.WriteLine("Матрица первая:");
int [,] array1 = FillArray (2, 2);
PrintArray (array1);
System.Console.WriteLine("Матрица вторая:");
int [,] array2 = FillArray (2, 2);
PrintArray (array2);
System.Console.WriteLine("Произведение двух матриц:");
int [,] result = MultiplicationMatrix (array1, array2);
PrintArray (result);