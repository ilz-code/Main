using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface ICar
    {
        public int CurrentSpeed { get; set; }
        public int Acceleration { get; set; }
        public int Location { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }
        public void SpeedUp()
        {
            CurrentSpeed += Acceleration;
        }

        public void SlowDown()
        {
            CurrentSpeed -= Acceleration;
        }

        public int ShowCurrentSpeed()
        {
            return CurrentSpeed;
        }

        public void StartEngine();
    }
}
