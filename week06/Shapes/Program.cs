using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the individual shapes
        Square s1 = new Square("Red", 3);
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        Circle s3 = new Circle("Green", 6);

        // Build the polymorphic list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        // Iterate through the list and let Polymorphism do the heavy lifting
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}