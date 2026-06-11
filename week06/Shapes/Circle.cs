using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        // Math.PI provides the precise value of Pi
        return Math.PI * _radius * _radius;
    }
}
