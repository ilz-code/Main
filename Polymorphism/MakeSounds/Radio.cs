using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Radio: ISound
    {
        public Radio()
        {

        }

        public void PlaySound()
        {
            Console.WriteLine("Blahblahblah");
        }
    }
}
