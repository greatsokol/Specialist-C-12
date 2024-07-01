using System;

namespace Geometry
{
    class Circle : Shape
    {
        public double r
        {
            get { return fd.a; }
            set { fd.a=fd.b=value; }
        }
        public Circle(Fdata fd) : base(fd)
        {
            base.fd.b = base.fd.a;
            base.fd.type = Figures.Circle;
        }

        public override double Area()
        {
            return Math.PI*r*r;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" r=" + r);
        }
    }
}

