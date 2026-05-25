using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. Created a library of scriptures to choose from randomly.
        // 2. Upgraded the HideRandomWords method in Scripture.cs to only select from words 
        //    that are not already hidden, preventing redundant loops.

        List<Scripture> scriptureLibrary = new List<Scripture>();

        // Add a single verse
        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16), 
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        
        // Add a multiple verse range
        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        // Add an extra verse
        scriptureLibrary.Add(new Scripture(
            new Reference("1 Nephi", 3, 7), 
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        // Randomly select one scripture from the library
        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[index];

        // Main Program Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Check if everything is hidden BEFORE prompting user again
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words at a time
            scripture.HideRandomWords(3);
        }
    }
}