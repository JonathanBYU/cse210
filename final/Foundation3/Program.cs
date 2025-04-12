using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12345", 123, "Example St.", "Rexburg", "ID");
        Address address2 = new Address("54321", 321, "Example Road", "Atlanta", "GA");
        Address address3 = new Address("67890", 456, "Example Ct.", "New York", "NY");
        Event[] events = [new Lecture("Jonathan", 250, "Public Speaking Lecture", "Improve your public speaking", "4/11/2025", "6:40 PM", address1), new OutdoorGathering("It will be 70 degrees fahrenheit with no rain.","Wedding", "Marriage between James and Sally.", "4/11/2025", "6:44 PM", address2), new Reception(true, "Award Ceremony", "Recognize accomplishments throughout the company.", "4/11/2025", "6:48 PM", address3)];

        foreach (Event myEvent in events)
        {
            Console.WriteLine($"\n{myEvent.GetStandardDetails()}");
            Console.WriteLine(myEvent.GetFullDetails());
            Console.WriteLine(myEvent.GetShortDescription());
        }
     }
}