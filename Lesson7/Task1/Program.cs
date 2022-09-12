// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

double [,] FillArray (int i, int j) // Заполнение массива случайными числами
{
    double [,] array = new double [i, j];
    for (i = 0; i < array.GetLength(0); i++) // строка
    {
        for (j = 0; j < array.GetLength(1); j++) // столбец
        {
            array [i, j] = new Random().Next (-100, 100) / 10;
        }
    }
    return array;
}

void PrintArray (double [,] array)
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

double [,] array = FillArray (Prompt ("Введите кол-во строк: "), Prompt ("Введите кол-во столбцов: "));
PrintArray (array);