using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int endKilometers;
            int liters;

            Car car = new Car(543);
            Car car1 = new Car(678);

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($" car {car.odoMeter}");
                Console.Write("Enter kilometers: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters filled: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(endKilometers, liters);
                Console.WriteLine($"car consumption is {car.CalculateConsumption()} kilometers per liter");
                Console.WriteLine();

                Console.WriteLine($" car1 {car1.odoMeter}");
                Console.Write("Enter kilometers: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters filled: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(endKilometers, liters);               
                Console.WriteLine($"car1 consumption is {car1.CalculateConsumption()} kilometers per liter");
                Console.WriteLine();
            }

            Console.WriteLine("car Kilometers per liter are " + car.CalculateConsumption() + " car is " + car.ConsumptionType());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " car1 is " + car1.ConsumptionType());
            Console.ReadKey();
        }
    }
}
