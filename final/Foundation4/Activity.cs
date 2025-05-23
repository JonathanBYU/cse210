using System;

abstract class Activity
{
    private string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min) - Distance: {Math.Round(GetDistance(), 2)} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}