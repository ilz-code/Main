using System;

namespace MakeSounds
{
    class Radio: ISound
    {
        public Radio() { }
        
        public void PlaySound()
        {
            Console.WriteLine("Blahblahblah");
        }
    }
}
