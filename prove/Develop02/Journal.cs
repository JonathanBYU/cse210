using System;
using System.Text.Json;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void ReadFromFile(string filename) {
        string jsonString = File.ReadAllText(filename+".json");
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
    }

    public void WriteToFile(string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename+".json")) {
            string jsonString = JsonSerializer.Serialize(_entries);
            outputFile.WriteLine(jsonString);
        }
    }

    public void Display() {
        foreach (Entry entry in _entries) {
            Console.WriteLine(entry.ToString());
        }
    }
}