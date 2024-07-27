// See https://aka.ms/new-console-template for more information

using _45VectorRaster;

Console.WriteLine("Hello, World!");

Demo.Run(null);
public class Demo
{
    private static List<VectorObject> vectorObjects =
    [
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 5, 6)
    ];
    public static void DrawPoint(Point p)
    {
        Console.Write($"[{p.X}, {p.Y}]");
    }

    public static void Run(string[] args)
    {
        Draw();
        Draw();
    }

    private static void Draw()
    {
        foreach (var vectorObject in vectorObjects)
        {
            foreach (var line in vectorObject)
            {
                LineToPointAdapter adapter = new LineToPointAdapter(line);
                foreach (var point in adapter)
                {
                    DrawPoint(point);
                }
            }
        }
    }
}
