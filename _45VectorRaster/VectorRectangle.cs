using System.Collections.ObjectModel;

namespace _45VectorRaster;

public class VectorRectangle : VectorObject
{
    private int X, Y, W, H;

    public VectorRectangle(int x, int y, int w, int h)
    {
        Add(new Line(new Point(x,y), new Point(x+w, y)));
        Add(new Line(new Point(x+w,y), new Point(x+w, y+h)));
        Add(new Line(new Point(x,y), new Point(x, y+h)));
        Add(new Line(new Point(x,y+h), new Point(x+w, y+h)));
        X = x;
        Y = y;
        W = w;
        H = h;
    }
}