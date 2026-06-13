// Circle inherits from Shape
public class Circle : Shape
{
    // Store the radius
    private double _radius;

    // Constructor
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    // Calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}