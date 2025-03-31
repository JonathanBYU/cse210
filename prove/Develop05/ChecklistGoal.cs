using System;

class ChecklistGoal : Goal {
    private int _numberOfCompletions;
    private int _maxCompletions;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int pointsForCompletion, int maxCompletions, int bonusPoints) : base(name, description, pointsForCompletion) {
        _goalType = "ChecklistGoal";
        _maxCompletions = maxCompletions;
        _bonusPoints = bonusPoints;
    }

    // Parameterless construtor required for deserialization
    public ChecklistGoal() : base() {
        _goalType = "ChecklistGoal";
    }

    public override string ListGoal() {
        return $"[{(GetStatus() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Currently completed: {_numberOfCompletions}/{_maxCompletions}";
    }

    public override void RecordEvent() {
        if (_numberOfCompletions < _maxCompletions) {
            _numberOfCompletions += 1;
            SetPoints(GetPoints() + _pointsForCompletion);
        }
        if (!GetStatus()) {
            if (_numberOfCompletions == _maxCompletions) {
                _status = true;
                SetPoints(GetPoints() + _bonusPoints);
            }
        }
    }
}