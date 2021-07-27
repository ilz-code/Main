using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const double NumberSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + NumberSurveyed);
            Console.WriteLine("Approximately " + CalculateEnergyDrinkers(NumberSurveyed) + " bought at least one energy drink.");
            Console.WriteLine(CalculatePreferCitrus(NumberSurveyed) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        public static int CalculateEnergyDrinkers(double numberSurveyed)
        {
            int energyDrinkers = Convert.ToInt32(Math.Round(NumberSurveyed * PurchasedEnergyDrinks));
            return energyDrinkers;
        }

        public static int CalculatePreferCitrus(double numberSurveyed)
        {
            int preferCitrus = Convert.ToInt32(Math.Round(CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks));
            return preferCitrus;
        }
    }
}
