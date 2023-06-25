using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

abstract class CompletableGoal : Goal
{
    protected bool _isComplete;
    
    public CompletableGoal(string name, string description, int points):base(name, description,points)
    {
        _isComplete = false;
    }

    public CompletableGoal(string savedString):base(savedString)
    {
        string[] data = savedString.Split(',');
        _isComplete = bool.Parse(data[4]); 
    }

     public override string ToSavedString()
     {
        return string.Format("{0},{1},{2},{3},{4}", base.GetType().Name, Name, _description, _points, _isComplete);
    
     }


    public override string ToString()
    {
        return string.Format("{0}\nIsComplete: {1}", base.ToString(), _isComplete);
    }

}