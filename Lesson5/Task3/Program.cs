// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

void generaitArray (double [] array)       //Генерация массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().NextDouble();
    }
}

void printArray (double [] array)          //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write (array [i] + " ");
    }
}

double findMax (double [] array)          //Поиск максимального элемента
{
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double findMin (double [] array)          //Поиск минимального элемента
{
    double min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double [] array = new double [4];
generaitArray (array);
printArray (array);
System.Console.WriteLine ("");
findMax (array);
findMin (array);
System.Console.WriteLine ($"Максимальный: {findMax(array)}, минимальный: {findMin(array)}, разница между ними равна: {findMax (array) - findMin(array)} ");