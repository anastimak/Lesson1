// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array [i] = new Random().Next(0, 100);
    }
}

void printArray (int [] array)          //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write (array [i] + " ");
    }
}

int sumNumbersOddIndex (int [] array)          //Подсчет суммы чисел на нечетных позициях
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result = result + array [i];
    }
    return result;
}

int [] array = new int [5];
generaitArray (array);
printArray (array);
System.Console.Write ("");
sumNumbersOddIndex (array);
System.Console.WriteLine ($"- сумма чисел, стоящих на нечетных позициях, равна: {sumNumbersOddIndex(array)}");