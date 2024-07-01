using System;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            //Ваш код!
            Circle circle = new Circle(100, 10, 15, "red");
            circle.Move(5, 10);
            circle.PrintInfo();

            object[] data = {rect, rt};
            Print(data);

            Date date1 = new Date();
            date1.Year = 2020; // високосный год
            date1.Month = 2;
            date1.Day = 28;
            Console.WriteLine(date1);

            Date date2 = new Date(28, 2, 2020);
            Console.WriteLine(date2);
        }

        public static void Print(object[] data)
        {

        }
    }
}
