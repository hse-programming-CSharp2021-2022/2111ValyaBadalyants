using System;

namespace Task16
{
    struct Point
    {
        public double x, y;
    }



    class Program
    {
        static bool Inhere(Point point)
        {
            // Думаем, что центр круга в начале коодинат, т.к. не указано в условии.
            if (Math.Sqrt(point.x * point.x + point.y * point.y) <= 2)
            {
                double tg = point.y / point.x;

                return tg < 1 && point.x >= 0;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Point point = new Point { x = 0.5, y = -0.5 }; // Initialize here.

            Console.WriteLine(Inhere(point));

        }
    }
}
