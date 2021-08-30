using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Parrot: ISound
    {
        public Parrot() { }
        
        public void PlaySound()
        {
            Console.WriteLine("Khrr...Prrr");
        }
    }
}
