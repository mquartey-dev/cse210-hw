using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Notice we accept 4 parameters, but pass 2 of them up to the base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        // We only need to set the variables specific to this class
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
