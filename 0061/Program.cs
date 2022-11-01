// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double FindPointX(double b1, double b2, double k1, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double FinfPointY(double b2, double k2, double x)
{
    return k2 * x + b2;
}
//Показать числа Фибоначчи
double Fibonacci(int n)
{
 int fibo = 0;
 int f1 = 1;
 int f2 = 1;
 if(n == 1 || n == 2) return 1;
    else   
    {
        for(int i = 2; i < n; i++)
        {
            fibo = f1 + f2;
            f1 = f2; 
            f2 = fibo;
        }
        return fibo;
    } 
}
Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.Write("Введите B1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите B2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");

double X = FindPointX(b1, b2, k1, k2);
double Y = FinfPointY(b2, k2, X);
if (k1 == k2)
    Console.WriteLine("Параллельные прямые");
else
    Console.WriteLine($"Координаты точки пересечения: x = {X}, y = {Y}");
    Console.WriteLine();

Console.WriteLine("Показать числа Фибоначчи");
Console.Write("Введите значение: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Fibonacci(n);40
for (int i = 1; i <= n; i++)
 Console.Write($"f({i}) = {Fibonacci(i)}");