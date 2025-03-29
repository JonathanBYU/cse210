using System;

class Program
{
    static void DisplayMenu() {
        Console.Clear();
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void WaitAnimation(int seconds) {
        List<string> animationStrings = new List<string>{"-","\\","|","/"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while (DateTime.Now < endTime) {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
    }

    static void Main(string[] args) {
        bool running = true;
        int activities = 0;
        while (running) {
            DisplayMenu();
            string input = Console.ReadLine();
            
            Activity activity = null;

            if (input == "1") {
                activity = new Breathing();
            } else if (input == "2") {
                activity = new Reflection();
            } else if (input == "3") {
                activity = new Listing();
            } else if (input == "4") {
                Console.WriteLine("Quitting the program...");
                Environment.Exit(0);
            }

            if (activity != null) {
                Console.Clear();
                Console.WriteLine(activity.GetStartMessage());

                Console.Write("\nHow long, in seconds, would you like for your session? ");
                string durationInput = Console.ReadLine();
                int duration = Convert.ToInt16(durationInput);
                activity.SetDuration(duration);
                Console.Clear();

                Console.WriteLine("Get Ready...\n");
                WaitAnimation(5);

                activity.RunActivity(duration);
                
                activities += 1;
                Console.WriteLine($"Well done!! You have now performed {activities} activites!");
                WaitAnimation(5);
                Console.WriteLine(activity.GetEndMessage());
                WaitAnimation(5);
            }
        }
    }
}