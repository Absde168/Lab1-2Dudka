Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
double f = 1 / Math.Tan(y / x);
double r = Math.Sqrt(x*x+y*y);
Console.WriteLine($"r = {r:F2}");
Console.WriteLine($"f = {f:F2}");
