using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> videos = new List<Video>();

        public VideoStore()
        {
            if (File.Exists("movies.txt"))
            {
                var content = File.ReadAllText("movies.txt");
                videos = JsonConvert.DeserializeObject<List<Video>>(content);
            }
        }

        public void AddVideo(string title)
        {
            Video video = new Video(title);
            videos.Add(video);
        }

        public void Save ()
        {
            var videosList = JsonConvert.SerializeObject(videos);
            File.WriteAllText("movies.txt", videosList);
        }

        public void Checkout(string title)
        {
            for (int i = 0; i < videos.Count; i++)
            {
                if (videos[i].Title == title)
                {
                    if (videos[i].Available == true)
                        videos[i].BeingCheckedOut();
                    else
                        Console.WriteLine(" This video is not available");
                }
            }
        }

        public void ReturnVideo(string title, double rating)
        {
            for (int i = 0; i < videos.Count; i++)
            {
                if (videos[i].Title == title)
                {
                    videos[i].BeingReturned();
                    videos[i].AverageRating(rating);
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            for (int i = 0; i < videos.Count; i++)
            {
                if (videos[i].Title == title)
                    videos[i].ReceivingRating(rating);
            }
        }

        public void ListInventory()
        {
            Console.WriteLine(videos.Count);
            for (int i = 0; i < videos.Count; i++)
            {
                Console.WriteLine(videos[i].ToString());
            }
        }
    }
}
