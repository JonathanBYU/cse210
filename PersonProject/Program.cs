// See https://aka.ms/new-console-template for more information
class Program {
    public static void Main(string[] args) {
        Person myPerson = new Person("Bob", "Bubba", 97);
        
        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        PoliceMan myPoliceMan = new PoliceMan("Taser", "Joe", "Mama", 32);

        Console.WriteLine($"{myPoliceMan.DisplayPoliceManInfo()}");

        Doctor myDoctor = new Doctor("Bandage", "Henry", "Smith", 40);
        Console.WriteLine($"{myDoctor.DisplayDoctorInfo()}");

        myPoliceMan.SetHeight(73);
        Console.WriteLine($"Police Man Height: {myPoliceMan.GetHeight()} inches");

    }
}