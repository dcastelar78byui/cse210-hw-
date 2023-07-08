class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this._laps = laps;
    }
    	/// pool is 50 meters
    public override double GetDistance()
    {
        return (_laps * 50)/1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration);
    }

    public override double GetPace()
    {
        return (_duration / GetDistance());
    }
    //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    public override string GetSummaryKM()
    {
        double distanceKm = GetDistance();
        double speedKm = GetSpeed();
        double paceKm = GetPace();        
        return $"{_date:dd MMM yyyy} Swimming ({_duration} min): Distance {distanceKm:F1} km, Speed: {speedKm:F1} kph, Pace: {paceKm:F1} min per km";
    }

    //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    public override string GetSummaryMi()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        double distanceMiles = GetDistance() * 0.62;
        double speedMph = GetSpeed() * 0.62;
        double paceMinutesPerMile = GetPace() * 0.62;

        return $"{formattedDate} Swimming ({_duration} min): Distance {distanceMiles:F1} miles, Speed {speedMph:F1} mph, Pace: {paceMinutesPerMile:F1} min per mile";
    }

}
