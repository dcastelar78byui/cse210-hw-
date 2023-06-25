abstract class Menu
{
    protected string _description;
    protected List<string> _options;
    protected string _prompt;

    public Menu(string description, List<string> options, string prompt)
    {
        _description = description;
        _options = options;
        _prompt = prompt;
    }

    protected int GetValidInt(string prompt)
    {
        int input;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(prompt);
        }
        return input;
    }
    
    public abstract int Show();
}
//
