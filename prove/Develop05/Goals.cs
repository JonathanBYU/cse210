using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Goals {
    private int _points = 0;
    private List<Goal> _goals = new List<Goal>();

    public int GetPoints() {
        return _points;
    }

    public void SetPoints(int points) {
        _points = points;
    }

    public string ListGoals() {
        string goalsString = "";
        for (int i = 0; i < _goals.Count; i++) {
            goalsString = goalsString + '\n' + (i+1) + ". " + _goals[i].ListGoal();
        }
        return $"The goals are: {goalsString}";
    }

    public void ReadFromFile(string filename) {
        string jsonString = File.ReadAllText(filename+".json");

        var jsonDoc = JsonDocument.Parse(jsonString);
        _points = jsonDoc.RootElement.GetProperty("_points").GetInt32();
        _goals = new List<Goal>();

        foreach (var element in jsonDoc.RootElement.GetProperty("_goals").EnumerateArray()) {
            string goalType = element.GetProperty("_goalType").GetString();
            Goal goal = goalType switch {
                "SimpleGoal" => JsonSerializer.Deserialize<SimpleGoal>(element.GetRawText()),
                "ChecklistGoal" => JsonSerializer.Deserialize<ChecklistGoal>(element.GetRawText()),
                "EternalGoal" => JsonSerializer.Deserialize<EternalGoal>(element.GetRawText()),
                _ => throw new NotSupportedException($"Unknown goal type: {goalType}")
            };
            _goals.Add(goal);
        }
    }

    public void WriteToFile(string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename+".json")) {
            var jsonObject = new {
                _points = _points,
                _goals = _goals
            };
            string jsonString = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions { WriteIndented = true });
            outputFile.WriteLine(jsonString);
        }
    }

    public List<Goal> GetGoals() {
        return _goals;
    }

    public void AddGoal(Goal goal) {
        _goals.Add(goal);
    }
}