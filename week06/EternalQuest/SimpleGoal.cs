using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // When created, a simple goal is inherently incomplete
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Stub
    }

    public override bool IsComplete()
    {
        // Stub
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Stub
        return "";
    }
}
