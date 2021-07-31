using System;
using System.Collections.Generic;

namespace Exercise4_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] movie = new Movie[4];
            movie[0] = new Movie("Casino Royale", "Eon Productions", "PG­13");
            movie[1] = new Movie("Glass", "Buena Vista International", "PG­13");
            movie[2] = new Movie("Spider - Man: Into the Spider - Verse", "Columbia Pictures");
            movie[3] = new Movie("Caribean Pyrates", "Fox studio", "RR7");

            List<Movie> GetPG(Movie[] movies)
            {
                var movPG = new List<Movie>();
                for (int i = 0; i < movies.Length; i++)
                {                    
                    string rat = (movies[i].GetRating()).Substring(0, 2);
                    if (rat == "PG")
                    {
                        movPG.Add(movies[i]);
                        Console.WriteLine(movies[i].Name);
                    }
                }
                    return movPG;                
            }

            GetPG(movie);
            Console.ReadKey();
        }
    }
}
