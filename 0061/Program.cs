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
double Fibonacci(double number)
{
    double f1 = 1;
    double f2 = 1;
    double result = 0;
    if (number == 1 || number == 2)
        return 1;
    else
    {
        for (double i = 2; i < number; i++)
        {
            result = f1 + f2;
            f1 = f2;
            f2 = result;
        }
        return result;
    }
}
// Написать программу копирования массива
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] CopyArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}
// Написать программу масштабирования фигуры
string Scaling2(double x1, double y1, double x2, double y2,
                double x3, double y3, double x4, double y4,
                double kof)
{
    x1 = x1 * kof; y1 = y1 * kof; x2 = x2 * kof; y2 = y2 * kof;
    x3 = x3 * kof; y3 = y3 * kof; x4 = x4 * kof; y4 = y4 * kof;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
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
double num = Convert.ToInt32(Console.ReadLine());
Fibonacci(num);
for (double i = 1; i <= num; i++)
    Console.WriteLine($"{i} => {Fibonacci(i)}");
Console.WriteLine();

Console.WriteLine("Написать программу копирования массива");
int[] arr = CreateArray(10, 1, 10);
PrintArray(arr);
int[] newarr = CopyArray(arr);
PrintArray(newarr);
Console.WriteLine();

Console.WriteLine("Написать программу масштабирования фигуры");
Console.WriteLine("Введите значение точек");
Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("x3: ");
double x3 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("y3: ");
double y3 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("x4: ");
double x4 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("y4: ");
double y4 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите коэффициент масштабирования: ");
double kof = double.Parse(Console.ReadLine() ?? "0");
Console.Write($"Значение точек при коэффициенте {kof} будет {Scaling2(x1, y1, x2, y2, x3, y3, x4, y4, kof)}");