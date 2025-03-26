using System;

class Reflection : Activity {
    protected override string Name => "Reflection";
    protected override string Description => "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _prompts = new List<string>{ 
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    List<string> _reflectQuestions = new List<string>{ 
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
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime) {
            Console.WriteLine("\nBreathe in...");
            for (int i = 4; i > 0; i--) {
                Console.Write(i);
                Console.Write("\b \b");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Now breathe out...");
            for (int i = 6; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}