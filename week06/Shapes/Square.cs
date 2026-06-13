// Square inherits from Shape
public class Square : Shape
{
    // Store the side length
    private double _side;

    // Constructor
    public Square(string color, double side)
        : base(color)
    {
        _side = side;
    }

    // Calculate the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}