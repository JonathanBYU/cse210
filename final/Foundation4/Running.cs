using System;

class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, int length) : base(date,length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}