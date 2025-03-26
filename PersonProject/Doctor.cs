class Doctor : Person {
    private string _tools;


    public Doctor(string tools, string firstName, string lastName, int age) : base(firstName, lastName, age) {
        _tools = tools;
    }

    public string GetDoctorInfo() {
        return $"{_tools}, Info: {GetPersonInfo()}";
    }

    public override string GetName() {
        return $"Doctor {base.GetName()}";
    }

    public override string GetHobbies() {
        return "Golf";
    }
}