using System;

namespace Ex5_PhoneKeyPadSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string inputV = Console.ReadLine();
            string input = inputV.ToLower();

            string[] digits = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        digits[i] = "2";
                        break;
                    case 'b':
                        digits[i] = "22";
                        break;
                    case 'c':
                        digits[i] = "222";
                        break;
                    case 'd':
                        digits[i] = "3";
                        break;
                    case 'e':
                        digits[i] = "33";
                        break;
                    case 'f':
                        digits[i] = "333";
                        break;
                    case 'g':
                        digits[i] = "4";
                        break;
                    case 'h':
                        digits[i] = "44";
                        break;
                    case 'i':
                        digits[i] = "444";
                        break;
                    case 'j':
                        digits[i] = "5";
                        break;
                    case 'k':
                        digits[i] = "55";
                        break;
                    case 'l':
                        digits[i] = "555";
                        break;
                    case 'm':
                        digits[i] = "6";
                        break;
                    case 'n':
                        digits[i] = "66";
                        break;
                    case 'o':
                        digits[i] = "666";
                        break;
                    case 'p':
                        digits[i] = "7";
                        break;
                    case 'q':
                        digits[i] = "77";
                        break;
                    case 'r':
                        digits[i] = "777";
                        break;
                    case 's':
                        digits[i] = "7777";
                        break;
                    case 't':
                        digits[i] = "8";
                        break;
                    case 'u':
                        digits[i] = "88";
                        break;
                    case 'v':
                        digits[i] = "888";
                        break;
                    case 'w':
                        digits[i] = "9";
                        break;
                    case 'x':
                        digits[i] = "99";
                        break;
                    case 'y':
                        digits[i] = "999";
                        break;
                    case 'z':
                        digits[i] = "9999";
                        break;
                }
            }

                string output = String.Join(" ", digits);
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }
    }
