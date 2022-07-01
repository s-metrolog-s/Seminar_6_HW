// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем

Console.Clear();
Random rand = new Random();
Console.WriteLine("*******************************************");
Console.WriteLine("Даные две прямые, заданные уравнениями:");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("*******************************************");
Console.WriteLine("Введите значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*******************************************");
Console.WriteLine("Вычисляем точку пересечения прямых...");
Console.WriteLine("*******************************************");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"в точке [{Math.Round(x, 2)} : {Math.Round(y, 2)}]");
