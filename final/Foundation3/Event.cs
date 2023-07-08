using System;

class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDate: {_date.ToShortDateString()}\nTime:{_time.ToShortTimeString()}";
    }

    public virtual string GetFullDetails()
    {
        string addressDetails = _address.GetFullAddress();
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {addressDetails}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
