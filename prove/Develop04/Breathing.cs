using System;

class Breathing : Activity {
    protected override string Name => "Breathing";
    protected override string Description => "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    private List<string> _messages = new List<string>{ "Breathe in...", "Breathe out..." };

    public override void RunActivity(int duration) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime) {
            Console.WriteLine("\nBreathe in...");
            for (int i = 4; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
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