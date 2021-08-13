using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {        
        private static void Main(string[] args)
        {
            List<ICar> cars = Dragrace.MakeCarsList();
            Dragrace.Competition(cars);
            Dragrace.Visualization();
            Dragrace.Results();
            Console.ReadKey();
        }
    }
}