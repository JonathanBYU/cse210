using System;
class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, int length) : base(date,length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _length / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}