using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var camp = new Campaign();
            camp.AddAdvert(new Hoarding(200, 50, 6, true));
            camp.AddAdvert(new NewspaperAd(100, 9, 30));
            camp.AddAdvert(new TVAd(300, 60, 15, true));
            camp.AddAdvert(new Poster(100, 20, 30, 100, 0.0015));
            Console.WriteLine(camp.ToString());
            
            Console.ReadKey();
        }
    }
}