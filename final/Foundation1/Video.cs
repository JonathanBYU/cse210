using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private Comment[] _comments;

    public Video(string title, string author, int length, Comment[] comments) {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetNumComments()
    {
        return _comments.Length;
    }

    public string DisplayVideo()
    {
        string videoString = $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of Comments: {GetNumComments()}\nComments:";
        foreach (Comment comment in _comments) {
            videoString = videoString + ' ' + comment.DisplayComment();
        }
        videoString = videoString + '\n';
        return videoString;
    }
}