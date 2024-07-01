namespace Inheritance
{
    internal class Circle : Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }
        private int radius;
        public int Radius 
        { 
            get => radius; 
            set
            {
                if (value > 0) radius = value;
                else throw new ArgumentOutOfRangeException("invalid radius");
            }
        }
        public Circle(int X, int Y, int Radius, string Color = DEFAULT_COLOR) : base(Color)
        {
            this.X = X;
            this.Y = Y;
            this.Radius = Radius; 
        }
        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public void Scale(double factor)
        {
            Radius = (int)(Radius * factor);
        }
        public override void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{GetType().Name} X={X} Y={Y} Radius={Radius} Color={Color}";
        }
    }
}
