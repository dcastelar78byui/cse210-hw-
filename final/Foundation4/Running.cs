class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return $"Running: {_distance} km in {_duration} minutes";
    }
}
