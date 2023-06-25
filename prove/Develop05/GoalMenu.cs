class GoalMenu : Menu
{
    private GoalData _goalData;

    public GoalMenu(GoalData goalData) : base("Goal Menu", new List<string> {"Create Simple Goal", "Create Eternal Goal", "Create Checklist Goal"}, "Enter option1: ")
    {
        _goalData = goalData;
    }

    public override int Show()
    {
        for (int i = 0; i < base._options.Count; i++)
        {
            Console.WriteLine($"[{i+1}] {base._options[i]}");
        }

        int option = base.GetValidInt(_prompt);
        switch (option)
        {
            case 1:
                CreateSimpleGoal();
                return Show();
            case 2:
                CreateEternalGoal();                
                return Show();
            case 3:
                CreateChecklistGoal();
                return Show();
            default:
                Console.WriteLine("Invalid option. Please enter a valid number.");
                return Show();
        }
    }
    private void CreateSimpleGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = GetValidInt("Invalid points. Please enter a valid number: ");
        Goal goal = new SimpleGoal(name, description, points);
        _goalData.AddGoal(goal);
        Console.WriteLine("Simple goal created successfully.");
    }

    private void CreateEternalGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = GetValidInt("Invalid points. Please enter a valid number: ");
        Goal goal = new EternalGoal(name, description, points);
        _goalData.AddGoal(goal);
        Console.WriteLine("Eternal goal created successfully.");
    }

    private void CreateChecklistGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = GetValidInt("Invalid points. Please enter a valid number: ");
        Console.Write("Enter times to complete: ");
        int timesToComplete = GetValidInt("Invalid times. Please enter a valid number: ");
        Console.Write("Enter bonus amount: ");
        int bonusAmount = GetValidInt("Invalid bonus amount. Please enter a valid number: ");
        Goal goal = new ChecklistGoal(name, description, points, timesToComplete, bonusAmount);
        _goalData.AddGoal(goal);
        Console.WriteLine("Checklist goal created successfully.");
    
    }

    
}
//