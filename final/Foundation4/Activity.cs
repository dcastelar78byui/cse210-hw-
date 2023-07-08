using System;

class Activity
{
    protected DateTime _date;
    protected int _duration;

    public Activity(DateTime date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return string.Empty;
    }
}
