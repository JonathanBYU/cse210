using System;

class Job {
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;
    public void Display() {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}

class Resume {
    string name;
    public List<Job> jobs = new List<Job>();
    public void Display() {
        Console.WriteLine(name);
        foreach Job job in jobs
    }
}

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Microsoft";
        job1.jobTitle = "Software Engineer";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2.company = "Apple";
        job2.jobTitle = "Manager";
        job2.startYear = 2022;
        job2.endYear = 2023;

        job1.Display();
        job2.Display();

        Resume resume = new Resume();
        resume.jobs.Add(job2);
        Console.WriteLine(resume.jobs[0].jobTitle);
    }
}