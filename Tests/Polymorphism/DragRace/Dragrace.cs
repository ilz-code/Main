using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace DragRace
{
    public class Dragrace
    {
        public static List<List<int>> carLoc = new List<List<int>>();
        public static List<Finisher> finishers = new List<Finisher>();

        public static List<ICar> MakeCarsList()
        {
            List<ICar> cars = new List<ICar>();
            Mercedes mercee = new Mercedes("M", 0, 2);
            cars.Add(mercee);
            VolksWagen wagen = new VolksWagen("V", 0, 1);
            cars.Add(wagen);
            Tesla tesla = new Tesla("T", 0, 1);
            cars.Add(tesla);
            Lexus lexy = new Lexus("L", 0, 2);
            cars.Add(lexy);
            Bmw bamby = new Bmw("B", 0, 2);
            cars.Add(bamby);
            Audi audy = new Audi("A", 0, 2);
            cars.Add(audy);
            return cars;
        }

        public static List<List<int>> Competition(List<ICar> cars) 
        {
            Random rnd = new Random();
            int time = 4;
            int distance = 100;
            int occasion;
            int times;
            
            foreach (ICar car in cars)
            {
                times = 0;
                List<int> loc = new List<int>();
                while (car.Location < distance)
                {
                    occasion = rnd.Next(4);
                    if (occasion < 2)
                    {
                        car.SpeedUp();
                        if (occasion == 0)
                        {
                            if (car is IAdvancedCar adv)
                                adv.UseNitrousOxideEngine();
                        }
                    }
                    else
                        car.SlowDown();
                    times++;
                    car.Location = car.Location + car.CurrentSpeed * time + car.Acceleration * time * time / 2;
                    loc.Add(car.Location);
                }
                carLoc.Add(loc);
                Finisher finisher = new Finisher(car.Name, times, car.Location);
                finishers.Add(finisher);
            }
            return carLoc;
        }

        public static int Visualization()
        {
            int distance = 100;
            List<ICar> cars = MakeCarsList();
            Console.WriteLine();
            foreach (ICar car in cars)
            {
                Console.Write("| " + car.Name + " ");
                car.StartEngine();
            }

            Thread.Sleep(500);
            //Console.Clear();
            Console.WriteLine();
            foreach (ICar car in cars)
            {
                Console.WriteLine("| " + car.Name + new string(' ', distance) + "|");
            }

            int maxTimes = 0;
            foreach (List<int> car in carLoc)
            {
                if (car.Count > maxTimes)
                    maxTimes = car.Count;
            }

            foreach (List<int> car in carLoc)
            {
                car[^1] = distance;
                if (car.Count < maxTimes)
                    for (int t = car.Count; t <= maxTimes; t++)
                        car.Add(distance);
            }

            for (int t = 0; t < maxTimes; t++)
            {
                Thread.Sleep(2000);
                //Console.Clear();
                Console.WriteLine();
                for (int c = 0; c < carLoc.Count; c++)
                {
                    Console.WriteLine($" |" + new String('-', carLoc[c][t]) + cars[c].Name + new string(' ', distance - carLoc[c][t]) + "|");
                }
            }

            return distance;
        }

        public static int Results()
        {
            int distance = 100;
            List<Finisher> sortedFinishers = finishers.OrderBy(c => c.Time).ThenByDescending(c => c.Distance).ToList();
            Console.WriteLine();
            foreach (Finisher car in sortedFinishers)
                car.Time = car.Time * 4 - (car.Distance - distance) / 8;
            int place = 0;
            Thread.Sleep(700);
            foreach (Finisher car in sortedFinishers)
            {
                place++;
                Console.WriteLine($" {place} is {car.Name}, time {car.Time.ToString("0.0")}s");
            }
            return place;
        }
    }
}
