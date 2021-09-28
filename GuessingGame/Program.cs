using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Enter a number:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userGuess)
                {
                    Console.WriteLine("Well done. You have won.");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"{3 - i} tries left. Try again.");
                }
            }

            if (i == 3)
            {
                Console.WriteLine("You have lost");
            }
        }
    }
}
