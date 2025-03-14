using System;

class Program
{
    static void Main()
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);
        controller.Run();
    }
}