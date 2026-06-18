using System;

class Program
{
    static void Main(string[] args)
    {
        // This program demonstrates object-oriented principles through a
        // polymorphic Goal hierarchy (SimpleGoal, EternalGoal, ChecklistGoal).
        // It also exceeds the core requirements by supporting user-created
        // goals, score/rank tracking, and saving/loading progress to a file.
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}