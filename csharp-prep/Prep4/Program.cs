using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter number: ");
        int number = Convert.ToInt16(Console.ReadLine());

        while (number != 0) {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = Convert.ToInt16(Console.ReadLine());
        };

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}