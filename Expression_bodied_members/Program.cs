using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class Vector
    {
        private double x;
        private double y;

        //생성자 람다
        public Vector(double x) => this.x = x;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //소멸자 람다
        ~Vector() => Console.WriteLine("~Vector()");

        //프로퍼티 set 람다
        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        //인덱서 람다
        public double this[int index]
        {
            get => (index == 0) ? x : y;
            set => _ = (index == 0) ? x = value : y = value;
        }

        private EventHandler positionChanged;

        //이벤트 add remove도 쌉가능
        public event EventHandler PositionChanged
        {
            add => this.positionChanged += value;
            remove => this.positionChanged -= value;
        }

        public Vector Move(double dx, double dy)
        {
            x += dx;
            y += dy;

            positionChanged?.Invoke(this, EventArgs.Empty);

            return this;
        }

        public void PrintIt() => Console.WriteLine(this);

        public override string ToString() => string.Format("x = {0}, y = {1}", x, y);
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}