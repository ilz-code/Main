namespace Exercise4_Movie
{
    public class Movie
    {
        public string Name { get; set; }
        public string Studio { get; set; } 
        public string Rating { get; set; }
        
        public Movie(string name, string studio, string rating)
        {
            Name = name;
            Studio = studio;
            Rating = rating;
        }

        public Movie(string name, string studio)
        {
            Name = name;
            Studio = studio;
            Rating = "PG";
        }

        public string GetRating()
        {
            return Rating;
        }

    }
}
