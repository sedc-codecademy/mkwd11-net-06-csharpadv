using Models;

namespace Class01_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie movie1 = new Movie("Scary Movie", GenreEnum.Comedy, 2);
                Movie movie2 = new Movie("American Pie", GenreEnum.Comedy, 4);
                Movie movie3 = new Movie("Saw", GenreEnum.Horror, 4);
                Movie movie4 = new Movie("The Shining", GenreEnum.Horror, 3);
                Movie movie5 = new Movie("Rambo", GenreEnum.Action, 4);
                Movie movie6 = new Movie("The Terminator", GenreEnum.Action, 4);
                Movie movie7 = new Movie("Forrest Gump", GenreEnum.Drama, 5);
                Movie movie8 = new Movie("12 Angru Men", GenreEnum.Drama, 4);
                Movie movie9 = new Movie("Passengers", GenreEnum.SciFi, 4);
                Movie movie10 = new Movie("Interstellar", GenreEnum.SciFi, 4);
                Movie movie11 = new Movie("Airplane", GenreEnum.Comedy, 4);
                Movie movie12 = new Movie("Johnny English", GenreEnum.Comedy, 4);
                Movie movie13 = new Movie("The Ring", GenreEnum.Horror, 4);
                Movie movie14 = new Movie("Sinister", GenreEnum.Horror, 4);
                Movie movie15 = new Movie("RoboCop", GenreEnum.Action, 2);
                Movie movie16 = new Movie("Judge Dredd", GenreEnum.Action, 4);
                Movie movie17 = new Movie("The Social Network", GenreEnum.Drama, 4);
                Movie movie18 = new Movie("The Shawshank Redemption", GenreEnum.Drama, 4);
                Movie movie19 = new Movie("Inception", GenreEnum.SciFi, 4);
                Movie movie20 = new Movie("Avatar", GenreEnum.SciFi, 3);

                List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

                List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

                Cinema cinema1 = new Cinema("Cineplex");
                Cinema cinema2 = new Cinema("Milenium");

                cinema1.Halls = new List<int> { 1, 2, 3, 4 };
                cinema2.Halls = new List<int> { 1, 2 };
                cinema1.Movies = MovieSet1;
                cinema2.Movies = MovieSet2;

                Console.WriteLine(cinema1.WatchMovie(movie9));
                Console.WriteLine(cinema1.WatchMovie(movie1));
                //Console.WriteLine(cinema1.WatchMovie(movie18)); => throws error
                Console.WriteLine(cinema2.WatchMovie(movie12));
                Console.WriteLine(cinema2.WatchMovie(movie20));
                //Console.WriteLine(cinema2.WatchMovie(movie3)); => throws error
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error happened, please try again");
                Console.WriteLine(ex.Message);
            }

        }
    }
}