using System;
using System.Linq;
using System.Text;

namespace Cows_and_Bulls
{
    class Program
    {
        /// <summary>
        /// Этот метод считает количество коров и быков в введеном числе и выводит их число в консоль.
        /// </summary>
        public static void Checknumber()
        {
            string rndnum = Getrandomnum();
            int bulls = 0, cows = 0;
            do
            {
                string guessnum = Console.ReadLine();
                // Проверка введеного числа на четырехзначность.
                if (guessnum.Length != 4)
                {
                    Console.WriteLine("Введите именно четырёхзначное чсило");
                }
                // Проверка цифр введеного числа на уникальность:
                // IsDigit(Char). Показывает, относится ли указанный символ Юникода к категории десятичных цифр.
                else if (!guessnum.All(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Ты ошибся, в числе должны быть онли цифры..");
                }
                // С помощью Distinct убираем повторяющиеся символы из введеного числа и 
                // смотрим, если их кол-во стало меньше 4, значит человек ввел число с повторяющимися цифрами.
                else if (guessnum.Distinct().Count() != 4)
                {
                    Console.WriteLine("Глупыш, все цифры в твоем числе должны быть разные...");
                    Console.WriteLine("Попробуй еще раз:)");
                }
                else
                {
                    bulls = 0; cows = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (guessnum[i] == rndnum[i])
                        {
                            bulls++;
                        }
                        else if (rndnum.Contains(guessnum[i]))
                        {
                            cows++;
                        }
                    }
                    Console.WriteLine($"Быки:{bulls} Коровы:{cows}");
                }
            } while (bulls != 4);
            Console.WriteLine("Красава. Ты наконец-то выиграл!!!");
            Console.WriteLine("Хочешь еще раз сыграть? (да --> нажмите Enter, нет --> нажмите любую клавишу)");
        }
        public static int Number;
        /// <summary>
        /// Этот метод генерирует четырехзначное число с уникальными цифрами.
        /// </summary>
        /// /// <returns>Сгенерированное рандомное число</returns>
        public static string Getrandomnum()
        {
            Random rnd = new Random();
            bool uniq;
            // Создаём флаг.
            uniq = false;
            while (uniq == false)
            {
                // Генерируем рандомное число, не начинающееся с нуля.
                Number = rnd.Next(1000, 9999);
                string strNumber = Number.ToString();
                // С помощью цикла, проверяем, есть ли в нем повторяющиеся цифры.
                for (int i = 0; i < 10; i++)
                {
                    // Считаем количество каждой цифры в введеном числе.
                    int count = strNumber.Split((char)('0' + i)).Length - 1;
                    uniq = true;
                    // Если цифра содержится в числе больше одного раза, завершаем цикл и генерируем новое число.
                    if (count > 1)
                    {
                        uniq = false;
                        break;
                    }
                }
            }
            string rndnum = Convert.ToString(Number);
            return rndnum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Быки и Коровы\"" + ":");
            var phrase = "*-*--";
            var manyPhrases = new StringBuilder();
            for (var i = 0; i < 8; i++)
            {
                manyPhrases.Append(phrase);
            }
            Console.WriteLine(manyPhrases + "*");
            Console.WriteLine("");
            Console.WriteLine("*Пожалуйста введите четырехзначное число,");
            Console.WriteLine("состоящее из различных цифр*");
            Console.WriteLine("");
            do
            {
                Checknumber();
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
    }
}