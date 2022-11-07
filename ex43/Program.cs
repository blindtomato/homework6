//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2); //координата x
    result[1] = k1 * result[0] + b1;  //координата y
    return result;
}

Console.WriteLine("Введите угловой коэффициент k1 первой функции");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент b1 первой функции");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент k2 второй функции");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент b2 второй функции");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются");
else 
{
    double[] coord = FindIntersectionPoint(k1, b1, k2, b2);
    Console.WriteLine($"Координата X точки пересечения прямых {coord[0]}");
    Console.WriteLine($"Координата Y точки пересечения прямых {coord[1]}");
}
