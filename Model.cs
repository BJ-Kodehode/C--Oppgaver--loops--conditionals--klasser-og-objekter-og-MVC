using System;
using System.Collections.Generic;

public class Model
{
    public List<string> Movies { get; private set; }

    public Model()
    {
        Movies = new List<string> { "Inception", "The Matrix", "Interstellar" };
    }

    public void AddMovie(string movie)
    {
        Movies.Add(movie);
    }
}
