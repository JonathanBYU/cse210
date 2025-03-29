using System;
using System.Collections.Generic;

class Reflection : Activity {
    protected override string _name => "Reflection";
    protected override string _description => "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _prompts = new List<string>{ 
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _reflectQuestions = new List<string>{ 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public override void RunActivity(int duration) {
        Random random = new Random();
        Console.WriteLine("Consider the following prompt:");
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine($"\n --- {randomPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string next = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime) {
            int questionIndex = random.Next(_reflectQuestions.Count);
            string randomQuestion = _reflectQuestions[questionIndex];
            Console.Write($"> {randomQuestion} ");
            for (int count = 5; count > 0; count--) {
                Console.Write(count);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}