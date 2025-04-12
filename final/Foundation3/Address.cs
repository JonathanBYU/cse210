using System;

class Address
{
    private string _zipCode;
    private int _houseNumber;
    private string _streetName;
    private string _city;
    private string _state;

    public Address(string zipCode, int houseNumber, string streetName, string city, string state)
    {
        _zipCode = zipCode;
        _houseNumber = houseNumber;
        _streetName = streetName;
        _city = city;
        _state = state;
    }

    public string GetAddress()
    {
        return $"{_houseNumber} {_streetName}, {_city}, {_state}, {_zipCode}";
    }
}