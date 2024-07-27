
using System.Collections;

public class LineToPointAdapter : IEnumerable<Point>
{
    private static int count;

    private static Dictionary<int, List<Point>> cache = new Dictionary<int, List<Point>>();
    public LineToPointAdapter(Line line)
    {
        var hashCode = line.GetHashCode();
        if (cache.ContainsKey(hashCode)) return;

        var points = new List<Point>();
        Console.WriteLine();
        Console.Write($"{++count} generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}] => ");
        int left = Math.Min(line.Start.X, line.End.X);
        int right = Math.Max(line.Start.X, line.End.X);
        int top = Math.Min(line.Start.Y, line.End.Y);
        int bottom = Math.Max(line.Start.Y, line.End.Y);
        int dx = right - left;
        int dy = line.End.Y - line.Start.Y;

        if (dx == 0)
        {
            for (int y = top; y <= bottom; ++y)
            {
                points.Add(new Point(left, y));
            }
        } else if (dy == 0)
        {
            for (int x = left; x <= right; ++x)
            {
                points.Add(new Point(x, top));
            }
        }
        cache.Add(hashCode, points);
    }

    public IEnumerator<Point> GetEnumerator()
    {
        return cache.Values.SelectMany(x => x).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}