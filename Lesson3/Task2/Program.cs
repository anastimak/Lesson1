// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message) 
{
    System.Console.Write(message);      //Вывод сообщения
    string value = Console.ReadLine();  //Считывание с консоли строки
    int result = int.Parse (value);     //Преобразование строки в целое число
    return result;                      //Возврат результата
}

int xA = Prompt ("Введите первую координату точки А: ");
int yA = Prompt ("Введите вторую координату точки А: ");
int zA = Prompt ("Введите третью координату точки А: ");

int xB = Prompt ("Введите первую координату точки B: ");
int yB = Prompt ("Введите вторую координату точки B: ");
int zB = Prompt ("Введите третью координату точки B: ");

double result = Math.Sqrt((xA - xB)*(xA - xB)+(yA - yB)*(yA - yB)+(zA - zB)*(zA - zB));
System.Console.WriteLine (result);