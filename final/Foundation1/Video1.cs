using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        this._comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public string GetInfoVideo()
    {
        return $"Title: {_title}, Author: {_author} Length: {_length}";
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine("Video title: " + _title);
        Console.WriteLine("   Author: " + _author);
        Console.WriteLine("   Length (seconds): " + _length);
        Console.WriteLine("   Number of Comments: " + GetCommentCount());
        Console.WriteLine(" ");
        Console.WriteLine("List of Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine("           " + comment.GetCommentInfo());
        }
        Console.WriteLine("");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("");
     }
}
