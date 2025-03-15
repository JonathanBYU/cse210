using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter the book name: ");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter number: ");
        string chapter = Console.ReadLine();
        Console.WriteLine("Enter the first verse number: ");
        string firstVerse = Console.ReadLine();
        Console.WriteLine("Enter the last verse number: (Type 'N' if there is only 1 verse)");
        string lastVerse = Console.ReadLine();
        Console.WriteLine("Enter the text of the scripture: ");
        string scriptureText = Console.ReadLine();
        
        Scripture scripture;

        if (string.Equals(lastVerse.ToUpper(),"N")) { // Case insensitive comparrison
            scripture = new Scripture(new Reference(book, chapter, firstVerse), scriptureText);
        } else {
            scripture = new Scripture(new Reference(book, chapter, firstVerse, lastVerse), scriptureText);
        }

        while (!scripture.IsCompletelyHidden) {
            Console.Clear();
            Console.WriteLine(scripture.GetFormattedScripture());
            
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (string.Equals(input,"quit")) {
                Environment.Exit(0);
            } else {
                scripture.HideRandom(3);
            }
        }
    }
}