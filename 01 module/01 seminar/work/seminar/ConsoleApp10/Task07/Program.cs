using System;

namespace Task07
{
    class Program
    {
        public static void Method(int x, int y, out int a, out int b)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            a = 0;
            b = 0;
            for (int i = Math.Min(x, y); i > 0; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    b = i;
                    break;
                }
            }

            for (int i = Math.Max(x, y); true; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    a = i;
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int x;
            int y;
            int nok;
            int nod;
            Console.WriteLine("Введите два целых положительных числа  в столбик: ");
            var x0 = Console.ReadLine();
            var y0 = Console.ReadLine();
            while ((!(int.TryParse(x0, out x))) || (!(int.TryParse(y0, out y)) || x <= 0 || y <= 0))
            {
                Console.WriteLine("Вы ввели неверные значения");
            }
            Method(x, y, out nok, out nod);
            Console.WriteLine(nok);
            Console.WriteLine(nod);

        }

    }
}
