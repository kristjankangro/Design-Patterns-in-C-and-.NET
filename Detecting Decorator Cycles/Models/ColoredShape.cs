namespace _63.Models;

public class ColoredShape : Shape
{
    private string color;
    private Shape shape;

    public ColoredShape(Shape shape, string color)
    {
        this.color = color;
        this.shape = shape;
    }

    public override string AsString() => $"{shape.AsString()} has color {color}";
}