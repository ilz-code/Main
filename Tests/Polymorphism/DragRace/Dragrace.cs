using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Dragrace
    {
        public static List<ICar> cars = new List<ICar>();

        public static List<ICar> MakeCarsList()
        {
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
    }
}
