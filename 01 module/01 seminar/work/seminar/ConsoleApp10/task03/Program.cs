using System;

namespace task03
{
    class Program
    {
        public static double Method(double x)
        {
            double g;
            if (x <= 0.5) g = Math.Sin(Math.PI / 2);
            else g = Math.Sin((Math.PI * (x - 1)) / 2); ;
            return g;
        }
        static void Main(string[] args)
        {
            double x;
            if (!(double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Вы ввели некорректное значение. Попробуйте еще раз.");
            }

            Console.WriteLine(Method(x));

        }

    }
}
