using System;

namespace Ex1_IsFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            bool isFifteen;
            if (num1 == 15)
                isFifteen = true;
            else if (num2 == 15)
                isFifteen = true;
            else if (num1 + num2 == 15)
                isFifteen = true;
            else if (num1 - num2 == 15)
                isFifteen = true;
            else if (num2 - num1 == 15)
                isFifteen = true;
            else
                isFifteen = false;
            Console.WriteLine(isFifteen);
            Console.ReadKey();
        }
    }
}
