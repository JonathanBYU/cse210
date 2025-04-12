using System;

abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address.GetAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}, Title: {_eventTitle}, Date: {_date}";
    }
}