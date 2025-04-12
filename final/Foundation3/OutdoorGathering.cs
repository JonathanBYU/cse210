using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string weatherForecast, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Event Type: OutdoorGathering, Weather Forecast: {_weatherForecast}";
    }
}