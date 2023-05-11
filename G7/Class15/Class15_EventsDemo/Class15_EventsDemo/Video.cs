namespace Class15_EventsDemo
{
    public class Video
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public CategoryEnum Category { get; set; }
        public string Link { get; set; }

        public Video()
        {
            Id = Guid.NewGuid();
        }
}
}
