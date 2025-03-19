class Doctor : Person {
    private string _tools;


    public Doctor(string tools, string firstName, string lastName, int age) : base(firstName, lastName, age) {
        _tools = tools;
    }

    public string DisplayDoctorInfo() {
        return $"{_tools}, Info: {DisplayPersonInfo()}";
    }
}