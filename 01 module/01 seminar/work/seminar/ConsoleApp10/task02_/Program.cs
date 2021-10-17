using System;

public partial class Program
{
    public static double MyMethod2(double x, double y)
    {
        double G;
        if (x < y && x > 0)
        {
            G = x + Math.Sin(y);
        }
        else if (x > y && x < 0)
        {
            G = y - Math.Cos(x);
        }
        else
        {
            G = 0.5 * x * y;
        }
        return G;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Ведите Х (вещественное число)");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ведите Y (вещественное число)");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("G = F(X,Y)=" + MyMethod2(x, y));
    }
}
