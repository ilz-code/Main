using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double startKilometers;
        public double endKilometers;
        public double odoMeter;
        public double litersConsumed;

        public Car(double startOdo)
        {
            startKilometers = startOdo;
            odoMeter = startOdo;
        }

        public double CalculateConsumption()
        {
            double c = (endKilometers - startKilometers) / litersConsumed;
            return Math.Round(c, 3);
        }

        private double ConsumptionPer100Km()
        {
            return litersConsumed / (endKilometers - startKilometers) * 100;
        }

        public string ConsumptionType()
        {
            if (ConsumptionPer100Km() > 15)
                return "Gas Hog";
            else if (ConsumptionPer100Km() < 5)
                return "economy car";
            else
                return "medium consumption car";
        }

        public void FillUp(int kilometers, double litersFilled)
        {
            startKilometers = odoMeter;
            endKilometers = kilometers;
            litersConsumed = litersFilled;
            odoMeter = endKilometers;
        }
    }
}
