using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = new int[100]; // intialize with { };
            int[] frequencies = new int[100];

            for (int i = 0; i < 100; i++)
            {
                frequencies[givenArray[i]]++;
                if (frequencies[givenArray[i]] == 2)
                {
                    Console.WriteLine(givenArray[i]);
                }
            }

        }
    }
}
