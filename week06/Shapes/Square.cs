using System;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // The override keyword tells C# to use this specific math instead of the base class
    public override double GetArea()
    {
        return _side * _side;
    }
}
