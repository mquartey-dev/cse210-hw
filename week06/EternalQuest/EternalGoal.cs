using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Eternal goals don't have any unique setup variables
    }

    public override void RecordEvent()
    {
        // Stub
    }

    public override bool IsComplete()
    {
        // Eternal goals are never truly complete!
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Stub
        return "";
    }
}
