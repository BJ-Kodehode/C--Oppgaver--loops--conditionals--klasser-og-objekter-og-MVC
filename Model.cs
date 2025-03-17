namespace MovieApp;

public class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }

    public Movie(string title, int year)
    {
        Title = title;
        Year = year;
    }
}

public class Model
{
    public List<Movie> Movies { get; private set; }

    public Model()
    {
        Movies = new List<Movie>
        {
            new Movie("Inception", 2010),
            new Movie("The Matrix", 1999),
            new Movie("Interstellar", 2014)
        };
    }

    public void AddMovie(string title, int year)
    {
        Movies.Add(new Movie(title, year));
    }

    public bool RemoveMovie(string title)
    {
        var movie = Movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (movie != null)
        {
            Movies.Remove(movie);
            return true;
        }
        return false;
    }
}
