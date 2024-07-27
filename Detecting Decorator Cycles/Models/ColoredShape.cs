using System.Text;

public class ColoredShape : ShapeDecorator<ColoredShape, CyclesAllowedPolicy>
{
    private readonly string color;

    public ColoredShape(Shape shape, string color) : base(shape)
    {
        this.color = color;
    }

    public override string AsString()
    {
        var sb = new StringBuilder($"{shape.AsString()}");

        if (policy.ApplicationAllowed(types[0], types.Skip(1).ToList()))
            sb.Append($" has the color {color}");

        return sb.ToString();
    }
}