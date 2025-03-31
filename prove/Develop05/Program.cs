using System;

class Program
{
    static void DisplayMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void DisplayGoalMenu() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }

    static void Main(string[] args)
    {
        Goals goals = new Goals();

        bool running = true;
        while (running) {
            Console.WriteLine($"\nYou have {goals.GetPoints()} points.\n");
            DisplayMenu();

            string input = Console.ReadLine();

            if (input == "1") {
                // Create new goal
                DisplayGoalMenu();
                string goalType = Console.ReadLine();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = Convert.ToInt32(Console.ReadLine());
                
                Goal goal;

                if (goalType == "1") {
                    goal = new SimpleGoal(name, description, points);
                    goals.AddGoal(goal);
                    Console.WriteLine("Goal Added");
                } else if (goalType == "2") {
                    goal = new EternalGoal(name, description, points);
                    goals.AddGoal(goal);
                    Console.WriteLine("Goal Added");
                } else if (goalType == "3") {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int maxCompletions = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());
                    goal = new ChecklistGoal(name, description, points, maxCompletions, bonusPoints);
                    goals.AddGoal(goal);
                    Console.WriteLine("Goal Added");
                }
                
            } else if (input == "2") {
                // List goals
                Console.WriteLine(goals.ListGoals());
            } else if (input == "3") {
                // Save goals
                Console.Write("What would you like to name the goals file (Omit file extension)? ");
                string fileName = Console.ReadLine();
                goals.WriteToFile(fileName);
                Console.Write("Your goals have been written to a file.");
            } else if (input == "4") {
                // Load goals
                Console.Write("What file would you like to load your goals from (Omit file extension)? ");
                string fileName = Console.ReadLine();
                goals.ReadFromFile(fileName);
            } else if (input == "5") {
                // Record event
                Console.WriteLine(goals.ListGoals());
                Console.Write("Which goal did you accomplish? ");
                int goalIndex = Convert.ToInt16(Console.ReadLine()) - 1;
                List<Goal> goalsList = goals.GetGoals();
                Goal goal = goalsList[goalIndex];
                goal.RecordEvent();
                int totalPoints = 0;
                foreach (Goal g in goals.GetGoals()) {
                    totalPoints += g.GetPoints();
                }
                goals.SetPoints(totalPoints);
                Console.WriteLine($"Congratulations!");
                Console.WriteLine($"You now have {goals.GetPoints()} points.");
            } else if (input == "6") {
                Environment.Exit(0);
            }
        }
    }
}