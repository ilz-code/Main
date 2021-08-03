using System;

namespace MakeSounds
{
    public class Firework: ISound
    {
        public Firework()
        {

        }
        public void PlaySound()
        {
            Console.WriteLine("whoosh-bang");
        }
    }
}