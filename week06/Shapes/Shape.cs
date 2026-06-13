// Base class for all shapes
public class Shape
{
    // Store the color of the shape
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Return the color
    public string GetColor()
    {
        return _color;
    }

    // Change the color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method to calculate area
    // This method will be overridden in derived classes
    public virtual double GetArea()
    {
        return 0;
    }
}