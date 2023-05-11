namespace Class15_EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel1 = new Channel()
            {
                Name = "Discovery"
            };

            Channel channel2 = new()
            {
                Name = "Travel"
            };

            var user1 = new User
            {
                Username = "ristop",
                FavoriteCategory = CategoryEnum.Entertainment
            };

            var user2 = new User
            {
                Username = "tijanas",
                FavoriteCategory = CategoryEnum.Science
            };

            var user3 = new User
            {
                Username = "markog",
                FavoriteCategory = CategoryEnum.Sport
            };

            channel1.Subscribe(user2.SubscribeMethod);

            channel2.Subscribe(user1.SubscribeMethod);
            channel2.Subscribe(user3.SubscribeMethod);

            var video1 = new Video
            {
                Category = CategoryEnum.Science,
                Description = "Some video on Discovery channel",
                Link = "http://link1",
                Title = "Video 1 on Discovery",
                Duration = 600
            };
            channel1.UploadVideo(video1);

            channel2.UploadVideo(new Video
            {
                Category = CategoryEnum.Sport,
                Description = "Champions League match",
                Link = "http://link3",
                Title = "Video 1 on Travel channel",
                Duration = 6000
            });

            channel2.UploadVideo(new Video
            {
                Category = CategoryEnum.Education,
                Description = "Some edu video on Travel",
                Link = "http://link1",
                Title = "Video 2 on Travel channel",
                Duration = 600
            });
        }
    }
}