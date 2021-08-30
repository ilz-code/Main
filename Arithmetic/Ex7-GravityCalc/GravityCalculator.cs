using System;

namespace Ex7_GravityCalc
{
    public class GravityCalculator
    {
        public static double GravityCalculation(double initialPosition, double fallingTime, double initialVelocity)
        {
            double gravity = 9.81;
            double finalPosition = 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
            return finalPosition;
        }
    }
}
