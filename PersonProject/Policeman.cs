class PoliceMan : Person {
    private string _weapons;


    public PoliceMan(string weapons, string firstName, string lastName, int age) : base(firstName, lastName, age) {
        _weapons = weapons;
    }

    public string GetPoliceManInfo() {
        return $"{_weapons}, Info: {GetPersonInfo()}";
    }

    public override string GetName() {
        return $"Captain {base.GetName()}";
    }

    public override string GetHobbies() {
        return "Running";
    }
}