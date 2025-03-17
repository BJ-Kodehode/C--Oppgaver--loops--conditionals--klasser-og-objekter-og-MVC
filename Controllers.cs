namespace MovieApp;

public class Controller
{
    private readonly Model _model;
    private readonly View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nEnter a command (display, add, remove, exit):");
            string? choice = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (choice)
            {
                case "display":
                    _view.DisplayMovies(_model.Movies);
                    break;

                case "add":
                    Console.Write("Enter movie title: ");
                    string? title = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.WriteLine("Movie title cannot be empty.");
                        continue;
                    }

                    Console.Write("Enter movie year: ");
                    if (!int.TryParse(Console.ReadLine(), out int year))
                    {
                        Console.WriteLine("Invalid year. Try again.");
                        continue;
                    }

                    _model.AddMovie(title, year);
                    Console.WriteLine($"Added movie: {title} ({year})");
                    break;

                case "remove":
                    Console.Write("Enter movie title to remove: ");
                    string? removeTitle = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(removeTitle))
                    {
                        Console.WriteLine("Movie title cannot be empty.");
                        continue;
                    }

                    if (_model.RemoveMovie(removeTitle))
                    {
                        Console.WriteLine($"Movie '{removeTitle}' removed.");
                    }
                    else
                    {
                        Console.WriteLine("Movie not found.");
                    }
                    break;

                case "exit":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid command. Try again.");
                    break;
            }
        }
    }
}
