// Rectangle inherits from Shape
public class Rectangle : Shape
{
    // Store the rectangle dimensions
    private double _length;
    private double _width;

    // Constructor
    public Rectangle(string color, double length, double width)
        : base(color)
    {
        _length = length;
        _width = width;
    }

    // Calculate the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}