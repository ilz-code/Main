using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            DragRace.MakeCarsList();
            DragRace.Competition(DragRace.cars);
            DragRace.Visualisation();
            DragRace.Results();

            Console.ReadKey();
        }
    }
}