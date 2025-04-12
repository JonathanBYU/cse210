using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = [new Swimming(5, "4/11/2025", 100), new Cycling(10.0, "5/10/2025", 1000), new Running(30.5, "6/4/2025", 200)];
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}