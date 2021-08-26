using System;

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

        public string DisplayData()
        {
            string month ="";
            if (Month < 10)
                month = "0" + Convert.ToString(Month);
            else
                month = Convert.ToString(Month);
            string day ="";
            if (Day < 10)
                day = "0" + Convert.ToString(Day);
            else
                day = Convert.ToString(Day);
            return $"{day}/{month}/{Year}";
        }
    }
}
