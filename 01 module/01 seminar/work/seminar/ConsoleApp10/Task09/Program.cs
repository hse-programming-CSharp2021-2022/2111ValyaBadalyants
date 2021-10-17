using System;

namespace Task09
{
    class Program
    {
        public static void Method(ref int a, ref int d, ref int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a + i * d;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            int a = 0;
            int d = 0;
            Console.WriteLine("Введите размер массива (>1):");
            string nu = Console.ReadLine();
            Console.WriteLine("Введите A:");
            string au = Console.ReadLine();
            Console.WriteLine("Введите D:");
            String du = Console.ReadLine();
            if (!(int.TryParse(nu, out n) && int.TryParse(au, out a) && int.TryParse(du, out d) && n > 1))
            {
                Console.WriteLine("Для некоторых параметров Вы ввели некорректное значение!");
            }
            else
            {
                a = Convert.ToInt32(au);
                d = Convert.ToInt32(du);
                n = Convert.ToInt32(nu);
            }
            Method(ref a, ref d, ref n);
        }
    }
}
