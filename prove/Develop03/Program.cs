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