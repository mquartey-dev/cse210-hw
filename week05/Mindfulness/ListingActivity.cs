using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>();
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

    public List<string> GetListFromUser()
    {
        // Stub with a dummy return so it compiles
        return new List<string>();
    }
}
