using System;

public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter a command (display, add, exit):");
            string? choice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            choice = choice.ToLower();

            if (choice == "display")
            {
                _view.DisplayMovies(_model.Movies);
            }
            else if (choice == "add")
            {
                Console.Write("Enter movie name: ");
                string? movie = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(movie))
                {
                    Console.WriteLine("Movie name cannot be empty.");
                    continue;
                }

                _model.AddMovie(movie);
            }
            else if (choice == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Try again.");
            }
        }
    }

}