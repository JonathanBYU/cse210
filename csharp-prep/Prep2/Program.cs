using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int grade = Convert.ToInt16(Console.ReadLine());
        char letter;

        if (grade >= 90) {
            letter = 'A';
        } else if (grade >= 80) {
            letter = 'B';
        } else if (grade >= 70) {
            letter = 'C';
        } else if (grade >= 60) {
            letter = 'D';
        } else {
            letter = 'F';
        }

        char sign = '\0';

        if ((grade % 10 >= 7) && (letter != 'A') && (letter != 'F')) {
            sign = '+';
        } else if ((grade % 10 < 3) && (letter != 'A') && (letter != 'F')) {
            sign = '-';
        }

        Console.WriteLine($"You got an {letter}{sign}");

        if (grade >= 70) {
            Console.WriteLine("You passed the course! Congratulations!");
        } else {
            Console.WriteLine("You failed :(. Do better next time though I believe in you.");
        }
    }
}