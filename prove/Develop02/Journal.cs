using System;

class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void ReadFromFile(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry(date,question,entryText);
            AddEntry(entry);
        }
    }

    public void WriteToFile(string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Entry entry in entries) {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
}