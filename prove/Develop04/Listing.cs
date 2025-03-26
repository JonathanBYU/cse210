using System;

class Listing: Activity {
    protected override string Name => "Listing";
    protected override string Description => "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

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