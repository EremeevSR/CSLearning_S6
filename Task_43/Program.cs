// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

// В соответствии с примером ввода/вывода коэффициенты
// k и b прямых - целочисленные переменные, а координаты
// точки пересечения - вещественные.

int k1, b1, k2, b2;
double x, y;

Console.Write("Введите коэффициенты первой прямой y = kx + b\nk1 = ");
k1 = int.Parse(Console.ReadLine());
Console.Write("b1 = ");
b1 = int.Parse(Console.ReadLine());
Console.Write("Введите коэффициенты второй прямой y = kx + b\nk2 = ");
k2 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
b2 = int.Parse(Console.ReadLine());

x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
y = (double)k1 * x + (double)b1;
// Без явного преобразования к типу double работало неправильно.

Console.WriteLine($"Точка пересечения прямых ({x};{y})");