using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15_EventsDemo
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public CategoryEnum FavoriteCategory { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }

        public void SubscribeMethod(string channelName, Video video)
        {
            if(video.Category == FavoriteCategory)
            {
                Console.WriteLine($"{Username}: On {channelName}, new video is uploaded {video.Title} [{video.Link}], from my favorite category.");
            } else
            {
                Console.WriteLine($"{Username}: On {channelName}, new video is uploaded {video.Title} [{video.Link}] maybe I will watch it later.");
            }
        }
    }
}
