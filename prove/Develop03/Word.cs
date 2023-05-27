using System;
using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public string GetRenderedText()
    {
        if (_hidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}