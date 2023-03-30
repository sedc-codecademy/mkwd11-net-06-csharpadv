namespace Models
{
    public class Movie
    {
        public string Title { get; set; }
        public GenreEnum Genre { get; set; }
        public int Rating { get; set; }
        //public int TicketPrice { get; set; }

        //public int TicketPrice
        //{
        //    get
        //    {
        //        return Rating * 5;
        //    }
        //}

        public int TicketPrice => Rating * 5;

        public Movie(string title, GenreEnum genre, int rating)
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new Exception("Title must have a value");
            }

            Title = title;

            Genre = genre;

            if(rating < 1 || rating > 5)
            {
                throw new Exception($"Rating is out of range, should be between 1-5, and it is {rating}");
            }

            Rating = rating;
            //TicketPrice = 5 * Rating;
        }

        //Movie a = new Movie("Avatar", SciFi, 4) => First approach: TicketPrice will be set to 20;
        //a.Rating = 3;
        //a.TicketPrice = 3 * 5;
        //a.TicketPrice = 100;
    }
}