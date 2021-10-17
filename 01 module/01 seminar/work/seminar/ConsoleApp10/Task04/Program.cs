using System;
using System.Linq;
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номера аудиторий через пробел (целое трёхзначное число): ");
            string input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            foreach (var n in numbers)
            {
                Console.Write(n + "\t");
            }

            int mini = 999;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 100 < mini % 100) mini = numbers[i];
            }
            Console.WriteLine(mini);
        }

    }
}
