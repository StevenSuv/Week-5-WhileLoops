using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);

            while(true)
            {
                Console.WriteLine("Enter a number:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                
                if(cpuRandom == userGuess)
                {
                    Console.WriteLine("Well done. You have won.");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
