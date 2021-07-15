using System;

namespace Ex5_guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(100);
            Console.WriteLine("Guess number from 1 to 100");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == number)
                Console.WriteLine("You get right!");
            else if (guess < number)
                Console.WriteLine("Too low!");
            else if (guess > number)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Wrong input");
            Console.ReadKey();
        }
    }
}
