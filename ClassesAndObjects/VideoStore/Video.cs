using System;
using System.Collections.Generic;

namespace VideoStore
{
    public class Video
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public bool Available = true;
        public int TimesRated = 5;

        public Video(string title)
        {
            Title = title;
            Rating = 0;
        }

        public void BeingCheckedOut()
        {
            Available = false;
        }

        public void BeingReturned()
        {
            Available = true;
        }

        public double ReceivingRating(double rating)
        {
            Rating = rating;
            return Rating;
        }

        public double AverageRating(double rating)
        {
            Console.WriteLine("times rated" + TimesRated);
            Rating = (Rating * TimesRated + rating) / (++TimesRated);
            Console.WriteLine("times rated" + TimesRated);
            //TimesRated++;
            return Rating;
        }
              
        public override string ToString()
        {
            return $"{Title} {Rating} {Available}";
        }
    }
}
