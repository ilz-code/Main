using System;

namespace Ex7_GravityCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = GravityCalculator.GravityCalculation(initialPosition, fallingTime, initialVelocity);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
