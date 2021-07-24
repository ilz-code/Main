using System;

namespace Ex8_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "winner", "window", "generator", "rainbow", "flower", "marathon", "coding", "computer" };
            var rnd = new Random();
            string cont;
            do
            {
                Console.Clear();
                int ind = rnd.Next(8);
                char[] word = words[ind].ToCharArray();
                string lines = new string('_', word.Length);
                char[] guess = lines.ToCharArray();
                char[] misses = new char[word.Length*2+2];
                string inp;
                char gues;
                int attempts = word.Length * 2;
                int j = 0;
                Console.WriteLine("Word: " + string.Join(" ", guess));

                for (int i = attempts; i > 0; i--)
                {                    
                    Console.WriteLine("Enter a letter:");
                    inp = Console.ReadLine();
                    gues = inp[0];
                    Console.Clear();
                    int index = Array.IndexOf(word, gues);
                    if (index > -1)
                    {
                        guess[index] = word[index];
                        for (int k = index + 1; k < word.Length; k++)
                        {
                            if (word[k] == gues)
                                guess[k] = gues;
                        }
                    }
                    else
                    {
                        misses[j] = gues;
                        j++;
                    }

                    Console.WriteLine("Word: " + string.Join(" ", guess));
                    Console.WriteLine("Misses: " + string.Join(" ", misses));
                    Console.WriteLine("Attempts left: " + (i-1));
                    
                    if (new string(guess) == new string(word))
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                }
                if (new string(guess) != new string(word))
                    Console.WriteLine("You loose...");

                Console.WriteLine("Play again or quit?");
                cont = Console.ReadLine();
            }
            while (cont != "quit");
        }
    }
}
