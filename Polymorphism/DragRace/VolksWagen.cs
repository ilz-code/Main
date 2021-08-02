using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class VolksWagen: ICar
    {
        public int CurrentSpeed { get; set; }
        public int Acceleration { get; set; }
        public int Location { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }

        public VolksWagen(string name, int speed, int accel)
        {
            CurrentSpeed = speed;
            Acceleration = accel;
            Name = name;
            Location = 0;
        }

        public void SpeedUp()
        {
            CurrentSpeed += Acceleration;
        }

        public void SlowDown()
        {
            if (CurrentSpeed > Acceleration)
            {
                CurrentSpeed -= Acceleration;
            }
        }

        public int ShowCurrentSpeed()
        {
            return CurrentSpeed;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}

