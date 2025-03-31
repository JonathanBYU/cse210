using System;

class EternalGoal : Goal {
    public EternalGoal(string name, string description, int pointsForCompletion) : base(name, description, pointsForCompletion) {
        _goalType = "EternalGoal";
    }

    // Parameterless construtor required for deserialization
    public EternalGoal() : base() {
        _goalType = "EternalGoal";
    }

    public override void RecordEvent() {
        SetPoints(GetPoints() + _pointsForCompletion);
    }
}