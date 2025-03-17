namespace MovieApp;

public class View
{
    public void DisplayMovies(List<Movie> movies)
    {
        Console.WriteLine("\nMovie List:");
        foreach (var movie in movies)
        {
            Console.WriteLine($"- {movie.Title} ({movie.Year})");
        }
    }
}
