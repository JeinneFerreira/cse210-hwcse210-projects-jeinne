using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list that can store different shapes
        List<Shape> shapes = new List<Shape>();

        // Add shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        Console.WriteLine("Shapes Information");
        Console.WriteLine("------------------");

        // Display each shape's color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(
                $"Color: {shape.GetColor()} | Area: {shape.GetArea():F2}");
        }
    }
}