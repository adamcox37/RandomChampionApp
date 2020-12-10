using System;

namespace RandomChampionUI
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            GoodByeMessage();
            Console.ReadLine();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Random Champion Generator!");
        }

        public static void GoodByeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Best of luck to you in the playoffs.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press any key to exit.");
        }
    }
}
