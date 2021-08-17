namespace DragRace
{
    public interface ICar
    {
        int CurrentSpeed { get; set; }
        int Acceleration { get; set; }
        int Location { get; set; }
        string Name { get; set; }
        int Place { get; set; }
        void SpeedUp()
        {
            CurrentSpeed += Acceleration;
        }

        void SlowDown()
        {
            CurrentSpeed -= Acceleration;
        }

        int ShowCurrentSpeed()
        {
            return CurrentSpeed;
        }

        void StartEngine();
    }
}
