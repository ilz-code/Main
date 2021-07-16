using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight(in kilograms)");
            double weightKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height (in cm)");
            double heightCm = Convert.ToDouble(Console.ReadLine());
            double weightPounds = weightKg * 2.205;
            double heightInch = heightCm * 0.3937;
            double bmi = Math.Round((weightPounds * 703 / Math.Pow(heightInch, 2)), 2);
            if (bmi < 18.5)
                Console.WriteLine($"Your BMI is {bmi}. You are underweight.");
            else if (bmi > 25)
                Console.WriteLine($"Your BMI is {bmi}. You are overweight.");
            else
                Console.WriteLine($"Your BMI is {bmi}. Your weight is normal.");
            Console.ReadKey();
        }
    }
}
