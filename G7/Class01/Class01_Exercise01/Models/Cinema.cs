namespace Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Cinema name is empty!");
            }

            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public string WatchMovie(Movie movie)
        {
            if(movie == null)
            {
                throw new Exception("Movie is null");
            }

            //int, string, chars => Contains

            //LINQ Where statement transfer to Foreach statement
            //List<Movie> resultList = new List<Movie>();
            //foreach(Movie x in Movies)
            //{
            //    if(x.Title == "Avatar")
            //    {
            //        resultList.Add(x);
            //    }
            //}

            //Movies.Where(x => x.Title == "Avatar");

            if(!Movies.Any(x => x.Title.ToLower() == movie.Title.ToLower()))
            {
                throw new Exception($"The movie {movie.Title} is not played in {Name}");
            }

            return $"Watching {movie.Title}";
        }
    }
}
