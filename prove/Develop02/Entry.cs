using System;

class Entry
{
    string _date;
    string _question;
    string _entry;


    public Entry(string date, string question, string entryText) {
        _date = date;
        _question = question;
        _entry = entryText;
    }

    public override string ToString() {
        string outputString = "";
        outputString = $"{_date}#{_question}#{_entry}";
        return outputString;
    }
}