using System;
using System.Collections.Generic;


class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        this._name = name;
        this._text = text;
    }

    public string GetCommentInfo()
    {
        return "Name: " + _name + ", Comment: " + _text;
    }
}
