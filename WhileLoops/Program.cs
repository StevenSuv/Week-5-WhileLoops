using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*while(true)
            {
                Console.WriteLine("Enter your PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again");
                }
                
            }*/

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Enter your PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Incorrect PIN. {3 - i} tries left");
                }
            }

        }
    }
}
