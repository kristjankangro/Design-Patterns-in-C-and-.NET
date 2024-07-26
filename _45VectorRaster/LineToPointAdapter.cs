using System.Collections.ObjectModel;

public class LineToPointAdapter : Collection<Point>
{

    private static int count;
    public LineToPointAdapter(Line line)
    {
        Console.WriteLine($"{++count} generating points for line [{line.Start.X}{line.Start.Y}]-[{line.End.X}{line.End.Y}]");
    }
}