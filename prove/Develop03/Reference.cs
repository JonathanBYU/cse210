using System;

class Reference {
    string _book;
    string _chapter;
    string _startVerse;
    string _endVerse;
    
    public Reference(string book, string chapter, string startVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetFormattedReference() {
        return $"{_book} {_chapter}:{_startVerse}";
    }
}