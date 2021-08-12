using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sounders = new List<ISound>();

            Parrot john = new Parrot();
            sounders.Add(john);
            Parrot ella = new Parrot();
            sounders.Add(ella);
            Radio swh = new Radio();
            sounders.Add(swh);
            Radio bbc = new Radio();
            sounders.Add(bbc);
            Firework fiery = new Firework();
            sounders.Add(fiery);
            Firework bang = new Firework();
            sounders.Add(bang);

            Random rnd = new Random();
            int i=0;
            while ( i < 15)
            {
                sounders[rnd.Next(sounders.Count)].PlaySound();
                i++;
            }
            Console.ReadKey();
        }
    }
}