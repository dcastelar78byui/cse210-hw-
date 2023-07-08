class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    ///The pace (minutes per mile or minutes per kilometer) 
    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"Cycling: {_speed} km/h for {_duration} minutes";
    }
}
