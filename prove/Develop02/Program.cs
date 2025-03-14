using System;

class Program {
    static void DisplayMenu() {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1 - Write a new entry");
        Console.WriteLine("2 - Display the journal");
        Console.WriteLine("3 - Save the journal to file");
        Console.WriteLine("4 - Load the journal from file");
        Console.WriteLine("5 - Exit");
        Console.Write("What would you like to do? ");
    }

    static void WriteEntry(Journal journal) {
        List<string> prompts = new List<string>{ "Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?" };
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        DateTime currentDate = DateTime.Now;
        string currentDateString = currentDate.ToString("yyyy-MM-dd");

        Console.WriteLine(randomPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        
        Entry newEntry = new Entry(currentDateString, randomPrompt, response);
        journal.AddEntry(newEntry);
    }

    static void Exit() {
        Console.WriteLine("Exiting the program...");
        Environment.Exit(0);
    }

    static void Main(string[] args) {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        bool running = true;
        while (running) {
            DisplayMenu();
            string input = Console.ReadLine();

            if (input == "1") {
                WriteEntry(journal);
            } else if (input == "2") {
                journal.Display();
            } else if (input == "3") {
                Console.WriteLine("What do you want to name the file (Omit file extension)? ");
                string fileName = Console.ReadLine();
                journal.WriteToFile(fileName);
            } else if (input == "4") {
                Console.WriteLine("What file would you like to load (Omit file extension)? ");
                string fileName = Console.ReadLine();
                journal.ReadFromFile(fileName);
            } else if (input == "5") {
                Exit();
            }
        }
    }
}