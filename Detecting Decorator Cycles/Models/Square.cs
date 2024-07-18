public sealed class Square : Shape
{
    private readonly float side;

    public Square() : this(0)
    {
    }

    public Square(float side)
    {
        this.side = side;
    }

    public override string AsString() => $"A square with side {side}";
}