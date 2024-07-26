// See https://aka.ms/new-console-template for more information

using _45VectorRaster;

Console.WriteLine("Hello, World!");


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
