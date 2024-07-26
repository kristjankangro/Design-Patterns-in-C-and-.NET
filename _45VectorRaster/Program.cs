// See https://aka.ms/new-console-template for more information

using System.Collections.ObjectModel;
using _45VectorRaster;

Console.WriteLine("Hello, World!");


public class LineToPointAdapter : Collection<Point>
{

    private static int count;
    public LineToPointAdapter(Line line)
    {
        Console.WriteLine($"{++count} generating points for line [{line.Start.X}{line.Start.Y}]-[{line.End.X}{line.End.Y}]");
    }
}
public class Demo
{
    private static List<VectorObject> vectorObjects = new List<VectorObject>
    {
        new VectorRectangle(1,1,10,10),
        new VectorRectangle(3, 3, 5, 6)
    };
    public static void DrawPoint(Point p)
    {
        Console.WriteLine("Draw point ");
    }
}
