using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i < num; i++)
            {
                sum += (i + 0.3) / (3 * i * i + 5);
            }
            Console.WriteLine(sum);
        }
    }
}
