// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

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
        array [i] = new Random().Next(0, 101);
    }
}

void printArray (int [] array)          //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write (array [i] + " ");
    }
}

int FindSecondMax (int [] array)        //Поиск второго максимального
{
    int max1 = 0;
    int max2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }
    }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max2 && array[j] < max1)
        {
            max2 = array[j];
        }

    }
    return max2;
}

int [] array = new int [8];
generaitArray (array);
printArray (array);
System.Console.Write ("");
FindSecondMax (array);
System.Console.WriteLine ($"Второе максимальное число в массиве: {FindSecondMax(array)}");