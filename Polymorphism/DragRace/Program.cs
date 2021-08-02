using System;
using System.Collections.Generic;
using System.Threading;

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

            void Competition(int distance)
            {
                foreach (ICar car in cars)
                {
                    Console.Write(car.Name);
                    car.StartEngine();                    
                }
                int finish = 1;
                int time = 2;
                string dist = "";
                int occasion = 0;
                //string distLeft = "";

                do
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    for (int i=0; i<cars.Count; i++)  //foreach (ICar car in cars)
                    {
                        if (cars[i].Location < distance)
                        {
                            occasion = rnd.Next(4);
                            if (occasion < 2)
                            {
                                cars[i].SpeedUp();
                                //if (occasion == 0)
                                //  car.UseNitrousOxideEngine();
                            }
                            else
                                cars[i].SlowDown();
                            cars[i].Location = cars[i].Location + cars[i].CurrentSpeed * time + cars[i].Acceleration * time * time / 2;
                        }
                        else
                        {                            
                            cars[i].Place = finish;
                            Console.WriteLine($"{cars[i].Name} finished! {cars[i].Place}");
                            finish++;                            
                        }

                        dist = new String('-', cars[i].Location);
                        //distLeft = new string(' ', distance - car.Location - 2);
                        Console.WriteLine($"|{dist}{cars[i].Name}");//{distLeft}|
                        //Console.WriteLine($"{cars[i].Name}, {occasion}, {cars[i].Location}, {cars[i].Place}");
                    }                  
                } while (finish < cars.Count);
            }

            Competition(30);

            Console.ReadKey();
        }
    }
}