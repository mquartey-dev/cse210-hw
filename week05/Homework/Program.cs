using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Test the Base Assignment Class
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(); // Add a blank line for readability

        // 2. Test the Math Assignment Derived Class
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary()); // This method comes from the base class!
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        // 3. Test the Writing Assignment Derived Class
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary()); // Comes from the base class!
        Console.WriteLine(a3.GetWritingInformation());
    }
}