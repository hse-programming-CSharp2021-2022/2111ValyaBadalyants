using System;
using System.Text;
namespace Task11
{
    class Program
    {
        //2. Написать метод ConvertHex2Bin(), выполняющий перевод шестнадцатеричного числа в двоичное.
        //Заголовок метода следующий:
        //string ConvertHex2Bin(string HexNumber)
        //Здесь HexNumber – строка, представляющая шестнадцатеричное число, например 5A1.
        //Функция должна возвращать строку с двоичным представлением числа.
        //Например, для шестнадцатеричного числа, представленного строкой 5A1 функция должна вернуть строку 10110100001.
        public static string ConvertHex2Bin(string HexNumber)
        {
            StringBuilder res = new StringBuilder(100);
            foreach (var i in HexNumber)
            {
                switch (i)
                {
                    case '0':
                        res.Append("0000");
                        continue;
                    case '1':
                        res.Append("0001");
                        continue;
                    case '2':
                        res.Append("0010");
                        continue;
                    case '3':
                        res.Append("0011");
                        continue;
                    case '4':
                        res.Append("0100");
                        continue;
                    case '5':
                        res.Append("0101");
                        continue;
                    case '6':
                        res.Append("0110");
                        continue;
                    case '7':
                        res.Append("0111");
                        continue;
                    case '8':
                        res.Append("1000");
                        continue;
                    case '9':
                        res.Append("1001");
                        continue;
                    case 'A':
                        res.Append("1010");
                        continue;
                    case 'B':
                        res.Append("1011");
                        continue;
                    case 'C':
                        res.Append("1100");
                        continue;
                    case 'D':
                        res.Append("1101");
                        continue;
                    case 'E':
                        res.Append("1110");
                        continue;
                    case 'F':
                        res.Append("1111");
                        continue;
                    default: break;
                }
            }

            return res.ToString();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число в 16-ой сс: ");
            string str = Console.ReadLine();
            Console.WriteLine("Число в 2-ой сс: ");
            string hex = ConvertHex2Bin(str);
            if (hex[0] == '0')
            {
                hex = hex.Substring(1);
                Console.WriteLine(hex);
            }
            else Console.WriteLine(hex);
        }

    }
}
