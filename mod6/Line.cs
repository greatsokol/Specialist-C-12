namespace Inheritance
{
    internal class Line : Shape
    {
        int X1 { get; set; }
        int Y1 { get; set; }
        int X2 { get; set; }
        int Y2 { get; set; }

        public Line(int X1, int Y1, int X2, int Y2, string Color = DEFAULT_COLOR) : base(Color) 
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }
        public void MoveBy(int dx,  int dy)
        {
            X1 += dx;
            Y1 += dy;
            X2 += dx;
            Y2 += dy;
        }
        public void Scale(double factor)
        {
            X2 = (int)(X2 * factor);
            Y2 = (int)(Y2 * factor);
        }
        public override void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{GetType().Name} X1={X1} Y1={Y1} X2={X2} Y2={Y2} Color={Color}";
        }
    }
}
