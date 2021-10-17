using System;

namespace Task06
{
    class Program
    {
        public static double Faktorial(double k)
        {
            double faktorial = 1.0;
            for (double i = 1.0; i < k + 1; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        public static double Method2(double x)
        {
            double s = 1.0;
            int i = 2;
            int k = 1;
            while (Faktorial(k) <= Double.MaxValue)
            {
                s += Convert.ToDouble(Convert.ToInt32(x) ^ i) / Faktorial(k);
                i += 1;
                k += 1;
            }
            return s;
        }
        public static double Method1(double x)
        {
            double s = 0.0;
            int i = 3;
            int j = 4;
            int k = 4;
            while (Faktorial(k) <= Double.MaxValue)
            {
                s += Convert.ToDouble(Convert.ToInt32(x) ^ 2) - Convert.ToDouble(((2 ^ i) * ((Convert.ToInt32(x) ^ j)))) / Faktorial(k);
                i += 2;
                j += 2;
                k += 2;
            }
            return s;
        }
        static void Main(string[] args)
        {
            double x = 0.0;
            while (!(double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Введите Х (вещественное число):  ");
            }
            Console.WriteLine(Method1(x));
            Console.WriteLine(Method2(x));
        }

    }
}
