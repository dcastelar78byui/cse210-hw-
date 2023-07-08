class Conference : Event
{
    private string _speaker;
    private int _capacity;

    public Conference(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
