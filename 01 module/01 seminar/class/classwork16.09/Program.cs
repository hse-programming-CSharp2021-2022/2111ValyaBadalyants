using System;

namespace classwork16._09_
{
    class Program
    {
        static void Main(string[] args)
        {



            string a1 = Console.ReadLine();
            int number;
            bool result1 = Int32.TryParse(a1, out number);
            if (result1)
            {
                int a = Convert.ToInt32(a1);
                int maxi = 0;
                int mini = 10;
                while (a > 0)
                {
                    if (a % 10 > maxi)
                    {
                        maxi = a % 10;
                    }



                    if (a % 10 < mini)
                    {
                        mini = a % 10;
                    }



                    a /= 10;
                }
                Console.WriteLine(mini);
                Console.WriteLine(maxi);



            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
