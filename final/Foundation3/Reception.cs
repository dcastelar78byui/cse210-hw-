class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nRSVP Email: {_rsvpEmail}";
    }
}
