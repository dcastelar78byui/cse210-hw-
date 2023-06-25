using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class SimpleGoal : CompletableGoal
{
    private string description;
    private string points;
    private string isComplete;

    public SimpleGoal(string name, string description, int points):base(name, description,points)
    {

    }

    public SimpleGoal(string savedString):base(savedString)
    {

    }

    public SimpleGoal(string savedString, string name, string description, string points, string isComplete) : this(savedString)
    {
        Name = name;
        this.description = description;
        this.points = points;
        this.isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            Console.WriteLine("Goal {0} is already completed.", _name);
            return 0;
        }
    }
    public override string ToSavedString()
    {
        return $"{"SimpleGoal"},{Name},{_description},{_points},{_isComplete}";
    }
}
