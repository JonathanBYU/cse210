using System;

class Scripture {
    List<Word> _words;
    Reference _reference;
    public bool IsCompletelyHidden;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        IsCompletelyHidden = false;

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray) {
            _words.Add(new Word(word));
        }
    }

    public void HideRandom(int numWordsToHide) {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();
        List<Word> chosenWords = visibleWords.OrderBy(x => random.Next()).Take(numWordsToHide).ToList(); // Shuffles list and creates new list with first [numWordsToHide] words.
        foreach (Word word in chosenWords) {
            word.Hide(); // This will modify the words from the original _words list due to it referencing the same object in memory.
        }
        if (chosenWords.Count == 0) {
            IsCompletelyHidden = true;
        }
    }

    public string GetFormattedScripture() {
        List<string> visibleWords = _words.ConvertAll(word => word.ToString());
        string text = string.Join(" ", visibleWords);
        return $"{_reference.GetFormattedReference()} {text}";
    }
}