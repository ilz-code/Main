using System;

namespace Ex8_EmployeePay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWorkers = 3;
            string dashes = new string('-', 50);
            Console.WriteLine(" +" + dashes + "+");
            Console.WriteLine($" | Employee   | Base pay | Hours worked | Must pay");
            Console.WriteLine(" +" + dashes + "+");
            string[] pay = new string[numberOfWorkers];
            double[] basePay = { 7.50, 8.20, 10.0 };
            double[] hoursWorked = { 35, 47, 73 };
            for (int i = 0; i < numberOfWorkers; i++)
            {
                pay[i] = EmployeePay.ToPay(basePay[i], hoursWorked[i]);
                Console.WriteLine(" | Employee " + (i + 1) + " | " + basePay[i] + "       | " + hoursWorked[i] + "          | " +pay[i]);
            }
            Console.WriteLine(" +" + dashes + "+");
            Console.ReadKey();
        }
     }
}
