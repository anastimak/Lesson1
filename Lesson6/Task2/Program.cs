// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int k1 = Prompt ("Введите k1: ");
int b1 = Prompt ("Введите b1: ");
int k2 = Prompt ("Введите k2: ");
int b2 = Prompt ("Введите b2: ");

void intersectiounOfLines (int k1, int b1, int k2, int b2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine ($"Точка пересечения: {x}; {y}");
}

intersectiounOfLines (k1, b1, k2, b2);