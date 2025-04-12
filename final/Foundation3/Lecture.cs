using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Event Type: Lecture, Speaker Name: {_speaker}, Capacity: {_capacity}";
    }
}