using System;

namespace DragRace
{
    class Mercedes : ICar, IAdvancedCar
    {
        public int CurrentSpeed { get; set; }
        public int Acceleration { get; set; }
        public int Location { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }

        public Mercedes(string name, int speed, int accel)
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
            Console.WriteLine("Rrrrrrrr.....");
        }

        public void UseNitrousOxideEngine()
        {
            CurrentSpeed += 2 * Acceleration;
        }
    }
}
