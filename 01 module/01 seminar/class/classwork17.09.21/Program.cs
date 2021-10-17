using System;

namespace classwork17._09._21
{
    class Program
    {
        static void Main()
        {
            float i = 1;
            float summi = 0;
            float summi0 = 0;
            do
            {
                summi0 = summi;
                float res = 1 / (i * (i + 1) * (i + 2));
                summi += res;
                i++;
            } while (summi0 == summi);
            Console.WriteLine(summi);
            double j = 1;
            double summi1 = 0;
            double summi2 = 0;
            do
            {
                summi2 = summi1;
                double res = 1 / (i * (i + 1) * (i + 2));
                summi1 += res;
                j++;
            } while (summi0 == summi);
            Console.WriteLine(summi);
        }
    }
}
