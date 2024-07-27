public class Line
{
    public Point Start, End;

    public Line(Point start, Point end)
    {
        if (start != null) Start = start;
        if (end != null) End = end;
    }
}