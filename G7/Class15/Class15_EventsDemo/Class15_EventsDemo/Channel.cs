namespace Class15_EventsDemo
{
    public class Channel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();

        public delegate void UploadedVideoDelegate(string channelName, Video video);
        public event UploadedVideoDelegate Subscribers;

        public Channel()
        {
            Id = Guid.NewGuid();
        }

        public void Subscribe(UploadedVideoDelegate subscribeMethod)
        {
            Subscribers += subscribeMethod;
        }


        public void UnSubscribe(UploadedVideoDelegate subscribeMethod)
        {
            Subscribers -= subscribeMethod;
        }

        public void UploadVideo(Video video)
        {
            Videos.Add(video);

            if (Subscribers != null && Subscribers.GetInvocationList().Length > 0)
            {
                Console.WriteLine($"{Name}: Publish an event for a new video \"{video.Title}\" to all subscribers!");
                Subscribers(Name, video);
            } else
            {
                Console.WriteLine("No subscribers to this channel.");
            }
        }
    }
}
