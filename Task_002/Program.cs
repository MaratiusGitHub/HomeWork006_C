// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetPoint(double inb1, double ink1, double inb2, double ink2)
{
    double[] result = new double[2];
    result[0] = inb2 - inb1 / ink1 - ink2;
    result[1] = ink1 * result[0] + inb1;
    return result;
}

Console.WriteLine("Введите значениt b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значениt k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значениt b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значениt k2");
double k2 = double.Parse(Console.ReadLine());


Console.WriteLine($"Координаты пересечения функций = {String.Join(' ',GetPoint(b1, k1, b2, k2))}");