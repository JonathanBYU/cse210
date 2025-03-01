using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = Convert.ToInt16(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int num) {
        return num * num;
    }

    static void DisplayResult(string user_name, int sqr_num) {
        Console.WriteLine($"{user_name}, the square of your number is {sqr_num}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int num = PromptUserNumber();
        int sqr_num = SquareNumber(num);
        DisplayResult(user_name,sqr_num);
    }
}