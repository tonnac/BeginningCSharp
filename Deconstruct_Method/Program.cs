using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruct_Method
{
    internal class Rectangle
    {
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }

        public void Deconstruct(out int x, out int y, out int width, out int height)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 6, 20, 26);
            {
                (int x, int y) = rect;
                Console.WriteLine($"x == {x}, y == {y}");
            }

            {
                //의미 업네
                (int _, int _) = rect;

                //하나만 받기
                (int _, int y) = rect;
                Console.WriteLine($"y == {y}");
            }

            {
                (int x, int y, int width, int height) = rect;
                Console.WriteLine($"x == {x}, y == {y}, width = {width}, height = {height}");

                (int _, int _, int _, int _) = rect;

                (int _, int _, int _width, int _height) = rect;
                Console.WriteLine($"w == {_width}, h == {_height}");

                (var _, var _, var _, var last) = rect;
                Console.WriteLine($"last == {last}");
            }
        }
    }
}