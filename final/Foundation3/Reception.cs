using System;

class Reception : Event
{
    private bool _isRegistered;

    public Reception(bool isRegistered, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _isRegistered = isRegistered;
    }

    public bool GetRegistered()
    {
        return _isRegistered;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Event Type: Reception, Please RSVP";
    }
}