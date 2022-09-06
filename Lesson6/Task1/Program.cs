// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int [] inputArray (int number)     
{
    int [] array = new int [number];
    int i = 0;
    while (i < number)
    {
        System.Console.WriteLine ("Введите число: ");
        array [i] = int.Parse (Console.ReadLine());
        i++;
    }
    return array;
}

void printArray (int [] array)          //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write (array [i] + " ");
    }
}

int countPositiveNum (int [] array)    //Счетчик положительных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    }
    return count;
}

int [] array = inputArray (Prompt ("Укажите количество цифр, которые хотите ввести: "));
printArray (array);
System.Console.Write ("");
System.Console.WriteLine ($"Количество введенных чисел после 0 равно: {countPositiveNum(array)}");