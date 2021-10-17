using System;
using System.Linq;
namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём массив заполненный числами от 1 до 100 (длины 100).
            int[] arr = new int[100];
            for (int i = 1; i < 101; i++)
            {
                arr[i - 1] = i;
            }

            // Перемешиваем его элементы с помощью алгоритма Фишера-Йетса.
            Random rand = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }

            /*foreach (int i in arr)
            {
                Console.Write(i + " ");
            } 
            Console.WriteLine();*/
            // Удаляем последний элемент из массива, чтобы убрать одно число и сократить его длину.
            int[] newArr = new int[99];
            for (int i = 0; i < 99; i++)
            {
                newArr[i] = arr[i];
            }

            /*foreach (int i in newArr)
            {
                Console.Write(i + " ");
            } 
            Console.WriteLine();*/
            // Ищем потеряное число
            for (int i = 1; i < 101; i++)
            {
                if (!(newArr.Contains(i)))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

    }
}
