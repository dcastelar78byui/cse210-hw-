using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


abstract class Goal
{
    protected string _description;
    protected int _points;
    
    protected string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal(string savedString)
    {
        string[] data = savedString.Split(',');
        _name = data[1];
        _description = data[2];
        _points = int.Parse(data[3]);
    }

    public abstract int RecordEvent();
    
    public virtual string ToSavedString()
    {
        return string.Format("{0},{1},{2},{3}", GetType().Name, _name, _description, _points);
    }

    public override string ToString()
    {
        return string.Format("Name: {0}\nDescription: {1}\nPoints: {2}", _name, _description, _points);
    }
}