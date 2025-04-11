using System;

class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment) {
        _name = name;
        _comment = comment;
    }

    public string DisplayComment()
    {
        return $"{_name}: {_comment}";
    }
}