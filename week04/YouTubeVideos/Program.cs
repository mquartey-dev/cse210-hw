using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a master list to hold all the videos
        List<Video> videos = new List<Video>();

        // 2. Create Video 1 and add comments
        Video v1 = new Video("C# Abstraction Tutorial", "CodeMaster99", 600);
        v1.AddComment(new Comment("Bob", "Great explanation of classes!"));
        v1.AddComment(new Comment("Alice", "This helped me pass my test."));
        v1.AddComment(new Comment("Charlie", "Can you do one on encapsulation next?"));
        videos.Add(v1); // Add to the master list

        // 3. Create Video 2 and add comments
        Video v2 = new Video("Top 10 Programming Languages in 2026", "TechDaily", 900);
        v2.AddComment(new Comment("Dave", "I still love Python."));
        v2.AddComment(new Comment("Eve", "C# is definitely number one for me."));
        v2.AddComment(new Comment("Frank", "Where is JavaScript?"));
        v2.AddComment(new Comment("Grace", "Nice list, thanks for sharing."));
        videos.Add(v2);

        // 4. Create Video 3 and add comments
        Video v3 = new Video("Funny Cat Compilation", "CatLover", 300);
        v3.AddComment(new Comment("Heidi", "The orange cat is hilarious!"));
        v3.AddComment(new Comment("Ivan", "I can't stop laughing."));
        v3.AddComment(new Comment("Judy", "Best 5 minutes of my day."));
        videos.Add(v3);

        // 5. Iterate through the list and display the information
        Console.WriteLine("--- YOUTUBE VIDEO TRACKER ---");
        Console.WriteLine();
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}