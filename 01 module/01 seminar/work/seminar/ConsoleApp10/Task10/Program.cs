using System;
using System.Linq;
namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива (>1):");
            string nu = Console.ReadLine();
            if (!(int.TryParse(nu, out n) && n > 1))
            {
                Console.WriteLine("Вы ввели некорректное значение!");
            }
            else
            {
                n = Convert.ToInt32(nu);
            }

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
            }
            Console.WriteLine("Исходный массив:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            var res = (from i in arr
                       where i % 2 != 0
                       select i).ToArray();
            Console.WriteLine();
            Console.WriteLine("Сжатый массив:");
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
        }
    }
}
