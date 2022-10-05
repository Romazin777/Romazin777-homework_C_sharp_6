// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1 для уравнения y = k1 * x + b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1 для уравнения y = k1 * x + b1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2 для уравнения y = k2 * x + b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2 для уравнения y = k2 * x + b2: ");
double k2 = int.Parse(Console.ReadLine()!);
double y1 = WantedPointY(k1, b1);
double y2 = WantedPointY(k2, b2);
Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({y1}; {y2})");

double WantedPointY(double k, double b)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k * x + b;
    return y;
}
