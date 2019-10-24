using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector
{
    private double x;
    private double y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    //Lambda Indexer
    public double this[string angleType] =>
        angleType == "radian" ? this.Angle :
        angleType == "degree" ? RadianToDegree(this.Angle) : double.NaN;

    private double RadianToDegree(double angle) => angle * 180 / Math.PI;

    //Lambda Property
    public double Angle => Math.Atan2(y, x);

    //Lambda Method
    public Vector Move(double dx, double dy) => new Vector(x + dx, x + dy);

    public Vector Move1(double dx, double dy) => new Vector(x + dx, x + dy);

    public void PrintIt() => Console.WriteLine(this);

    public override string ToString() => string.Format("x = {0}, y = {1}", x, y);
}

namespace Lambda_Method
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}