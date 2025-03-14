using System;
using System.Collections.Generic;

public class View
{
    public void DisplayMovies(List<string> movies)
    {
        Console.WriteLine("Movie List:");
        foreach (var movie in movies)
        {
            Console.WriteLine("- " + movie);
        }
    }
}