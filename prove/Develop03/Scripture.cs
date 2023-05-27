using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(GetRenderedText());
    }

    public bool AllWordsHidden()
{
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            return false;
        }
    }

    return true;
}

    public void HideWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    private string GetRenderedText()
    {
        List<string> visibleWords = new List<string>();

        foreach (Word word in _words)
        {
            visibleWords.Add(word.GetRenderedText());
        }

        return string.Join(" ", visibleWords);
    }
}