namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        public static double area(Fdata fd)
        {
            return fd.type switch
            {
                // "a" и "b" - диагонали ромба:
                Figures.Romb => (fd.a * fd.b) / 2, 
                // "a" и "b" - стороны прямоугольника: 
                Figures.Rect => fd.a * fd.b,
                // у равностороннего треугольника только однин размер "a" - длина стороны:
                Figures.RightTriangle => Math.Sqrt(3) * Math.Pow(fd.a, 2) / 4, 
                // у окружности только один размер "a" - радиус:
                Figures.Circle => Math.PI * Math.Pow(fd.a, 2),
                _ => -1
            };
        }

        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine($"{fd.type}, a={fd.a} b={fd.b} {area(fd)}");
            fd.type = Figures.Rect;
            Console.WriteLine($"{fd.type}, a={fd.a} b={fd.b} area={area(fd)}");
            fd.type = Figures.RightTriangle;
            Console.WriteLine($"{fd.type}, a={fd.a} area={area(fd)}");
            fd.type = Figures.Circle;
            Console.WriteLine($"{fd.type}, a={fd.a} area={area(fd)}");
        }
    }
}
