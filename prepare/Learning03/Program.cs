using System;

class Job {
    string company;
    string jobTitle;
    int startYear;
    int endYear;
    public void Display() {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}

class Resume {
    string name;
    Job[] jobs;
    public void Display() {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}