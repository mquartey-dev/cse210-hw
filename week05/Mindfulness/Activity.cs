using System;
using System.Threading;

public class Activity
{
    // Protected variables so derived classes can modify them directly
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        // Default constructor stub
    }

    public void DisplayStartingMessage()
    {
        // Stub
    }

    public void DisplayEndingMessage()
    {
        // Stub
    }

    public void ShowSpinner(int seconds)
    {
        // Stub
    }

    public void ShowCountDown(int seconds)
    {
        // Stub
    }
}
