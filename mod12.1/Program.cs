using System;
using System.Diagnostics.CodeAnalysis;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj == null) return base.Equals(obj);
            Fdata other = (Fdata)obj;
            return x0 == other.x0 && y0 == other.y0 &&
                a == other.a && b == other.b &&
                color == other.color && type == other.type;
            ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() { x0 = 1, y0 = 1, a = 3, b = 5 });
            rect.Move(2, 1);
            //rect.PrintInfo();
            //Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            //rt.PrintInfo();
            //Console.WriteLine(rt.Area());

            //Ваш код!
            Circle c1 = new Circle(new Fdata() { x0 = 1, y0 = 1, a = 1 });
            Circle c2 = new Circle(new Fdata() { x0 = 1, y0 = 1, a = 1 });
            c1.Move(-2, 5);
            c2.Move(-2, 5);
            //c.PrintInfo();
            //Console.WriteLine(c.Area());

            if (c1 == c2) Console.WriteLine("Equal");
            else Console.WriteLine("Not Equal");

            Shape[] data = { rect, rt, c1, c2 };

            Print(data);

            // Перегруженные операторы:
            Console.WriteLine(c1 == c2); 
            Console.WriteLine(c1 != c2);
            Console.WriteLine(rect == c2);
        }

        public static void Print(Shape[] data)
        {
            foreach (Shape sh in data)
            {
                sh.PrintInfo();
                Console.WriteLine(sh.Area());
            }
        }
    }
}
