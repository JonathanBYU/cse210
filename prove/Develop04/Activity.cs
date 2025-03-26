using System;

abstract class Activity {
    protected abstract string Name { get; }
    protected abstract string Description { get; }
    private int _duration;
    
    public abstract void RunActivity(int duration);

    public void SetDuration(int duration) {
        _duration = duration;
    }

    public string GetStartMessage() {
        return $"Welcome to the {Name} Activity.\n\n{Description}";
    }

    public string GetEndMessage() {
        return $"You have completed another {_duration} seconds of the {Name} Activity.";
    }
}