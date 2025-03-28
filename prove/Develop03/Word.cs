using System;

class Word {
    string _text;
    public bool IsHidden { get; private set; }

    public Word(string text) {
        _text = text;
        IsHidden = false;
    }

    public void Hide() {
        IsHidden = true;
    }

    public override string ToString() {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}