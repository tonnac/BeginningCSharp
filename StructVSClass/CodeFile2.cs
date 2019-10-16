

class Point
{
    public int x;
    public int y;

    public Point()
    {

    }

    public Point(int X, int Y)
    {
        x = X;
        y = Y;
    }

    public override string ToString()
    {
        return "X: " + x + ", Y: " + y;
    }
}