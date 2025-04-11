using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public string GetCustomer()
    {
        return $"Name: {_name}, Address: {_address.GetAddress()}";
    }

    public Address GetAddress()
    {
        return _address;
    }
}