class EternalGoal : Goal
{
    private string description;
    private string points;
    private string isComplete;

    public EternalGoal(string name, string description, int points):base(name, description,points)
    {
    }
    public EternalGoal(string savedString):base(savedString)
    {
    }

    public EternalGoal(string savedString, string name, string description, string points, string isComplete) : this(savedString)
    {
        Name = name;
        this.description = description;
        this.points = points;
        this.isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine(string.Format("Goal {0} is an eternal goal and cannot be completed.", Name));  
        return 0;
    }

    public override string ToSavedString()
    {
        return $"{"EternalGoal"},{Name},{_description},{_points}";
    }
}
//