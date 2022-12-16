using Common;
/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine("y1 = k1 * x + b1 \ny2 = k2 * x + b2");
double k1 = InputData.DoubleData("k1 = ");
double b1 = InputData.DoubleData("b1 = ");
double k2 = InputData.DoubleData("k2 = ");
double b2 = InputData.DoubleData("b2 = ");
(double xi, double yi, bool find) = FindingAnIntersectionPoint(k1, b1, k2, b2);
if (find)
{
    Console.WriteLine($"Точка пересечения: ({xi}; {yi})");
}

(double xPoint, double yPoint, bool itsFind) FindingAnIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double xPoint = 0, yPoint = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Точки пересечения нет.");
        return (0, 0, false);
    }
    xPoint = (b2 - b1) / (k1 - k2);
    yPoint = k1 * xPoint + b1;
    return (xPoint, yPoint, true);
}