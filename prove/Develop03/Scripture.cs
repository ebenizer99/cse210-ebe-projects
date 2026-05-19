using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            List<int> visibleWordIndexes = new List<int>();

            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                {
                    visibleWordIndexes.Add(j);
                }
            }

            if (visibleWordIndexes.Count > 0)
            {
                int randomVisibleIndex = random.Next(visibleWordIndexes.Count);
                int wordIndex = visibleWordIndexes[randomVisibleIndex];

                _words[wordIndex].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text;
    }

    public bool IsCompletelyHidden()
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
}