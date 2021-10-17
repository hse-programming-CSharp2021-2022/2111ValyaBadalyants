using System;

namespace Task12
{
    class Program
    {
        static double[][] CreateArray(int arrayLength, int maxSubarrayLength,
                                     int minSubarrayElement, int maxSubarrayElement)
        {
            Console.WriteLine("initializing double array...");
            Random rnd = new Random();

            double[][] arr = new double[arrayLength][];
            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = new double[rnd.Next(1, maxSubarrayLength + 1)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(minSubarrayElement, maxSubarrayElement) + rnd.NextDouble();
                }
            }

            return arr;

        }


        static void SeparateArray(double[][] initialArray, out int[][] integerValues, out double[][] fractionalValues)
        {
            Console.WriteLine("separating array...");
            integerValues = new int[initialArray.Length][];
            fractionalValues = new double[initialArray.Length][];

            for (int i = 0; i < initialArray.Length; i++)
            {
                integerValues[i] = new int[initialArray[i].Length];
                fractionalValues[i] = new double[initialArray[i].Length];

                for (int j = 0; j < initialArray[i].Length; j++)
                {
                    integerValues[i][j] = (int)initialArray[i][j];
                    fractionalValues[i][j] = initialArray[i][j] - integerValues[i][j];
                }
            }

        }


        static void PrintJaggedArray(double[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }


        static void PrintJaggedArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int arrayLength = 0, maxSubarrayLength = 0,
                minSubarrayElement = 0, maxSubarrayElement = 0;

            while (true)
            {
                Console.WriteLine("Provide required parameters. Enter `:wq` to exit.");
                string[] data = Console.ReadLine().Split(' ');

                if (data[0] == ":wq")
                {
                    Console.WriteLine("adios versailles.");
                    Environment.Exit(0);
                }

                if (data[0] == "clear")
                {
                    Console.Clear();
                    continue;
                }

                if (data.Length != 4 || !int.TryParse(data[0], out arrayLength)
                                     || !int.TryParse(data[1], out maxSubarrayLength)
                                     || !int.TryParse(data[2], out minSubarrayElement)
                                     || !int.TryParse(data[3], out maxSubarrayElement))
                {
                    Console.WriteLine("incorrect input. rage quit.");
                    continue;
                }

                double[][] arr = CreateArray(arrayLength, maxSubarrayLength, minSubarrayElement, maxSubarrayElement);

                Console.WriteLine("your array is: \n");
                PrintJaggedArray(arr);
                Console.WriteLine();

                int[][] integerValues;
                double[][] fractionalValues;

                SeparateArray(arr, out integerValues, out fractionalValues);

                Console.WriteLine("integer values are: \n");
                PrintJaggedArray(integerValues);
                Console.WriteLine();

                Console.WriteLine("fractional values are: \n");
                PrintJaggedArray(fractionalValues);
                Console.WriteLine();

                Console.WriteLine("continue?[y/n]");

                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.WriteLine("adios versailles.");
                    Environment.Exit(0);
                }

            }

        }
    }
}