using System;
using System.Linq;
namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(';');

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            string result = "", addon = "";

            for (int i = 0; i < data.Length; i++)
            {
                string[] words = data[i].Trim().Split(' ');

                foreach (string word in words)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j == 0)
                        {
                            addon += word[j].ToString().ToUpper();
                            continue;
                        }

                        addon += word[j];

                        if (vowels.Contains(word[j]))
                        {
                            break;
                        }
                    }
                }

                result += addon + '\n';

                addon = "";
            }

            Console.WriteLine(result);
        }
    }
}
