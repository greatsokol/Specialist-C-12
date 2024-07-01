namespace Geometry
{
    class Circle
    {
        private int radius;
        public int Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                {
                    radius = value;
                } 
                else throw new ArgumentException("radius <= 0");
            }
        }

        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Circle(int radius, int x, int y, string color)
        {
            Radius = radius;
            X = x;
            Y = y;
            Color = color;
        }
        public double Area() => Math.PI * Math.Pow(Radius, 2);
        public void Move(int dx, int dy) {
            X += dx;
            Y += dy;
        }
        public void PrintInfo() => Console.WriteLine($"Circle with radius=\"{Radius}\" of color \"{Color}\" at X=\"{X}\", Y=\"{Y}\". It's area is {Area()}.");

    }
}
