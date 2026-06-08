using System;

// EXCEEDING REQUIREMENTS:
// To exceed the core requirements, I implemented a robust anti-duplication mechanism 
// in both the ReflectingActivity and ListingActivity. Rather than just selecting random 
// prompts/questions (which often results in duplicates during a single session), the program 
// creates a separate "unused" tracking list. As items are selected, they are removed from 
// the active pool. The pool automatically resets only when every single prompt/question 
// has been exhausted. This ensures a vastly improved and non-repetitive user experience.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
    }
}