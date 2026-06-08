using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // We call the GetStudentName() getter we created in the base class 
        // because the _studentName variable is strictly private.
        return $"{_title} by {GetStudentName()}";
    }
}
