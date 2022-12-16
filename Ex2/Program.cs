Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.Write("Координаты точки пересечения: (" + x + "; " + y + ")");
}