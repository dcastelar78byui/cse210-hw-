class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address)
    {
        this._weather = weather;
    }

    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nWeather: {_weather}";
    }
}
