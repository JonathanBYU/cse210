using System;

abstract class Activity {
    protected abstract string _name { get; }
    protected abstract string _description { get; }
    private int _duration;
    
    public abstract void RunActivity(int duration);

    public void SetDuration(int duration) {
        _duration = duration;
    }

    public string GetStartMessage() {
        return $"Welcome to the {_name} Activity.\n\n{_description}";
    }

    public string GetEndMessage() {
        return $"You have completed another {_duration} seconds of the {_name} Activity.";
    }
}