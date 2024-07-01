namespace Inheritance
{
    public class Point : Shape
    {
        int X {  get; set; }
        int Y { get; set; }

        public Point(int X, int Y, string Color = DEFAULT_COLOR) : base(Color)
        { 
            this.X = X;
            this.Y = Y;
        }

        public override void Draw()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{GetType().Name} X={X} Y={Y} Color={Color}";
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
