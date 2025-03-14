using System;

class Entry
{
    // I declared these in this way to be json serializable
    public string _date { get; set; }
    public string _question { get; set; }
    public string _entry { get; set; }


    public Entry(string date, string question, string entryText) {
        _date = date;
        _question = question;
        _entry = entryText;
    }

    // Parameterless construtor required for deserialization
    public Entry() {}

    public override string ToString() {
        string outputString = "";
        outputString = $"{_date}#{_question}#{_entry}";
        return outputString;
    }
}