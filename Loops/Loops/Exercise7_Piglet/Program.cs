using System;

namespace Exercise7_Piglet
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            var rnd = new Random();
            int roll = 0;
            string ans = "";
            int sum = 0;
            do
            {
                roll = rnd.Next(9);
                if (roll == 1)
                {
                    Console.WriteLine("You rolled a 1! You got 0 points.");
                    break;
                }
                sum += roll;
                Console.WriteLine($"You rolled a {roll}! Continue (yes/no)?");
                ans = Console.ReadLine();
            }
            while (ans == "yes");            
            if(roll != 1)
                Console.WriteLine($"You got {sum} points!");
            Console.ReadKey();
        }
    }
}
