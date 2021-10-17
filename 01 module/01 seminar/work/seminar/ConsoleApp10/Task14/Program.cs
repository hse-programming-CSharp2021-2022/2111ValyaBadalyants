using System;
using System.Linq;
namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = new int[] { 1, 2, 3, 4, 5, 6, 6 }; // intialize with { };


            for (int i = 0; i < givenArray.Length; i++)
            {
                if ((givenArray[i] + givenArray[i + 1]) % 3 == 0)
                {
                    int insertValue = givenArray[i] * givenArray[i + 1];
                    givenArray = givenArray.Where((value, index) => index != (i + 1)).ToArray();
                    givenArray[i] = insertValue;

                    foreach (var item in givenArray)
                    {
                        Console.Write(item);
                        Console.Write(' ');
                    }

                    Console.WriteLine();

                }

            }

        }
    }
}
