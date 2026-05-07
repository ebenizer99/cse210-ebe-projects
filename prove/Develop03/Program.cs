using System;

// EXCEEDING REQUIREMENTS:
// - The program stores multiple scriptures in a library.
// - The program randomly selects a scripture each time it runs.
// - The program hides only words that are not already hidden.
// - The program hides multiple random words at a time.
// - The program supports verse ranges.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        ));

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"
        ));

        scriptures.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God"
        ));

        Random random = new Random();

        int scriptureIndex = random.Next(scriptures.Count);

        Scripture scripture = scriptures[scriptureIndex];

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.Write("Press enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
    }
}

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

class Scripture
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

class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
        _text = text;

        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}