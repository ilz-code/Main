﻿using System;

namespace DateTest
{
    public class Date
    {
        int Year { get; set; }
        int Month { get; set; }
        int Day { get; set; }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public void DisplayData()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }
}