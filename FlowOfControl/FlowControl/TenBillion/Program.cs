using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an positive integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());

            if (input < 0)
            {
                input = -input;
            }

            if (input < 2147483647)
            {
                Console.WriteLine("Number is not a long");
            }
            else
            {
                Console.WriteLine("Number is a long");
            }
                
                if (input >= 10000000000)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else
                {
                    int digits = 1;
                    if (input < 100)
                    {
                        digits = 2;
                    }
                    else if (input < 1000)
                    {
                        digits = 3;
                    }
                    else if (input < 10000)
                    {
                        digits = 4;
                    }
                    else if (input < 100000)
                    {
                        digits = 5;
                    }
                    else if (input < 1000000)
                    {
                        digits = 6;
                    }
                    else if (input < 10000000)
                    {
                        digits = 7;
                    }
                    else if (input < 100000000)
                    {
                        digits = 8;
                    }
                    else if (input < 1000000000)
                    {
                        digits = 9;
                    }
                    else 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }           
            
            Console.ReadKey();
        }
    }
}
