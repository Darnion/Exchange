using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Gray;

            var course = 58.3;
            var commission = 3.8;

            Console.Write("Введите количество долларов: ");
            var dollars = Console.ReadLine();

            double.TryParse(dollars, out var value);

            var roubles = value * course;

            Console.WriteLine("При курсе доллара = " + course + " руб. У Вас " + roubles.ToString("0.00") + " руб.");

            if (value > 500.0)
            {
                Console.WriteLine("С комиссией сервиса " + commission + "% у вас останется " + (roubles - roubles * commission / 100).ToString("0.00") + " руб.");
            }
            else
            {
                Console.WriteLine("С комиссией сервиса 8 руб. у вас останется " + (roubles - 8.0).ToString("0.00") + " руб.");
            }

        }
    }
}
