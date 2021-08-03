using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
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

            Random rnd = new Random();

            List<int>[] carLoc = new List<int>[cars.Count];
            List<Finisher> finishers = new List<Finisher>();
            int distance = 100;

            int Competition()
            {
                int time = 4;
                int occasion;
                int times;
                int i = 0;                

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
                            //if (occasion == 0)
                            //  car.UseNitrousOxideEngine();
                        }
                        else
                            car.SlowDown();

                        times++;
                        car.Location = car.Location + car.CurrentSpeed * time + car.Acceleration * time * time / 2;
                        loc.Add(car.Location);
                    }
                    carLoc[i] = loc;
                    i++;

                    Finisher finisher = new Finisher(car.Name, times, car.Location);
                    finishers.Add(finisher);
                }
                return distance;               
            }

            void Visualisation()
            {
                Console.WriteLine();
                foreach (ICar car in cars)
                {
                    Console.Write("| " + car.Name + " ");
                    car.StartEngine();
                }

                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine();
                foreach (ICar car in cars)
                {
                    Console.WriteLine("| " + car.Name + new string(' ', distance) +"|");                    
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
                    Console.Clear();
                    Console.WriteLine();
                    for (int c = 0; c < carLoc.Length; c++)
                    {
                        Console.WriteLine($" |" + new String('-', carLoc[c][t]) + cars[c].Name + new string(' ', distance - carLoc[c][t]) + "|");
                    }
                }

            }

            void Results()
            {
                List<Finisher> sortedFinishers = finishers.OrderBy(c => c.Time).ThenByDescending(c => c.Distance).ToList();
                Console.WriteLine();

                foreach (Finisher car in sortedFinishers)
                    car.Time = car.Time * 4 - (car.Distance - distance) / 8;               
                
                int place = 1;
                Thread.Sleep(2000);
                foreach (Finisher car in sortedFinishers)
                {
                    Console.WriteLine($" {place} is {car.Name}, time {car.Time.ToString("0.0")}s");
                    place++;
                }
            }



            Competition();            
            Visualisation();
            Results();

            Console.ReadKey();

        }
    }
}