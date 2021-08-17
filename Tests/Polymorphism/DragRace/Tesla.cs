using System;

namespace DragRace
{
    public class Tesla: ICar 
    {
        public int CurrentSpeed { get; set; }
        public int Acceleration { get; set; }
        public int Location { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }

        public Tesla(string name, int speed, int acceleration)
        {
            CurrentSpeed = speed;
            Acceleration = acceleration;
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
            Console.WriteLine("-- silence --");
        }
    }
}