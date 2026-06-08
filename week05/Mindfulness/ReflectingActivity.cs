using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
        // Stub
    }

    public string GetRandomPrompt()
    {
        // Stub with a dummy return so it compiles
        return "";
    }

    public string GetRandomQuestion()
    {
        // Stub with a dummy return so it compiles
        return "";
    }

    public void DisplayPrompt()
    {
        // Stub
    }

    public void DisplayQuestions()
    {
        // Stub
    }
}
