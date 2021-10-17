using System;
using System.Text;

namespace Task05
{
    class Program
    {
        public static bool Shift(ref string ch)
        {
            string symbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            if (!(symbols.Contains(ch)))
            {
                return false;
            }
            else
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(ch);

                foreach (var i in asciiBytes)
                {
                    Console.WriteLine((char)(i + 4));
                }

                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:  ");
            string ch = Console.ReadLine();

            if (Shift(ref ch))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
        }

    }
}
