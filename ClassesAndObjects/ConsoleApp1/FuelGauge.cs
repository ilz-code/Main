using System;

namespace ConsoleApp1
{
    public class FuelGauge
    {
        private int _fuelLevel;

        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public void Fill()
        {
            if(_fuelLevel < 70)
                _fuelLevel++;
        }

        public void DecreaseLevel()
        {
            if (_fuelLevel > 0)
                _fuelLevel--;
            else
                Console.WriteLine("Fuel tank is empty!");
        }
    }
}
