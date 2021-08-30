using System;

namespace DragRace
{
    class Program
    {        
        private static void Main(string[] args)
        {
            Dragrace.Competition(Dragrace.MakeCarsList());
            Dragrace.Visualization();
            Dragrace.Results();
            Console.ReadKey();
        }
    }
}