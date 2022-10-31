// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double FindPointX(double b1, double b2, double k1, double k2)
{
    return (b2 - b1) / (k2 - k1);
}
double FinfPointY(double b2, double k2, double x)
{
    return k2 * x + b2;
}

Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.Write("Введите B1: ");
double b1=double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите B2: ");
double b2=double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k1: ");
double k1=double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k2: ");
double k2=double.Parse(Console.ReadLine() ?? "0");

double X = FindPointX(b1,b2,k1,k2);
double Y=FinfPointY(b2,k2,X);
if(k1==k2)
Console.WriteLine("Параллельные прямые");
else
Console.WriteLine($"Координаты точки пересечения: x = {X}, y = {Y}");
