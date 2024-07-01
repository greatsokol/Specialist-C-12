using System;

namespace Geometry
{
    abstract class Shape
    {
        protected Fdata fd;

        public Shape(Fdata fd)
        {
            this.fd = fd;
        }
        public abstract double Area();
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public virtual void PrintInfo()
        {
            Console.Write(fd.type+":"+fd.x0+","+fd.y0+" color="+fd.color);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Shape)) base.Equals(obj);
            return fd.Equals(((Shape)obj).fd);
        }

        public static bool operator == (Shape shape1, Shape shape2)
        {
            return shape1.Equals(shape2);
        }
        public static bool operator != (Shape shape1, Shape shape2)
        {
            return !(shape1==shape2);
        }
    }
}
