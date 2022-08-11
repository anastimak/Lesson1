//Написать программу, которая на вход принимает три числа и выдает максимальное из этих чисел

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int a;
int b;
int c;
a = Prompt ("Введите первое число: ");
b = Prompt ("Введите второе число: ");
c = Prompt ("Введите третье число: ");

int max = a;
if (max < b) {max = b;}
if (max < c) {max = c;}

System.Console.WriteLine ($"Максимальное число - {max}");