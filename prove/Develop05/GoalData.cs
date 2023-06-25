class GoalData
{
    private List<Goal> _goals;
    private int _points;

    public GoalData()
    {
        _goals = new List<Goal>();
        _points = 0;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CompletableGoal(int goalNumber)
    {
        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            int pointsEarned = _goals[goalNumber].RecordEvent();
            _points += pointsEarned;
            Console.WriteLine("Points earned: {0}", pointsEarned);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public List<string>GetGoalNames()
    {
        List<string>goalNames = new List<string>();
        foreach (Goal goal in _goals)
        {
            goalNames.Add(goal.Name);
            
        }
        return goalNames;
    }

    public void Load(string fileName)
    {
        //string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            string goalName = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            string isComplete = parts[4];
            if (parts[0]== "SimpleGoal")
            {
                SimpleGoal simGoal = new SimpleGoal(goalName, name, description, points, isComplete);
            }
            if (parts[0]== "EternalGoal")
            {
                EternalGoal eterGoal = new EternalGoal(goalName, name, description, points, isComplete);
            }

            if (parts[0]== "ChecklistGoal")
            {                
                string timesCompleted = parts[5];
                string timesToComplete = parts[6];
                string bonusAmount = parts[7];
                ChecklistGoal checkGoal = new ChecklistGoal(goalName, name, description, points, isComplete, timesCompleted,timesToComplete,bonusAmount);
            }
        }        

    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
	
                outputFile.WriteLine(goal.ToSavedString());
            }
        }

        

    }

    public void ShowGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine("[{0}] {1}", i, _goals[i].Name);
        }
        Console.WriteLine("Total Points: {0}", _points);
    }
}
