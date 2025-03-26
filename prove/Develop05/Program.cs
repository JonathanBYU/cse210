using System;

class Program
{
    static void DisplayMenu() {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("You have ");
        Console.WriteLine("\n\tMenu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.Write("Select a choice from the menu: ");
    }
    static void Main(string[] args)
    {
        bool running = true;
        while (running) {
            DisplayMenu();
            string input = Console.ReadLine();

            if (input == "1") {
                goal = new Breathing();
            } else if (input == "2") {
                goal = new Reflection();
            } else if (input == "3") {
                goal = new Listing();
            } else if (input == "4") {
                Console.WriteLine("Quitting the program...");
                Environment.Exit(0);
            }
        }
    }
}