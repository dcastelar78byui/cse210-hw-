class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this._laps = laps;
    }
    public override double GetDistance()
    {
        
    }

    public override double GetSpeed()
    {
        
    }

    public override double GetPace()
    {
        
    }

    public override string GetSummary()
    {
        return $"Swimming: {_laps} laps in {_duration} minutes";
    }
}
