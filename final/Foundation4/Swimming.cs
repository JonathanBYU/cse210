using System;

class Swimming : Activity
{
    private const double _lapLength = 50;
    private int _laps;

    public Swimming(int laps, string date, int length) : base(date,length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapLength / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}