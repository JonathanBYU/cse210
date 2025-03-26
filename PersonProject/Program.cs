// See https://aka.ms/new-console-template for more information
// Virtual has a default, abstract doesn't have a default
class Program {
    public static void Main(string[] args) {
        PoliceMan myPoliceMan = new PoliceMan("Taser", "Joe", "Mama", 32);

        Console.WriteLine($"{myPoliceMan.GetPoliceManInfo()}");

        Doctor myDoctor = new Doctor("Bandage", "Henry", "Smith", 40);
        Console.WriteLine($"{myDoctor.GetName()}");
        Console.WriteLine($"{myDoctor.GetHobbies()}");

        myPoliceMan.SetHeight(73);
        Console.WriteLine($"Police Man Height: {myPoliceMan.GetHeight()} inches");
        Console.WriteLine($"{myPoliceMan.GetName()}");
        Console.WriteLine($"{myPoliceMan.GetHobbies()}");
    }
}