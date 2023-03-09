using System;

namespace Healthbar
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LengthBar = 10;
            double number;

            string symbol;
            string percent;

            Console.WriteLine("Введите Символ");
            symbol = Console.ReadLine();

            Console.WriteLine("Введите процент от 0 да 100");
            percent = Console.ReadLine();
            double.TryParse(percent, out number);

            Console.Clear();

            DrawBar(number, symbol, LengthBar);
        }

        private static void DrawBar(double percent, string symbol, int lengthBar)
        {
            const int Divider = 100;

            int minNumber = 0;
            int maxNumber = 100;

            var percentageСharacters = (lengthBar * (percent / Divider));

            string bar = "";

            if (percent >= minNumber && percent <= maxNumber)
            {
                char openingBracket = '[';
                char closingBracket = ']';
                char underlining = '_';

                Console.Write(openingBracket);

                for (int i = 0; i < percentageСharacters; i++)
                {
                    bar += symbol;
                }

                for (int i = 0; i < (lengthBar - percentageСharacters); i++)
                {
                    bar += underlining;
                }

                Console.Write($"{bar}{closingBracket}\n");
            }
            else
            {
                Console.WriteLine("incorrect data");
            }
        }
    }
}
