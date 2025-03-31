using System;
using System.Text.Json.Serialization;

abstract class Goal {
    [JsonInclude]
    protected string _goalType;
    [JsonInclude]
    private string _name;
    [JsonInclude]
    private string _description;
    [JsonInclude]
    private int _points;
    [JsonInclude]
    protected bool _status = false;
    [JsonInclude]
    protected int _pointsForCompletion = 0;
    public Goal(string name, string description, int pointsForCompletion) {
        _name = name;
        _description = description;
        _pointsForCompletion = pointsForCompletion;
    }
    
    // Parameterless construtor required for deserialization
    public Goal() {}

    public string GetName() {
        return _name;
    }

    public string GetDescription() {
        return _description;
    }

    public int GetPoints() {
        return _points;
    }

    public void SetPoints(int points) {
        _points = points;
    }

    public bool GetStatus() {
        return _status;
    }

    public virtual string ListGoal() {
        return $"[{(_status ? "X" : " ")}] {_name} ({_description})";
    }

    public abstract void RecordEvent();
}