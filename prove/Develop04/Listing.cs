using System;
using System.Collections.Generic;

class Listing: Activity {
    protected override string _name => "Listing";
    protected override string _description => "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _prompts = new List<string>{ 
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public override void RunActivity(int duration) {
        Random random = new Random();
        Console.WriteLine("List as many responses you can to the following prompt:");
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine($" --- {randomPrompt} ---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int itemsListed = 0;

        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed += 1;
        }
        Console.WriteLine($"You listed {itemsListed} items!");
    }
}