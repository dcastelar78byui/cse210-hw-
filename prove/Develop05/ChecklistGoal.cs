using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class ChecklistGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;
    private string description;
    private string points;
    private string isComplete;
    private string timesCompleted;
    private string timesToComplete;
    private string bonusAmount;

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount):base(name, description,points)
    {
        _bonusAmount = bonusAmount;
        _timesCompleted = 0;
        _timesToComplete = timesToComplete;
    }

    public ChecklistGoal(string savedString) : base(savedString)
    {
        string[] data = savedString.Split(',');
        _timesCompleted = int.Parse(data[5]);
        _timesToComplete = int.Parse(data[6]);
        _bonusAmount = int.Parse(data[7]);
    }

    public ChecklistGoal(string savedString, string name, string description, string points, string isComplete, string timesCompleted, string timesToComplete, string bonusAmount) : this(savedString)
    {
        Name = name;
        this.description = description;
        this.points = points;
        this.isComplete = isComplete;
        this.timesCompleted = timesCompleted;
        this.timesToComplete = timesToComplete;
        this.bonusAmount = bonusAmount;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _timesCompleted++;
            Console.WriteLine("Event recorded for {0}", _name);

            if (_timesCompleted >= _timesToComplete)
            {
                _isComplete = true;
                return _points + _bonusAmount;
            }
            else
            {
                return _points;
            }
        }
        else
        {
            Console.WriteLine("Goal {0} is already completed.", _name);
            return 0;
        }
    }
    //

    public override string ToSavedString()
    {
        return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", base.ToSavedString(), _timesCompleted, _timesToComplete, _bonusAmount);
    }

    public override string ToString()
    {
        return string.Format("{0}\nTimes Completed: {1}/{2}\nBonus Amount: {3}", base.ToString(), _timesCompleted, _timesToComplete, _bonusAmount);
    }
}