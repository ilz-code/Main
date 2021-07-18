using System;

namespace Ex5_PhoneKeyPad_if
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Please enter a string");
            string inputV = Console.ReadLine();
            string input = inputV.ToLower();

            string[] digits = new string[input.Length];
            
            for (int i =0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    digits[i] = "2";
                else if (input[i] == 'b')
                    digits[i] = "22";
                else if (input[i] == 'c')
                    digits[i] = "222";
                else if (input[i] == 'd')
                    digits[i] = "3";
                else if (input[i] == 'e')
                    digits[i] = "33";
                else if (input[i] == 'f')
                    digits[i] = "333";
                else if (input[i] == 'g')
                    digits[i] = "4";
                else if (input[i] == 'h')
                    digits[i] = "44";
                else if (input[i] == 'i')
                    digits[i] = "444";
                else if (input[i] == 'j')
                    digits[i] = "5"; 
                else if (input[i] == 'k')
                    digits[i] = "55";
                else if (input[i] == 'l')
                    digits[i] = "555";
                else if (input[i] == 'm')
                    digits[i] = "6";
                else if (input[i] == 'n')
                    digits[i] = "66";
                else if (input[i] == 'o')
                    digits[i] = "666";
                else if (input[i] == 'p')
                    digits[i] = "7";
                else if (input[i] == 'q')
                    digits[i] = "77";
                else if (input[i] == 'r')
                    digits[i] = "777";
                else if (input[i] == 's')
                    digits[i] = "7777";
                else if (input[i] == 't')
                    digits[i] = "8";
                else if (input[i] == 'u')
                    digits[i] = "88";
                else if (input[i] == 'v')
                    digits[i] = "888";
                else if (input[i] == 'w')
                    digits[i] = "9";
                else if (input[i] == 'x')
                    digits[i] = "99";
                else if (input[i] == 'y')
                    digits[i] = "999";
                else
                    digits[i] = "9999";
            }
           
            string output = String.Join(" ", digits);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
