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

        private static void DrawBar(double value, string symbol, int lengthBar)
        {
            var percentageСharacters = (lengthBar * (value / 100));

            string bar = "";

            if (value >= 0 && value <= 100)
            {
                Console.Write("[");

                for (int i = 0; i < percentageСharacters; i++)
                {
                    bar += symbol;
                }

                for (int i = 0; i < (lengthBar - percentageСharacters); i++)
                {
                    bar += "_";
                }

                Console.Write($"{bar}]\n");
            }
            else
            {
                Console.WriteLine("incorrect data");
            }
        }
    }
}
