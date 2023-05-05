// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите k1 ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите b1 ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите k2 ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите b2 ");
int y2 = int.Parse(Console.ReadLine() ?? "");

void FindCrossing();
{
    for(int i = 0; i)
}