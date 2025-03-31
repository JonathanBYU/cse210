using System;

class SimpleGoal : Goal {
    public SimpleGoal(string name, string description, int pointsForCompletion) : base(name, description, pointsForCompletion) {
        _goalType = "SimpleGoal";
    }

    // Parameterless construtor required for deserialization
    public SimpleGoal() : base() {
        _goalType = "SimpleGoal";
    }

    public override void RecordEvent() {
        if (!GetStatus()) {
            SetPoints(GetPoints() + _pointsForCompletion);
            _status = true;
        }
    }
}