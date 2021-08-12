using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Finisher
    {
        public string Name { get; set; }
        public double Time { get; set; }
        public double FinTime { get; set; }
        public double Distance { get; set; }

        public Finisher(string name, int time, int distance)
        {
            Name = name;
            Time = time;
            Distance = distance;
        }
    }
}
